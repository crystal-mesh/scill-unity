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
    /// The payload used for realtime updates and webhooks if a leaderboard is updated.
    /// </summary>
    [DataContract]
        public partial class LeaderboardUpdatePayload :  IEquatable<LeaderboardUpdatePayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardUpdatePayload" /> class.
        /// </summary>
        /// <param name="webhookType">The type of the webhook, in this case it is leaderboard-ranking-changed.</param>
        /// <param name="leaderboardData">leaderboardData.</param>
        /// <param name="memberData">memberData.</param>
        /// <param name="oldLeaderboardRanking">oldLeaderboardRanking.</param>
        /// <param name="newLeaderboardRanking">newLeaderboardRanking.</param>
        public LeaderboardUpdatePayload(string webhookType = default(string), LeaderboardInfo leaderboardData = default(LeaderboardInfo), LeaderboardMember memberData = default(LeaderboardMember), LeaderboardScore oldLeaderboardRanking = default(LeaderboardScore), LeaderboardScore newLeaderboardRanking = default(LeaderboardScore))
        {
            this.webhook_type = webhookType;
            this.leaderboard_data = leaderboardData;
            this.member_data = memberData;
            this.old_leaderboard_ranking = oldLeaderboardRanking;
            this.new_leaderboard_ranking = newLeaderboardRanking;
        }
        
        /// <summary>
        /// The type of the webhook, in this case it is leaderboard-ranking-changed
        /// </summary>
        /// <value>The type of the webhook, in this case it is leaderboard-ranking-changed</value>
        [DataMember(Name="webhook_type", EmitDefaultValue=false)]
        public string webhook_type { get; set; }

        /// <summary>
        /// Gets or Sets leaderboard_data
        /// </summary>
        [DataMember(Name="leaderboard_data", EmitDefaultValue=false)]
        public LeaderboardInfo leaderboard_data { get; set; }

        /// <summary>
        /// Gets or Sets member_data
        /// </summary>
        [DataMember(Name="member_data", EmitDefaultValue=false)]
        public LeaderboardMember member_data { get; set; }

        /// <summary>
        /// Gets or Sets old_leaderboard_ranking
        /// </summary>
        [DataMember(Name="old_leaderboard_ranking", EmitDefaultValue=false)]
        public LeaderboardScore old_leaderboard_ranking { get; set; }

        /// <summary>
        /// Gets or Sets new_leaderboard_ranking
        /// </summary>
        [DataMember(Name="new_leaderboard_ranking", EmitDefaultValue=false)]
        public LeaderboardScore new_leaderboard_ranking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaderboardUpdatePayload {\n");
            sb.Append("  webhook_type: ").Append(webhook_type).Append("\n");
            sb.Append("  leaderboard_data: ").Append(leaderboard_data).Append("\n");
            sb.Append("  member_data: ").Append(member_data).Append("\n");
            sb.Append("  old_leaderboard_ranking: ").Append(old_leaderboard_ranking).Append("\n");
            sb.Append("  new_leaderboard_ranking: ").Append(new_leaderboard_ranking).Append("\n");
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
            return this.Equals(input as LeaderboardUpdatePayload);
        }

        /// <summary>
        /// Returns true if LeaderboardUpdatePayload instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaderboardUpdatePayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaderboardUpdatePayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.webhook_type == input.webhook_type ||
                    (this.webhook_type != null &&
                    this.webhook_type.Equals(input.webhook_type))
                ) && 
                (
                    this.leaderboard_data == input.leaderboard_data ||
                    (this.leaderboard_data != null &&
                    this.leaderboard_data.Equals(input.leaderboard_data))
                ) && 
                (
                    this.member_data == input.member_data ||
                    (this.member_data != null &&
                    this.member_data.Equals(input.member_data))
                ) && 
                (
                    this.old_leaderboard_ranking == input.old_leaderboard_ranking ||
                    (this.old_leaderboard_ranking != null &&
                    this.old_leaderboard_ranking.Equals(input.old_leaderboard_ranking))
                ) && 
                (
                    this.new_leaderboard_ranking == input.new_leaderboard_ranking ||
                    (this.new_leaderboard_ranking != null &&
                    this.new_leaderboard_ranking.Equals(input.new_leaderboard_ranking))
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
                if (this.webhook_type != null)
                    hashCode = hashCode * 59 + this.webhook_type.GetHashCode();
                if (this.leaderboard_data != null)
                    hashCode = hashCode * 59 + this.leaderboard_data.GetHashCode();
                if (this.member_data != null)
                    hashCode = hashCode * 59 + this.member_data.GetHashCode();
                if (this.old_leaderboard_ranking != null)
                    hashCode = hashCode * 59 + this.old_leaderboard_ranking.GetHashCode();
                if (this.new_leaderboard_ranking != null)
                    hashCode = hashCode * 59 + this.new_leaderboard_ranking.GetHashCode();
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
