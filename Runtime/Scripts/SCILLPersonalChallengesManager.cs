﻿using System.Collections.Generic;
using SCILL.Model;
using UnityEngine;

namespace SCILL
{
    public enum SCILLPersonalChallengeModificationType
    {
        Unknown,
        Unlocked,
        Activated,
        Completed,
        Claimed,
        Progress
    }


    /// <summary>
    ///     <para>
    ///         This class is designed as a “Singleton” and should be attached to the same GameObject that you have
    ///         <see cref="SCILLManager" /> attached. This class gives access to the Personal Challenge Categories and
    ///         Challenges and
    ///         provides events you can listen to in your own classes, to receive updates whenever Personal Challenge data
    ///         changes.
    ///     </para>
    /// </summary>
    public class SCILLPersonalChallengesManager : MonoBehaviour
    {
        public delegate void PersonalChallengesUpdatedFromServerAction(List<ChallengeCategory> categories);

        public delegate void PersonalChallengeUpdatedFromServerAction(Challenge challenge,
            SCILLPersonalChallengeModificationType modificationType);

        /// <summary>
        ///     As this class is designed as a singleton you can use this getter to get a reference to the instance. It allows you
        ///     to access the <c>SCILLPersonalChallengesManager</c> from anywhere in your code.
        /// </summary>
        public static SCILLPersonalChallengesManager Instance { get; private set; }

        /// <summary>
        ///     References to the challenge categories the user can access.
        /// </summary>
        public List<ChallengeCategory> Categories { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            SCILLManager.OnSCILLManagerReady += OnSCILLManagerReady;
        }

        private void OnDestroy()
        {
            if (SCILLManager.Instance)
                SCILLManager.Instance.StopChallengeUpdateNotifications(OnChallengeWebhookMessage);
        }

        /// <summary>
        ///     This event is called whenever an update of the personal challenges list is requested and the response was received.
        ///     This will happen on startup and when manually requesting an update using the
        ///     <see cref="UpdatePersonalChallengesList" /> method. It will supply all of the users challenge categories as
        ///     <see cref="ChallengeCategory" /> objects.
        /// </summary>
        public static event PersonalChallengesUpdatedFromServerAction OnPersonalChallengesUpdatedFromServer;

        /// <summary>
        ///     This event is called whenever a personal challenge is changed, e.g. when a challenge is unlocked, activated,
        ///     claimed, canceled or the progress was updated.
        /// </summary>
        public static event PersonalChallengeUpdatedFromServerAction OnPersonalChallengeUpdatedFromServer;

        private void OnSCILLManagerReady()
        {
            UpdatePersonalChallengesList();

            SCILLManager.Instance.StartChallengeUpdateNotifications(OnChallengeWebhookMessage);
        }

        private Challenge FindChallengeById(string id)
        {
            foreach (var category in Categories)
            foreach (var challenge in category.challenges)
                if (challenge.challenge_id == id)
                    return challenge;

            return null;
        }

        /// <summary>
        ///     Use this function to reload the personal challenge categories from the SCILL server and to trigger the
        ///     <see cref="OnPersonalChallengesUpdatedFromServer" /> event.
        /// </summary>
        public void UpdatePersonalChallengesList()
        {
            var categoriesPromise = SCILLManager.Instance.SCILLClient.GetAllPersonalChallengesAsync();
            categoriesPromise.Then(response =>
            {
                Categories = response;
                OnPersonalChallengesUpdatedFromServer?.Invoke(Categories);
            });
        }

        private void UpdateChallenge(ChallengeWebhookPayload payload)
        {
            var challenge = FindChallengeById(payload.new_challenge.challenge_id);
            if (challenge != null)
            {
                challenge.type = payload.new_challenge.type;
                challenge.user_challenge_current_score = payload.new_challenge.user_challenge_current_score;
                challenge.user_challenge_activated_at = payload.new_challenge.user_challenge_activated_at;
                challenge.user_challenge_unlocked_at = payload.new_challenge.user_challenge_unlocked_at;

                var type = SCILLPersonalChallengeModificationType.Unknown;
                if (payload.old_challenge.type != payload.new_challenge.type)
                {
                    if (payload.new_challenge.type == "unlocked")
                        type = SCILLPersonalChallengeModificationType.Unlocked;
                    else if (payload.new_challenge.type == "in-progress")
                        type = SCILLPersonalChallengeModificationType.Activated;
                    else if (payload.new_challenge.type == "finished")
                        type = SCILLPersonalChallengeModificationType.Completed;
                }
                else
                {
                    if (payload.new_challenge.user_challenge_current_score >
                        payload.old_challenge.user_challenge_current_score)
                        type = SCILLPersonalChallengeModificationType.Progress;
                }

                OnPersonalChallengeUpdatedFromServer?.Invoke(challenge, type);
            }
        }

        private void OnChallengeWebhookMessage(ChallengeWebhookPayload payload)
        {
            UpdateChallenge(payload);
        }
    }
}