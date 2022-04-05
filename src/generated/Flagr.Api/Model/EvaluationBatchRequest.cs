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
    /// EvaluationBatchRequest
    /// </summary>
    [ExcludeFromCodeCoverage]
    [DataContract]
    public partial class EvaluationBatchRequest :  IEquatable<EvaluationBatchRequest>
    {
        /// <summary>
        /// determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.
        /// </summary>
        /// <value>determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagTagsOperatorEnum
        {
            
            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            [EnumMember(Value = "ANY")]
            ANY = 1,
            
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 2
        }

        /// <summary>
        /// determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.
        /// </summary>
        /// <value>determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags.</value>
        [DataMember(Name="flagTagsOperator", EmitDefaultValue=false)]
        public FlagTagsOperatorEnum? FlagTagsOperator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationBatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationBatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationBatchRequest" /> class.
        /// </summary>
        /// <param name="entities">entities (required).</param>
        /// <param name="enableDebug">enableDebug.</param>
        /// <param name="flagIDs">flagIDs.</param>
        /// <param name="flagKeys">flagKeys. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results..</param>
        /// <param name="flagTags">flagTags. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results..</param>
        /// <param name="flagTagsOperator">determine how flagTags is used to filter flags to be evaluated. OR extends the evaluation to those which contains at least one of the provided flagTags or AND limit the evaluation to those which contains all the flagTags. (default to FlagTagsOperatorEnum.ANY).</param>
        public EvaluationBatchRequest(List<EvaluationEntity> entities = default(List<EvaluationEntity>), bool? enableDebug = default(bool?), List<long?> flagIDs = default(List<long?>), List<string> flagKeys = default(List<string>), List<string> flagTags = default(List<string>), FlagTagsOperatorEnum? flagTagsOperator = FlagTagsOperatorEnum.ANY)
        {
            // to ensure "entities" is required (not null)
            if (entities == null)
            {
                throw new InvalidDataException("entities is a required property for EvaluationBatchRequest and cannot be null");
            }
            else
            {
                this.Entities = entities;
            }
            this.EnableDebug = enableDebug;
            this.FlagIDs = flagIDs;
            this.FlagKeys = flagKeys;
            this.FlagTags = flagTags;
            // use default value if no "flagTagsOperator" provided
            if (flagTagsOperator == null)
            {
                this.FlagTagsOperator = FlagTagsOperatorEnum.ANY;
            }
            else
            {
                this.FlagTagsOperator = flagTagsOperator;
            }
        }
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<EvaluationEntity> Entities { get; set; }

        /// <summary>
        /// Gets or Sets EnableDebug
        /// </summary>
        [DataMember(Name="enableDebug", EmitDefaultValue=false)]
        public bool? EnableDebug { get; set; }

        /// <summary>
        /// flagIDs
        /// </summary>
        /// <value>flagIDs</value>
        [DataMember(Name="flagIDs", EmitDefaultValue=false)]
        public List<long?> FlagIDs { get; set; }

        /// <summary>
        /// flagKeys. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.
        /// </summary>
        /// <value>flagKeys. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.</value>
        [DataMember(Name="flagKeys", EmitDefaultValue=false)]
        public List<string> FlagKeys { get; set; }

        /// <summary>
        /// flagTags. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.
        /// </summary>
        /// <value>flagTags. Either flagIDs, flagKeys or flagTags works. If pass in multiples, Flagr may return duplicate results.</value>
        [DataMember(Name="flagTags", EmitDefaultValue=false)]
        public List<string> FlagTags { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationBatchRequest {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  EnableDebug: ").Append(EnableDebug).Append("\n");
            sb.Append("  FlagIDs: ").Append(FlagIDs).Append("\n");
            sb.Append("  FlagKeys: ").Append(FlagKeys).Append("\n");
            sb.Append("  FlagTags: ").Append(FlagTags).Append("\n");
            sb.Append("  FlagTagsOperator: ").Append(FlagTagsOperator).Append("\n");
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
            return this.Equals(input as EvaluationBatchRequest);
        }

        /// <summary>
        /// Returns true if EvaluationBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationBatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.EnableDebug == input.EnableDebug ||
                    (this.EnableDebug != null &&
                    this.EnableDebug.Equals(input.EnableDebug))
                ) && 
                (
                    this.FlagIDs == input.FlagIDs ||
                    this.FlagIDs != null &&
                    this.FlagIDs.SequenceEqual(input.FlagIDs)
                ) && 
                (
                    this.FlagKeys == input.FlagKeys ||
                    this.FlagKeys != null &&
                    this.FlagKeys.SequenceEqual(input.FlagKeys)
                ) && 
                (
                    this.FlagTags == input.FlagTags ||
                    this.FlagTags != null &&
                    this.FlagTags.SequenceEqual(input.FlagTags)
                ) && 
                (
                    this.FlagTagsOperator == input.FlagTagsOperator ||
                    (this.FlagTagsOperator != null &&
                    this.FlagTagsOperator.Equals(input.FlagTagsOperator))
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
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.EnableDebug != null)
                    hashCode = hashCode * 59 + this.EnableDebug.GetHashCode();
                if (this.FlagIDs != null)
                    hashCode = hashCode * 59 + this.FlagIDs.GetHashCode();
                if (this.FlagKeys != null)
                    hashCode = hashCode * 59 + this.FlagKeys.GetHashCode();
                if (this.FlagTags != null)
                    hashCode = hashCode * 59 + this.FlagTags.GetHashCode();
                if (this.FlagTagsOperator != null)
                    hashCode = hashCode * 59 + this.FlagTagsOperator.GetHashCode();
                return hashCode;
            }
        }
    }

}
