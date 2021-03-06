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
    /// CreateFlagRequest
    /// </summary>
    [DataContract]
    public partial class CreateFlagRequest :  IEquatable<CreateFlagRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFlagRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequest" /> class.
        /// </summary>
        /// <param name="description">description (required).</param>
        /// <param name="key">unique key representation of the flag.</param>
        /// <param name="template">template for flag creation.</param>
        public CreateFlagRequest(string description = default(string), string key = default(string), string template = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for CreateFlagRequest and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.Key = key;
            this.Template = template;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// unique key representation of the flag
        /// </summary>
        /// <value>unique key representation of the flag</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// template for flag creation
        /// </summary>
        /// <value>template for flag creation</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFlagRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as CreateFlagRequest);
        }

        /// <summary>
        /// Returns true if CreateFlagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFlagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFlagRequest input)
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
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                return hashCode;
            }
        }
    }

}
