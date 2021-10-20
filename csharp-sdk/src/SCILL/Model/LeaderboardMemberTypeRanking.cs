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
    /// You get this object if you query the leaderboard ranking for a specific user. Only the requested user will be returned.
    /// </summary>
    [DataContract]
        public partial class LeaderboardMemberTypeRanking :  IEquatable<LeaderboardMemberTypeRanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardMemberTypeRanking" /> class.
        /// </summary>
        /// <param name="count">The total number of members included in the results.</param>
        /// <param name="members">An array of LeaderboardMember objects.</param>
        public LeaderboardMemberTypeRanking(int? count = default(int?), List<LeaderboardMember> members = default(List<LeaderboardMember>))
        {
            this.count = count;
            this.members = members;
        }
        
        /// <summary>
        /// The total number of members included in the results
        /// </summary>
        /// <value>The total number of members included in the results</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? count { get; set; }

        /// <summary>
        /// An array of LeaderboardMember objects
        /// </summary>
        /// <value>An array of LeaderboardMember objects</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<LeaderboardMember> members { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaderboardMemberTypeRanking {\n");
            sb.Append("  count: ").Append(count).Append("\n");
            sb.Append("  members: ").Append(members).Append("\n");
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
            return this.Equals(input as LeaderboardMemberTypeRanking);
        }

        /// <summary>
        /// Returns true if LeaderboardMemberTypeRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaderboardMemberTypeRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaderboardMemberTypeRanking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.count == input.count ||
                    (this.count != null &&
                    this.count.Equals(input.count))
                ) && 
                (
                    this.members == input.members ||
                    this.members != null &&
                    input.members != null &&
                    this.members.SequenceEqual(input.members)
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
                if (this.count != null)
                    hashCode = hashCode * 59 + this.count.GetHashCode();
                if (this.members != null)
                    hashCode = hashCode * 59 + this.members.GetHashCode();
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
