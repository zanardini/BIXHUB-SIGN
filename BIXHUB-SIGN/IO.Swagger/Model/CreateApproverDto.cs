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
    /// CreateApproverDto
    /// </summary>
    [DataContract]
        public partial class CreateApproverDto :  IEquatable<CreateApproverDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApproverDto" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="description">description.</param>
        /// <param name="indexOrder">indexOrder.</param>
        /// <param name="redirectUri">redirectUri.</param>
        /// <param name="externalId">externalId.</param>
        public CreateApproverDto(string email = default(string), string description = default(string), float? indexOrder = default(float?), string redirectUri = default(string), string externalId = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for CreateApproverDto and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            this.Description = description;
            this.IndexOrder = indexOrder;
            this.RedirectUri = redirectUri;
            this.ExternalId = externalId;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IndexOrder
        /// </summary>
        [DataMember(Name="indexOrder", EmitDefaultValue=false)]
        public float? IndexOrder { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUri
        /// </summary>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }

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
            sb.Append("class CreateApproverDto {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IndexOrder: ").Append(IndexOrder).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(input as CreateApproverDto);
        }

        /// <summary>
        /// Returns true if CreateApproverDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateApproverDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateApproverDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IndexOrder == input.IndexOrder ||
                    (this.IndexOrder != null &&
                    this.IndexOrder.Equals(input.IndexOrder))
                ) && 
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IndexOrder != null)
                    hashCode = hashCode * 59 + this.IndexOrder.GetHashCode();
                if (this.RedirectUri != null)
                    hashCode = hashCode * 59 + this.RedirectUri.GetHashCode();
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
