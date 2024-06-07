/* 
 * Sign
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
namespace IO.Swagger.Model
{
    /// <summary>
    /// PublishSessionResponse
    /// </summary>
    [DataContract]
        public partial class PublishSessionResponse :  IEquatable<PublishSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishSessionResponse" /> class.
        /// </summary>
        /// <param name="approvers">approvers.</param>
        /// <param name="signers">signers.</param>
        public PublishSessionResponse(List<PublishSessionApproversResponse> approvers = default(List<PublishSessionApproversResponse>), List<PublishSessionSignersResponse> signers = default(List<PublishSessionSignersResponse>))
        {
            this.Approvers = approvers;
            this.Signers = signers;
        }
        
        /// <summary>
        /// Gets or Sets Approvers
        /// </summary>
        [DataMember(Name="approvers", EmitDefaultValue=false)]
        public List<PublishSessionApproversResponse> Approvers { get; set; }

        /// <summary>
        /// Gets or Sets Signers
        /// </summary>
        [DataMember(Name="signers", EmitDefaultValue=false)]
        public List<PublishSessionSignersResponse> Signers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishSessionResponse {\n");
            sb.Append("  Approvers: ").Append(Approvers).Append("\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
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
            return this.Equals(input as PublishSessionResponse);
        }

        /// <summary>
        /// Returns true if PublishSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PublishSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishSessionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Approvers == input.Approvers ||
                    this.Approvers != null &&
                    input.Approvers != null &&
                    this.Approvers.SequenceEqual(input.Approvers)
                ) && 
                (
                    this.Signers == input.Signers ||
                    this.Signers != null &&
                    input.Signers != null &&
                    this.Signers.SequenceEqual(input.Signers)
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
                if (this.Approvers != null)
                    hashCode = hashCode * 59 + this.Approvers.GetHashCode();
                if (this.Signers != null)
                    hashCode = hashCode * 59 + this.Signers.GetHashCode();
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