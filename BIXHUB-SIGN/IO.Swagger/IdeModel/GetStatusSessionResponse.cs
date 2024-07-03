/* 
 * OnBoarding
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.IdeModel
{
    /// <summary>
    /// GetStatusSessionResponse
    /// </summary>
    [DataContract]
        public partial class GetStatusSessionResponse :  IEquatable<GetStatusSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionGuid">sessionGuid.</param>
        /// <param name="flowType">flowType.</param>
        /// <param name="identificationStatus">identificationStatus.</param>
        /// <param name="riskScore">riskScore.</param>
        /// <param name="riskScoreEvaluation">riskScoreEvaluation.</param>
        /// <param name="flow">flow.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="completedDate">completedDate.</param>
        /// <param name="verifyDate">verifyDate.</param>
        /// <param name="sessionStatus">sessionStatus.</param>
        public GetStatusSessionResponse(Guid? sessionGuid = default(Guid?), SessionFlowTypeDto flowType = default(SessionFlowTypeDto), IdentificationStatus identificationStatus = default(IdentificationStatus), float? riskScore = default(float?), string riskScoreEvaluation = default(string), List<FlowStep> flow = default(List<FlowStep>), DateTime? createdDate = default(DateTime?), DateTime? completedDate = default(DateTime?), DateTime? verifyDate = default(DateTime?), SessionStatus sessionStatus = default(SessionStatus))
        {
            this.SessionGuid = sessionGuid;
            this.FlowType = flowType;
            this.IdentificationStatus = identificationStatus;
            this.RiskScore = riskScore;
            this.RiskScoreEvaluation = riskScoreEvaluation;
            this.Flow = flow;
            this.CreatedDate = createdDate;
            this.CompletedDate = completedDate;
            this.VerifyDate = verifyDate;
            this.SessionStatus = sessionStatus;
        }
        
        /// <summary>
        /// Gets or Sets SessionGuid
        /// </summary>
        [DataMember(Name="sessionGuid", EmitDefaultValue=false)]
        public Guid? SessionGuid { get; set; }

        /// <summary>
        /// Gets or Sets FlowType
        /// </summary>
        [DataMember(Name="flowType", EmitDefaultValue=false)]
        public SessionFlowTypeDto FlowType { get; set; }

        /// <summary>
        /// Gets or Sets IdentificationStatus
        /// </summary>
        [DataMember(Name="identificationStatus", EmitDefaultValue=false)]
        public IdentificationStatus IdentificationStatus { get; set; }

        /// <summary>
        /// Gets or Sets RiskScore
        /// </summary>
        [DataMember(Name="riskScore", EmitDefaultValue=false)]
        public float? RiskScore { get; set; }

        /// <summary>
        /// Gets or Sets RiskScoreEvaluation
        /// </summary>
        [DataMember(Name="riskScoreEvaluation", EmitDefaultValue=false)]
        public string RiskScoreEvaluation { get; set; }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public List<FlowStep> Flow { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name="completedDate", EmitDefaultValue=false)]
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or Sets VerifyDate
        /// </summary>
        [DataMember(Name="verifyDate", EmitDefaultValue=false)]
        public DateTime? VerifyDate { get; set; }

        /// <summary>
        /// Gets or Sets SessionStatus
        /// </summary>
        [DataMember(Name="sessionStatus", EmitDefaultValue=false)]
        public SessionStatus SessionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStatusSessionResponse {\n");
            sb.Append("  SessionGuid: ").Append(SessionGuid).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  IdentificationStatus: ").Append(IdentificationStatus).Append("\n");
            sb.Append("  RiskScore: ").Append(RiskScore).Append("\n");
            sb.Append("  RiskScoreEvaluation: ").Append(RiskScoreEvaluation).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  VerifyDate: ").Append(VerifyDate).Append("\n");
            sb.Append("  SessionStatus: ").Append(SessionStatus).Append("\n");
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
            return this.Equals(input as GetStatusSessionResponse);
        }

        /// <summary>
        /// Returns true if GetStatusSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatusSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatusSessionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionGuid == input.SessionGuid ||
                    (this.SessionGuid != null &&
                    this.SessionGuid.Equals(input.SessionGuid))
                ) && 
                (
                    this.FlowType == input.FlowType ||
                    (this.FlowType != null &&
                    this.FlowType.Equals(input.FlowType))
                ) && 
                (
                    this.IdentificationStatus == input.IdentificationStatus ||
                    (this.IdentificationStatus != null &&
                    this.IdentificationStatus.Equals(input.IdentificationStatus))
                ) && 
                (
                    this.RiskScore == input.RiskScore ||
                    (this.RiskScore != null &&
                    this.RiskScore.Equals(input.RiskScore))
                ) && 
                (
                    this.RiskScoreEvaluation == input.RiskScoreEvaluation ||
                    (this.RiskScoreEvaluation != null &&
                    this.RiskScoreEvaluation.Equals(input.RiskScoreEvaluation))
                ) && 
                (
                    this.Flow == input.Flow ||
                    this.Flow != null &&
                    input.Flow != null &&
                    this.Flow.SequenceEqual(input.Flow)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CompletedDate == input.CompletedDate ||
                    (this.CompletedDate != null &&
                    this.CompletedDate.Equals(input.CompletedDate))
                ) && 
                (
                    this.VerifyDate == input.VerifyDate ||
                    (this.VerifyDate != null &&
                    this.VerifyDate.Equals(input.VerifyDate))
                ) && 
                (
                    this.SessionStatus == input.SessionStatus ||
                    (this.SessionStatus != null &&
                    this.SessionStatus.Equals(input.SessionStatus))
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
                if (this.SessionGuid != null)
                    hashCode = hashCode * 59 + this.SessionGuid.GetHashCode();
                if (this.FlowType != null)
                    hashCode = hashCode * 59 + this.FlowType.GetHashCode();
                if (this.IdentificationStatus != null)
                    hashCode = hashCode * 59 + this.IdentificationStatus.GetHashCode();
                if (this.RiskScore != null)
                    hashCode = hashCode * 59 + this.RiskScore.GetHashCode();
                if (this.RiskScoreEvaluation != null)
                    hashCode = hashCode * 59 + this.RiskScoreEvaluation.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.CompletedDate != null)
                    hashCode = hashCode * 59 + this.CompletedDate.GetHashCode();
                if (this.VerifyDate != null)
                    hashCode = hashCode * 59 + this.VerifyDate.GetHashCode();
                if (this.SessionStatus != null)
                    hashCode = hashCode * 59 + this.SessionStatus.GetHashCode();
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
