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
    /// IDCardAcquiredUserResponse
    /// </summary>
    [DataContract]
        public partial class IDCardAcquiredUserResponse :  IEquatable<IDCardAcquiredUserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IDCardAcquiredUserResponse" /> class.
        /// </summary>
        /// <param name="documentIdentifier">documentIdentifier.</param>
        /// <param name="expiryDate">expiryDate.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="acquiredFront">acquiredFront.</param>
        /// <param name="acquiredRear">acquiredRear.</param>
        public IDCardAcquiredUserResponse(string documentIdentifier = default(string), DateTime? expiryDate = default(DateTime?), DocumentType documentType = default(DocumentType), bool? acquiredFront = default(bool?), bool? acquiredRear = default(bool?))
        {
            this.DocumentIdentifier = documentIdentifier;
            this.ExpiryDate = expiryDate;
            this.DocumentType = documentType;
            this.AcquiredFront = acquiredFront;
            this.AcquiredRear = acquiredRear;
        }
        
        /// <summary>
        /// Gets or Sets DocumentIdentifier
        /// </summary>
        [DataMember(Name="documentIdentifier", EmitDefaultValue=false)]
        public string DocumentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets AcquiredFront
        /// </summary>
        [DataMember(Name="acquiredFront", EmitDefaultValue=false)]
        public bool? AcquiredFront { get; set; }

        /// <summary>
        /// Gets or Sets AcquiredRear
        /// </summary>
        [DataMember(Name="acquiredRear", EmitDefaultValue=false)]
        public bool? AcquiredRear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IDCardAcquiredUserResponse {\n");
            sb.Append("  DocumentIdentifier: ").Append(DocumentIdentifier).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  AcquiredFront: ").Append(AcquiredFront).Append("\n");
            sb.Append("  AcquiredRear: ").Append(AcquiredRear).Append("\n");
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
            return this.Equals(input as IDCardAcquiredUserResponse);
        }

        /// <summary>
        /// Returns true if IDCardAcquiredUserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IDCardAcquiredUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IDCardAcquiredUserResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentIdentifier == input.DocumentIdentifier ||
                    (this.DocumentIdentifier != null &&
                    this.DocumentIdentifier.Equals(input.DocumentIdentifier))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.AcquiredFront == input.AcquiredFront ||
                    (this.AcquiredFront != null &&
                    this.AcquiredFront.Equals(input.AcquiredFront))
                ) && 
                (
                    this.AcquiredRear == input.AcquiredRear ||
                    (this.AcquiredRear != null &&
                    this.AcquiredRear.Equals(input.AcquiredRear))
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
                if (this.DocumentIdentifier != null)
                    hashCode = hashCode * 59 + this.DocumentIdentifier.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.AcquiredFront != null)
                    hashCode = hashCode * 59 + this.AcquiredFront.GetHashCode();
                if (this.AcquiredRear != null)
                    hashCode = hashCode * 59 + this.AcquiredRear.GetHashCode();
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
