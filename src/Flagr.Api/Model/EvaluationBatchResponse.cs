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
    /// EvaluationBatchResponse
    /// </summary>
    [DataContract]
    public partial class EvaluationBatchResponse :  IEquatable<EvaluationBatchResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationBatchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationBatchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationBatchResponse" /> class.
        /// </summary>
        /// <param name="evaluationResults">evaluationResults (required).</param>
        public EvaluationBatchResponse(List<EvalResult> evaluationResults = default(List<EvalResult>))
        {
            // to ensure "evaluationResults" is required (not null)
            if (evaluationResults == null)
            {
                throw new InvalidDataException("evaluationResults is a required property for EvaluationBatchResponse and cannot be null");
            }
            else
            {
                this.EvaluationResults = evaluationResults;
            }
        }
        
        /// <summary>
        /// Gets or Sets EvaluationResults
        /// </summary>
        [DataMember(Name="evaluationResults", EmitDefaultValue=false)]
        public List<EvalResult> EvaluationResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationBatchResponse {\n");
            sb.Append("  EvaluationResults: ").Append(EvaluationResults).Append("\n");
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
            return this.Equals(input as EvaluationBatchResponse);
        }

        /// <summary>
        /// Returns true if EvaluationBatchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationBatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationBatchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EvaluationResults == input.EvaluationResults ||
                    this.EvaluationResults != null &&
                    this.EvaluationResults.SequenceEqual(input.EvaluationResults)
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
                if (this.EvaluationResults != null)
                    hashCode = hashCode * 59 + this.EvaluationResults.GetHashCode();
                return hashCode;
            }
        }
    }

}
