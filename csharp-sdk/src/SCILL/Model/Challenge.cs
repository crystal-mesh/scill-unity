/* 
 * SCILL API
 *
 * SCILL gives you the tools to activate, retain and grow your user base in your app or game by bringing you features well known in the gaming industry: Gamification. We take care of the services and technology involved so you can focus on your game and content.
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@scillgame.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SCILL.Client.SwaggerDateConverter;

namespace SCILL.Model
{
    /// <summary>
    /// The challenge object holds all information about a users challenge. It contains information like the duration, the type, progress states like counter and the goal and various other info.
    /// </summary>
    [DataContract]
        public partial class Challenge :  IEquatable<Challenge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Challenge" /> class.
        /// </summary>
        /// <param name="challengeId">The unique id of this challenge. Every challenge is linked to a product..</param>
        /// <param name="challengeName">The name of the challenge in the language set by the language parameter..</param>
        /// <param name="challengeDescription">An optional multi-language description that can be set in the Admin Panel. Used to describe exactly what the user has to do..</param>
        /// <param name="challengeDurationTime">The duration of the challenge in seconds. Challenges auto lock after time-out and need to be unlocked again..</param>
        /// <param name="liveDate">The date this challenge should start. Use that field to create challenges that start in the future..</param>
        /// <param name="challengeGoal">Indicates how many “tasks” must be completed or done to complete this challenge..</param>
        /// <param name="userChallengeCurrentScore">Indicates how many tasks the user already has completed. Use this in combination with challenge_goal to render a nice progress bar..</param>
        /// <param name="challengeIcon">In the admin panel you can set a string representing an image. This can be a URL, but it can also be an image or texture that you have in your games asset database..</param>
        /// <param name="challengeIconHd">This is the HD variant of the challenge icon image. If you have a game, that runs on multiple platforms that could come in handy. Otherwise just leave blank..</param>
        /// <param name="challengePrice">If you purchase the challenge, you can set a price..</param>
        /// <param name="challengeReward">Set a reward for this challenge. This is a string value that you can map to anything in your code. Use in combination with challenge_reward_type..</param>
        /// <param name="challengeRewardType">The reward type can be set to various different settings. Use it to implement different reward types on your side and use challenge_reward to set the value or amount of this reward..</param>
        /// <param name="challengeGoalCondition">With this you can set the way how the SCILL system approaches the challenges state. 0 means, that the counter of the challenge must be brought above the goal. If this is 1, then the counter must be kept below the goal. This is often useful for challenges that include times, like: Manage the level in under 50 seconds..</param>
        /// <param name="challengeXp">If you have experience, player rankings whatever, you can use this field to set the gain in that when this challenge is rewarded..</param>
        /// <param name="repeatable">If this challenge can be only activated once per user this will be false. Otherwise this challenge will always be added to list of available challenges (see personal or alliance challenges)..</param>
        /// <param name="type">Indicates the status of the challenge. This can be one of the following unlock: Challenge does not track anything. in-progress: Challenge is active and tracking. overtime: User did not manage to finish the challenge in time. unclaimed: The challenge has been completed but the reward has not yet been claimed. finished: The challenge has been successfully be completed and the reward has been claimed.</param>
        /// <param name="challengeAutoActivated">Indicates if the challenges lifecycle is handled automatically by the SCILL backend. Use this flag to decide when to show action buttons for unlocking, activating, claiming or canceling challenges. Hide the buttons if this flag is true, and let the user manage challenges manually if this flag is false..</param>
        /// <param name="isClaimed">If the challenge reward has been claimed this is true otherwise its false..</param>
        /// <param name="userChallengeUnlockedAt">This is the timestamp the challenge has been unlocked..</param>
        /// <param name="userChallengeActivatedAt">This is the timestamp the challenge has been activated..</param>
        /// <param name="userChallengeIsClaimed">Indicates if this challenge has been claimed..</param>
        /// <param name="userChallengeStatus">Gives indication in what state the challenge is..</param>
        public Challenge(string challengeId = default(string), string challengeName = default(string), string challengeDescription = default(string), decimal? challengeDurationTime = default(decimal?), string liveDate = default(string), int? challengeGoal = default(int?), int? userChallengeCurrentScore = default(int?), string challengeIcon = default(string), string challengeIconHd = default(string), int? challengePrice = default(int?), string challengeReward = default(string), string challengeRewardType = default(string), int? challengeGoalCondition = default(int?), int? challengeXp = default(int?), bool? repeatable = default(bool?), string type = default(string), bool? challengeAutoActivated = default(bool?), bool? isClaimed = default(bool?), string userChallengeUnlockedAt = default(string), string userChallengeActivatedAt = default(string), bool? userChallengeIsClaimed = default(bool?), int? userChallengeStatus = default(int?))
        {
            this.challenge_id = challengeId;
            this.challenge_name = challengeName;
            this.challenge_description = challengeDescription;
            this.challenge_duration_time = challengeDurationTime;
            this.live_date = liveDate;
            this.challenge_goal = challengeGoal;
            this.user_challenge_current_score = userChallengeCurrentScore;
            this.challenge_icon = challengeIcon;
            this.challenge_icon_hd = challengeIconHd;
            this.challenge_price = challengePrice;
            this.challenge_reward = challengeReward;
            this.challenge_reward_type = challengeRewardType;
            this.challenge_goal_condition = challengeGoalCondition;
            this.challenge_xp = challengeXp;
            this.repeatable = repeatable;
            this.type = type;
            this.challenge_auto_activated = challengeAutoActivated;
            this.is_claimed = isClaimed;
            this.user_challenge_unlocked_at = userChallengeUnlockedAt;
            this.user_challenge_activated_at = userChallengeActivatedAt;
            this.user_challenge_is_claimed = userChallengeIsClaimed;
            this.user_challenge_status = userChallengeStatus;
        }
        
        /// <summary>
        /// The unique id of this challenge. Every challenge is linked to a product.
        /// </summary>
        /// <value>The unique id of this challenge. Every challenge is linked to a product.</value>
        [DataMember(Name="challenge_id", EmitDefaultValue=false)]
        public string challenge_id { get; set; }

        /// <summary>
        /// The name of the challenge in the language set by the language parameter.
        /// </summary>
        /// <value>The name of the challenge in the language set by the language parameter.</value>
        [DataMember(Name="challenge_name", EmitDefaultValue=false)]
        public string challenge_name { get; set; }

        /// <summary>
        /// An optional multi-language description that can be set in the Admin Panel. Used to describe exactly what the user has to do.
        /// </summary>
        /// <value>An optional multi-language description that can be set in the Admin Panel. Used to describe exactly what the user has to do.</value>
        [DataMember(Name="challenge_description", EmitDefaultValue=false)]
        public string challenge_description { get; set; }

        /// <summary>
        /// The duration of the challenge in seconds. Challenges auto lock after time-out and need to be unlocked again.
        /// </summary>
        /// <value>The duration of the challenge in seconds. Challenges auto lock after time-out and need to be unlocked again.</value>
        [DataMember(Name="challenge_duration_time", EmitDefaultValue=false)]
        public decimal? challenge_duration_time { get; set; }

        /// <summary>
        /// The date this challenge should start. Use that field to create challenges that start in the future.
        /// </summary>
        /// <value>The date this challenge should start. Use that field to create challenges that start in the future.</value>
        [DataMember(Name="live_date", EmitDefaultValue=false)]
        public string live_date { get; set; }

        /// <summary>
        /// Indicates how many “tasks” must be completed or done to complete this challenge.
        /// </summary>
        /// <value>Indicates how many “tasks” must be completed or done to complete this challenge.</value>
        [DataMember(Name="challenge_goal", EmitDefaultValue=false)]
        public int? challenge_goal { get; set; }

        /// <summary>
        /// Indicates how many tasks the user already has completed. Use this in combination with challenge_goal to render a nice progress bar.
        /// </summary>
        /// <value>Indicates how many tasks the user already has completed. Use this in combination with challenge_goal to render a nice progress bar.</value>
        [DataMember(Name="user_challenge_current_score", EmitDefaultValue=false)]
        public int? user_challenge_current_score { get; set; }

        /// <summary>
        /// In the admin panel you can set a string representing an image. This can be a URL, but it can also be an image or texture that you have in your games asset database.
        /// </summary>
        /// <value>In the admin panel you can set a string representing an image. This can be a URL, but it can also be an image or texture that you have in your games asset database.</value>
        [DataMember(Name="challenge_icon", EmitDefaultValue=false)]
        public string challenge_icon { get; set; }

        /// <summary>
        /// This is the HD variant of the challenge icon image. If you have a game, that runs on multiple platforms that could come in handy. Otherwise just leave blank.
        /// </summary>
        /// <value>This is the HD variant of the challenge icon image. If you have a game, that runs on multiple platforms that could come in handy. Otherwise just leave blank.</value>
        [DataMember(Name="challenge_icon_hd", EmitDefaultValue=false)]
        public string challenge_icon_hd { get; set; }

        /// <summary>
        /// If you purchase the challenge, you can set a price.
        /// </summary>
        /// <value>If you purchase the challenge, you can set a price.</value>
        [DataMember(Name="challenge_price", EmitDefaultValue=false)]
        public int? challenge_price { get; set; }

        /// <summary>
        /// Set a reward for this challenge. This is a string value that you can map to anything in your code. Use in combination with challenge_reward_type.
        /// </summary>
        /// <value>Set a reward for this challenge. This is a string value that you can map to anything in your code. Use in combination with challenge_reward_type.</value>
        [DataMember(Name="challenge_reward", EmitDefaultValue=false)]
        public string challenge_reward { get; set; }

        /// <summary>
        /// The reward type can be set to various different settings. Use it to implement different reward types on your side and use challenge_reward to set the value or amount of this reward.
        /// </summary>
        /// <value>The reward type can be set to various different settings. Use it to implement different reward types on your side and use challenge_reward to set the value or amount of this reward.</value>
        [DataMember(Name="challenge_reward_type", EmitDefaultValue=false)]
        public string challenge_reward_type { get; set; }

        /// <summary>
        /// With this you can set the way how the SCILL system approaches the challenges state. 0 means, that the counter of the challenge must be brought above the goal. If this is 1, then the counter must be kept below the goal. This is often useful for challenges that include times, like: Manage the level in under 50 seconds.
        /// </summary>
        /// <value>With this you can set the way how the SCILL system approaches the challenges state. 0 means, that the counter of the challenge must be brought above the goal. If this is 1, then the counter must be kept below the goal. This is often useful for challenges that include times, like: Manage the level in under 50 seconds.</value>
        [DataMember(Name="challenge_goal_condition", EmitDefaultValue=false)]
        public int? challenge_goal_condition { get; set; }

        /// <summary>
        /// If you have experience, player rankings whatever, you can use this field to set the gain in that when this challenge is rewarded.
        /// </summary>
        /// <value>If you have experience, player rankings whatever, you can use this field to set the gain in that when this challenge is rewarded.</value>
        [DataMember(Name="challenge_xp", EmitDefaultValue=false)]
        public int? challenge_xp { get; set; }

        /// <summary>
        /// If this challenge can be only activated once per user this will be false. Otherwise this challenge will always be added to list of available challenges (see personal or alliance challenges).
        /// </summary>
        /// <value>If this challenge can be only activated once per user this will be false. Otherwise this challenge will always be added to list of available challenges (see personal or alliance challenges).</value>
        [DataMember(Name="repeatable", EmitDefaultValue=false)]
        public bool? repeatable { get; set; }

        /// <summary>
        /// Indicates the status of the challenge. This can be one of the following unlock: Challenge does not track anything. in-progress: Challenge is active and tracking. overtime: User did not manage to finish the challenge in time. unclaimed: The challenge has been completed but the reward has not yet been claimed. finished: The challenge has been successfully be completed and the reward has been claimed
        /// </summary>
        /// <value>Indicates the status of the challenge. This can be one of the following unlock: Challenge does not track anything. in-progress: Challenge is active and tracking. overtime: User did not manage to finish the challenge in time. unclaimed: The challenge has been completed but the reward has not yet been claimed. finished: The challenge has been successfully be completed and the reward has been claimed</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string type { get; set; }

        /// <summary>
        /// Indicates if the challenges lifecycle is handled automatically by the SCILL backend. Use this flag to decide when to show action buttons for unlocking, activating, claiming or canceling challenges. Hide the buttons if this flag is true, and let the user manage challenges manually if this flag is false.
        /// </summary>
        /// <value>Indicates if the challenges lifecycle is handled automatically by the SCILL backend. Use this flag to decide when to show action buttons for unlocking, activating, claiming or canceling challenges. Hide the buttons if this flag is true, and let the user manage challenges manually if this flag is false.</value>
        [DataMember(Name="challenge_auto_activated", EmitDefaultValue=false)]
        public bool? challenge_auto_activated { get; set; }

        /// <summary>
        /// If the challenge reward has been claimed this is true otherwise its false.
        /// </summary>
        /// <value>If the challenge reward has been claimed this is true otherwise its false.</value>
        [DataMember(Name="is_claimed", EmitDefaultValue=false)]
        public bool? is_claimed { get; set; }

        /// <summary>
        /// This is the timestamp the challenge has been unlocked.
        /// </summary>
        /// <value>This is the timestamp the challenge has been unlocked.</value>
        [DataMember(Name="user_challenge_unlocked_at", EmitDefaultValue=false)]
        public string user_challenge_unlocked_at { get; set; }

        /// <summary>
        /// This is the timestamp the challenge has been activated.
        /// </summary>
        /// <value>This is the timestamp the challenge has been activated.</value>
        [DataMember(Name="user_challenge_activated_at", EmitDefaultValue=false)]
        public string user_challenge_activated_at { get; set; }

        /// <summary>
        /// Indicates if this challenge has been claimed.
        /// </summary>
        /// <value>Indicates if this challenge has been claimed.</value>
        [DataMember(Name="user_challenge_is_claimed", EmitDefaultValue=false)]
        public bool? user_challenge_is_claimed { get; set; }

        /// <summary>
        /// Gives indication in what state the challenge is.
        /// </summary>
        /// <value>Gives indication in what state the challenge is.</value>
        [DataMember(Name="user_challenge_status", EmitDefaultValue=false)]
        public int? user_challenge_status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Challenge {\n");
            sb.Append("  challenge_id: ").Append(challenge_id).Append("\n");
            sb.Append("  challenge_name: ").Append(challenge_name).Append("\n");
            sb.Append("  challenge_description: ").Append(challenge_description).Append("\n");
            sb.Append("  challenge_duration_time: ").Append(challenge_duration_time).Append("\n");
            sb.Append("  live_date: ").Append(live_date).Append("\n");
            sb.Append("  challenge_goal: ").Append(challenge_goal).Append("\n");
            sb.Append("  user_challenge_current_score: ").Append(user_challenge_current_score).Append("\n");
            sb.Append("  challenge_icon: ").Append(challenge_icon).Append("\n");
            sb.Append("  challenge_icon_hd: ").Append(challenge_icon_hd).Append("\n");
            sb.Append("  challenge_price: ").Append(challenge_price).Append("\n");
            sb.Append("  challenge_reward: ").Append(challenge_reward).Append("\n");
            sb.Append("  challenge_reward_type: ").Append(challenge_reward_type).Append("\n");
            sb.Append("  challenge_goal_condition: ").Append(challenge_goal_condition).Append("\n");
            sb.Append("  challenge_xp: ").Append(challenge_xp).Append("\n");
            sb.Append("  repeatable: ").Append(repeatable).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  challenge_auto_activated: ").Append(challenge_auto_activated).Append("\n");
            sb.Append("  is_claimed: ").Append(is_claimed).Append("\n");
            sb.Append("  user_challenge_unlocked_at: ").Append(user_challenge_unlocked_at).Append("\n");
            sb.Append("  user_challenge_activated_at: ").Append(user_challenge_activated_at).Append("\n");
            sb.Append("  user_challenge_is_claimed: ").Append(user_challenge_is_claimed).Append("\n");
            sb.Append("  user_challenge_status: ").Append(user_challenge_status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Challenge);
        }

        /// <summary>
        /// Returns true if Challenge instances are equal
        /// </summary>
        /// <param name="input">Instance of Challenge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Challenge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.challenge_id == input.challenge_id ||
                    (this.challenge_id != null &&
                    this.challenge_id.Equals(input.challenge_id))
                ) && 
                (
                    this.challenge_name == input.challenge_name ||
                    (this.challenge_name != null &&
                    this.challenge_name.Equals(input.challenge_name))
                ) && 
                (
                    this.challenge_description == input.challenge_description ||
                    (this.challenge_description != null &&
                    this.challenge_description.Equals(input.challenge_description))
                ) && 
                (
                    this.challenge_duration_time == input.challenge_duration_time ||
                    (this.challenge_duration_time != null &&
                    this.challenge_duration_time.Equals(input.challenge_duration_time))
                ) && 
                (
                    this.live_date == input.live_date ||
                    (this.live_date != null &&
                    this.live_date.Equals(input.live_date))
                ) && 
                (
                    this.challenge_goal == input.challenge_goal ||
                    (this.challenge_goal != null &&
                    this.challenge_goal.Equals(input.challenge_goal))
                ) && 
                (
                    this.user_challenge_current_score == input.user_challenge_current_score ||
                    (this.user_challenge_current_score != null &&
                    this.user_challenge_current_score.Equals(input.user_challenge_current_score))
                ) && 
                (
                    this.challenge_icon == input.challenge_icon ||
                    (this.challenge_icon != null &&
                    this.challenge_icon.Equals(input.challenge_icon))
                ) && 
                (
                    this.challenge_icon_hd == input.challenge_icon_hd ||
                    (this.challenge_icon_hd != null &&
                    this.challenge_icon_hd.Equals(input.challenge_icon_hd))
                ) && 
                (
                    this.challenge_price == input.challenge_price ||
                    (this.challenge_price != null &&
                    this.challenge_price.Equals(input.challenge_price))
                ) && 
                (
                    this.challenge_reward == input.challenge_reward ||
                    (this.challenge_reward != null &&
                    this.challenge_reward.Equals(input.challenge_reward))
                ) && 
                (
                    this.challenge_reward_type == input.challenge_reward_type ||
                    (this.challenge_reward_type != null &&
                    this.challenge_reward_type.Equals(input.challenge_reward_type))
                ) && 
                (
                    this.challenge_goal_condition == input.challenge_goal_condition ||
                    (this.challenge_goal_condition != null &&
                    this.challenge_goal_condition.Equals(input.challenge_goal_condition))
                ) && 
                (
                    this.challenge_xp == input.challenge_xp ||
                    (this.challenge_xp != null &&
                    this.challenge_xp.Equals(input.challenge_xp))
                ) && 
                (
                    this.repeatable == input.repeatable ||
                    (this.repeatable != null &&
                    this.repeatable.Equals(input.repeatable))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.challenge_auto_activated == input.challenge_auto_activated ||
                    (this.challenge_auto_activated != null &&
                    this.challenge_auto_activated.Equals(input.challenge_auto_activated))
                ) && 
                (
                    this.is_claimed == input.is_claimed ||
                    (this.is_claimed != null &&
                    this.is_claimed.Equals(input.is_claimed))
                ) && 
                (
                    this.user_challenge_unlocked_at == input.user_challenge_unlocked_at ||
                    (this.user_challenge_unlocked_at != null &&
                    this.user_challenge_unlocked_at.Equals(input.user_challenge_unlocked_at))
                ) && 
                (
                    this.user_challenge_activated_at == input.user_challenge_activated_at ||
                    (this.user_challenge_activated_at != null &&
                    this.user_challenge_activated_at.Equals(input.user_challenge_activated_at))
                ) && 
                (
                    this.user_challenge_is_claimed == input.user_challenge_is_claimed ||
                    (this.user_challenge_is_claimed != null &&
                    this.user_challenge_is_claimed.Equals(input.user_challenge_is_claimed))
                ) && 
                (
                    this.user_challenge_status == input.user_challenge_status ||
                    (this.user_challenge_status != null &&
                    this.user_challenge_status.Equals(input.user_challenge_status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.challenge_id != null)
                    hashCode = hashCode * 59 + this.challenge_id.GetHashCode();
                if (this.challenge_name != null)
                    hashCode = hashCode * 59 + this.challenge_name.GetHashCode();
                if (this.challenge_description != null)
                    hashCode = hashCode * 59 + this.challenge_description.GetHashCode();
                if (this.challenge_duration_time != null)
                    hashCode = hashCode * 59 + this.challenge_duration_time.GetHashCode();
                if (this.live_date != null)
                    hashCode = hashCode * 59 + this.live_date.GetHashCode();
                if (this.challenge_goal != null)
                    hashCode = hashCode * 59 + this.challenge_goal.GetHashCode();
                if (this.user_challenge_current_score != null)
                    hashCode = hashCode * 59 + this.user_challenge_current_score.GetHashCode();
                if (this.challenge_icon != null)
                    hashCode = hashCode * 59 + this.challenge_icon.GetHashCode();
                if (this.challenge_icon_hd != null)
                    hashCode = hashCode * 59 + this.challenge_icon_hd.GetHashCode();
                if (this.challenge_price != null)
                    hashCode = hashCode * 59 + this.challenge_price.GetHashCode();
                if (this.challenge_reward != null)
                    hashCode = hashCode * 59 + this.challenge_reward.GetHashCode();
                if (this.challenge_reward_type != null)
                    hashCode = hashCode * 59 + this.challenge_reward_type.GetHashCode();
                if (this.challenge_goal_condition != null)
                    hashCode = hashCode * 59 + this.challenge_goal_condition.GetHashCode();
                if (this.challenge_xp != null)
                    hashCode = hashCode * 59 + this.challenge_xp.GetHashCode();
                if (this.repeatable != null)
                    hashCode = hashCode * 59 + this.repeatable.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.challenge_auto_activated != null)
                    hashCode = hashCode * 59 + this.challenge_auto_activated.GetHashCode();
                if (this.is_claimed != null)
                    hashCode = hashCode * 59 + this.is_claimed.GetHashCode();
                if (this.user_challenge_unlocked_at != null)
                    hashCode = hashCode * 59 + this.user_challenge_unlocked_at.GetHashCode();
                if (this.user_challenge_activated_at != null)
                    hashCode = hashCode * 59 + this.user_challenge_activated_at.GetHashCode();
                if (this.user_challenge_is_claimed != null)
                    hashCode = hashCode * 59 + this.user_challenge_is_claimed.GetHashCode();
                if (this.user_challenge_status != null)
                    hashCode = hashCode * 59 + this.user_challenge_status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
