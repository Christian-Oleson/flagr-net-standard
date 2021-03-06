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
    /// Flag
    /// </summary>
    [DataContract]
    public partial class Flag :  IEquatable<Flag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Flag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Flag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Flag" /> class.
        /// </summary>
        /// <param name="key">unique key representation of the flag.</param>
        /// <param name="description">description (required).</param>
        /// <param name="enabled">enabled (required).</param>
        /// <param name="tags">tags.</param>
        /// <param name="segments">segments.</param>
        /// <param name="variants">variants.</param>
        /// <param name="dataRecordsEnabled">enabled data records will get data logging in the metrics pipeline, for example, kafka. (required).</param>
        /// <param name="entityType">it will override the entityType in the evaluation logs if it&#39;s not empty.</param>
        /// <param name="notes">flag usage details in markdown format.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Flag(string key = default(string), string description = default(string), bool? enabled = default(bool?), List<Tag> tags = default(List<Tag>), List<Segment> segments = default(List<Segment>), List<Variant> variants = default(List<Variant>), bool? dataRecordsEnabled = default(bool?), string entityType = default(string), string notes = default(string), string createdBy = default(string), string updatedBy = default(string), DateTime? updatedAt = default(DateTime?))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Flag and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for Flag and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "dataRecordsEnabled" is required (not null)
            if (dataRecordsEnabled == null)
            {
                throw new InvalidDataException("dataRecordsEnabled is a required property for Flag and cannot be null");
            }
            else
            {
                this.DataRecordsEnabled = dataRecordsEnabled;
            }
            this.Key = key;
            this.Tags = tags;
            this.Segments = segments;
            this.Variants = variants;
            this.EntityType = entityType;
            this.Notes = notes;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// unique key representation of the flag
        /// </summary>
        /// <value>unique key representation of the flag</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<Segment> Segments { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name="variants", EmitDefaultValue=false)]
        public List<Variant> Variants { get; set; }

        /// <summary>
        /// enabled data records will get data logging in the metrics pipeline, for example, kafka.
        /// </summary>
        /// <value>enabled data records will get data logging in the metrics pipeline, for example, kafka.</value>
        [DataMember(Name="dataRecordsEnabled", EmitDefaultValue=false)]
        public bool? DataRecordsEnabled { get; set; }

        /// <summary>
        /// it will override the entityType in the evaluation logs if it&#39;s not empty
        /// </summary>
        /// <value>it will override the entityType in the evaluation logs if it&#39;s not empty</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// flag usage details in markdown format
        /// </summary>
        /// <value>flag usage details in markdown format</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="updatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("  DataRecordsEnabled: ").Append(DataRecordsEnabled).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as Flag);
        }

        /// <summary>
        /// Returns true if Flag instances are equal
        /// </summary>
        /// <param name="input">Instance of Flag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flag input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
                ) && 
                (
                    this.Variants == input.Variants ||
                    this.Variants != null &&
                    this.Variants.SequenceEqual(input.Variants)
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
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.Variants != null)
                    hashCode = hashCode * 59 + this.Variants.GetHashCode();
                if (this.DataRecordsEnabled != null)
                    hashCode = hashCode * 59 + this.DataRecordsEnabled.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
