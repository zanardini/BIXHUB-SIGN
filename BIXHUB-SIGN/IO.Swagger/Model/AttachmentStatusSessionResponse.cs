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
    /// AttachmentStatusSessionResponse
    /// </summary>
    [DataContract]
        public partial class AttachmentStatusSessionResponse :  IEquatable<AttachmentStatusSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentStatusSessionResponse" /> class.
        /// </summary>
        /// <param name="guid">guid.</param>
        /// <param name="mandatory">mandatory.</param>
        /// <param name="uploaded">uploaded.</param>
        /// <param name="indexOrder">indexOrder.</param>
        /// <param name="externalId">externalId.</param>
        public AttachmentStatusSessionResponse(Guid? guid = default(Guid?), bool? mandatory = default(bool?), bool? uploaded = default(bool?), float? indexOrder = default(float?), string externalId = default(string))
        {
            this.Guid = guid;
            this.Mandatory = mandatory;
            this.Uploaded = uploaded;
            this.IndexOrder = indexOrder;
            this.ExternalId = externalId;
        }
        
        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public Guid? Guid { get; set; }

        /// <summary>
        /// Gets or Sets Mandatory
        /// </summary>
        [DataMember(Name="mandatory", EmitDefaultValue=false)]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// Gets or Sets Uploaded
        /// </summary>
        [DataMember(Name="uploaded", EmitDefaultValue=false)]
        public bool? Uploaded { get; set; }

        /// <summary>
        /// Gets or Sets IndexOrder
        /// </summary>
        [DataMember(Name="indexOrder", EmitDefaultValue=false)]
        public float? IndexOrder { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentStatusSessionResponse {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Mandatory: ").Append(Mandatory).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
            sb.Append("  IndexOrder: ").Append(IndexOrder).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
            return this.Equals(input as AttachmentStatusSessionResponse);
        }

        /// <summary>
        /// Returns true if AttachmentStatusSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentStatusSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentStatusSessionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.Mandatory == input.Mandatory ||
                    (this.Mandatory != null &&
                    this.Mandatory.Equals(input.Mandatory))
                ) && 
                (
                    this.Uploaded == input.Uploaded ||
                    (this.Uploaded != null &&
                    this.Uploaded.Equals(input.Uploaded))
                ) && 
                (
                    this.IndexOrder == input.IndexOrder ||
                    (this.IndexOrder != null &&
                    this.IndexOrder.Equals(input.IndexOrder))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
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
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.Mandatory != null)
                    hashCode = hashCode * 59 + this.Mandatory.GetHashCode();
                if (this.Uploaded != null)
                    hashCode = hashCode * 59 + this.Uploaded.GetHashCode();
                if (this.IndexOrder != null)
                    hashCode = hashCode * 59 + this.IndexOrder.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
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