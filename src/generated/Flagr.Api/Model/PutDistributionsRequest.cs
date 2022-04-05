/* 
 * Flagr
 * Flagr is a feature flagging, A/B testing and dynamic configuration microservice. The base path for all the APIs is \"/api/v1\". 
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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Flagr.Api.Client.SwaggerDateConverter;

namespace Flagr.Api.Model
{
    /// <summary>
    /// PutDistributionsRequest
    /// </summary>
    [ExcludeFromCodeCoverage]
    [DataContract]
    public partial class PutDistributionsRequest :  IEquatable<PutDistributionsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDistributionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PutDistributionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDistributionsRequest" /> class.
        /// </summary>
        /// <param name="distributions">distributions (required).</param>
        public PutDistributionsRequest(List<Distribution> distributions = default(List<Distribution>))
        {
            // to ensure "distributions" is required (not null)
            if (distributions == null)
            {
                throw new InvalidDataException("distributions is a required property for PutDistributionsRequest and cannot be null");
            }
            else
            {
                this.Distributions = distributions;
            }
        }
        
        /// <summary>
        /// Gets or Sets Distributions
        /// </summary>
        [DataMember(Name="distributions", EmitDefaultValue=false)]
        public List<Distribution> Distributions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutDistributionsRequest {\n");
            sb.Append("  Distributions: ").Append(Distributions).Append("\n");
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
            return this.Equals(input as PutDistributionsRequest);
        }

        /// <summary>
        /// Returns true if PutDistributionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PutDistributionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutDistributionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Distributions == input.Distributions ||
                    this.Distributions != null &&
                    this.Distributions.SequenceEqual(input.Distributions)
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
                if (this.Distributions != null)
                    hashCode = hashCode * 59 + this.Distributions.GetHashCode();
                return hashCode;
            }
        }
    }

}