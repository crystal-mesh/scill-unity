/* 
 * SCILL API
 *
 * SCILL gives you the tools to activate, retain and grow your user base in your app or game by bringing you features well known in the gaming industry: Gamification. We take care of the services and technology involved so you can focus on your game and content.
 *
 * OpenAPI spec version: 1.0.0
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
    /// The Leaderboard object contains information about the leaderboard itself like the name and the id, but also contains actual rankings for users and teams.
    /// </summary>
    [DataContract]
        public partial class Leaderboard :  IEquatable<Leaderboard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaderboard" /> class.
        /// </summary>
        /// <param name="leaderboardId">The id of the leaderboard.</param>
        /// <param name="name">The name of the leaderboard.</param>
        /// <param name="groupedByUsers">An array of LeaderboardRanking Items for individual users.</param>
        /// <param name="groupedByTeams">An array of LeaderboardRanking Items for teams. Provide a team_id in the event payload to also create leaderboards for teams.</param>
        /// <param name="numTeams">The total number of team rankings available in the leaderboard.</param>
        /// <param name="numUsers">The total number of user rankings available in the leaderboard.</param>
        public Leaderboard(string leaderboardId = default(string), string name = default(string), List<LeaderboardRanking> groupedByUsers = default(List<LeaderboardRanking>), List<LeaderboardRanking> groupedByTeams = default(List<LeaderboardRanking>), decimal? numTeams = default(decimal?), decimal? numUsers = default(decimal?))
        {
            this.leaderboard_id = leaderboardId;
            this.name = name;
            this.grouped_by_users = groupedByUsers;
            this.grouped_by_teams = groupedByTeams;
            this.num_teams = numTeams;
            this.num_users = numUsers;
        }
        
        /// <summary>
        /// The id of the leaderboard
        /// </summary>
        /// <value>The id of the leaderboard</value>
        [DataMember(Name="leaderboard_id", EmitDefaultValue=false)]
        public string leaderboard_id { get; set; }

        /// <summary>
        /// The name of the leaderboard
        /// </summary>
        /// <value>The name of the leaderboard</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// An array of LeaderboardRanking Items for individual users
        /// </summary>
        /// <value>An array of LeaderboardRanking Items for individual users</value>
        [DataMember(Name="grouped_by_users", EmitDefaultValue=false)]
        public List<LeaderboardRanking> grouped_by_users { get; set; }

        /// <summary>
        /// An array of LeaderboardRanking Items for teams. Provide a team_id in the event payload to also create leaderboards for teams
        /// </summary>
        /// <value>An array of LeaderboardRanking Items for teams. Provide a team_id in the event payload to also create leaderboards for teams</value>
        [DataMember(Name="grouped_by_teams", EmitDefaultValue=false)]
        public List<LeaderboardRanking> grouped_by_teams { get; set; }

        /// <summary>
        /// The total number of team rankings available in the leaderboard
        /// </summary>
        /// <value>The total number of team rankings available in the leaderboard</value>
        [DataMember(Name="num_teams", EmitDefaultValue=false)]
        public decimal? num_teams { get; set; }

        /// <summary>
        /// The total number of user rankings available in the leaderboard
        /// </summary>
        /// <value>The total number of user rankings available in the leaderboard</value>
        [DataMember(Name="num_users", EmitDefaultValue=false)]
        public decimal? num_users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Leaderboard {\n");
            sb.Append("  leaderboard_id: ").Append(leaderboard_id).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  grouped_by_users: ").Append(grouped_by_users).Append("\n");
            sb.Append("  grouped_by_teams: ").Append(grouped_by_teams).Append("\n");
            sb.Append("  num_teams: ").Append(num_teams).Append("\n");
            sb.Append("  num_users: ").Append(num_users).Append("\n");
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
            return this.Equals(input as Leaderboard);
        }

        /// <summary>
        /// Returns true if Leaderboard instances are equal
        /// </summary>
        /// <param name="input">Instance of Leaderboard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Leaderboard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.leaderboard_id == input.leaderboard_id ||
                    (this.leaderboard_id != null &&
                    this.leaderboard_id.Equals(input.leaderboard_id))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.grouped_by_users == input.grouped_by_users ||
                    this.grouped_by_users != null &&
                    input.grouped_by_users != null &&
                    this.grouped_by_users.SequenceEqual(input.grouped_by_users)
                ) && 
                (
                    this.grouped_by_teams == input.grouped_by_teams ||
                    this.grouped_by_teams != null &&
                    input.grouped_by_teams != null &&
                    this.grouped_by_teams.SequenceEqual(input.grouped_by_teams)
                ) && 
                (
                    this.num_teams == input.num_teams ||
                    (this.num_teams != null &&
                    this.num_teams.Equals(input.num_teams))
                ) && 
                (
                    this.num_users == input.num_users ||
                    (this.num_users != null &&
                    this.num_users.Equals(input.num_users))
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
                if (this.leaderboard_id != null)
                    hashCode = hashCode * 59 + this.leaderboard_id.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.grouped_by_users != null)
                    hashCode = hashCode * 59 + this.grouped_by_users.GetHashCode();
                if (this.grouped_by_teams != null)
                    hashCode = hashCode * 59 + this.grouped_by_teams.GetHashCode();
                if (this.num_teams != null)
                    hashCode = hashCode * 59 + this.num_teams.GetHashCode();
                if (this.num_users != null)
                    hashCode = hashCode * 59 + this.num_users.GetHashCode();
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
