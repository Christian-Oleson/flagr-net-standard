/* 
 * Flagr
 *
 * Flagr is a feature flagging, A/B testing and dynamic configuration microservice. The base path for all the APIs is \"/api/v1\". 
 *
 * OpenAPI spec version: 1.1.12
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Flagr.Api.Client.SwaggerDateConverter;

namespace Flagr.Api.Model
{
    /// <summary>
    /// PutFlagRequest
    /// </summary>
    [DataContract]
    public partial class PutFlagRequest :  IEquatable<PutFlagRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFlagRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="dataRecordsEnabled">enabled data records will get data logging in the metrics pipeline, for example, kafka..</param>
        /// <param name="entityType">it will overwrite entityType into evaluation logs if it&#39;s not empty.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="key">key.</param>
        /// <param name="notes">notes.</param>
        public PutFlagRequest(string description = default(string), bool? dataRecordsEnabled = default(bool?), string entityType = default(string), bool? enabled = default(bool?), string key = default(string), string notes = default(string))
        {
            this.Description = description;
            this.DataRecordsEnabled = dataRecordsEnabled;
            this.EntityType = entityType;
            this.Enabled = enabled;
            this.Key = key;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// enabled data records will get data logging in the metrics pipeline, for example, kafka.
        /// </summary>
        /// <value>enabled data records will get data logging in the metrics pipeline, for example, kafka.</value>
        [DataMember(Name="dataRecordsEnabled", EmitDefaultValue=false)]
        public bool? DataRecordsEnabled { get; set; }

        /// <summary>
        /// it will overwrite entityType into evaluation logs if it&#39;s not empty
        /// </summary>
        /// <value>it will overwrite entityType into evaluation logs if it&#39;s not empty</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutFlagRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataRecordsEnabled: ").Append(DataRecordsEnabled).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as PutFlagRequest);
        }

        /// <summary>
        /// Returns true if PutFlagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PutFlagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutFlagRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DataRecordsEnabled == input.DataRecordsEnabled ||
                    (this.DataRecordsEnabled != null &&
                    this.DataRecordsEnabled.Equals(input.DataRecordsEnabled))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DataRecordsEnabled != null)
                    hashCode = hashCode * 59 + this.DataRecordsEnabled.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                return hashCode;
            }
        }
    }

}
