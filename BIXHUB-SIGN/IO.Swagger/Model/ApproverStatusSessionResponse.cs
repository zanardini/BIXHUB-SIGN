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
    /// ApproverStatusSessionResponse
    /// </summary>
    [DataContract]
        public partial class ApproverStatusSessionResponse :  IEquatable<ApproverStatusSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApproverStatusSessionResponse" /> class.
        /// </summary>
        /// <param name="guid">guid.</param>
        /// <param name="email">email.</param>
        /// <param name="description">description.</param>
        /// <param name="indexOrder">indexOrder.</param>
        /// <param name="status">status.</param>
        /// <param name="externalId">externalId.</param>
        public ApproverStatusSessionResponse(Guid? guid = default(Guid?), string email = default(string), string description = default(string), float? indexOrder = default(float?), ApproverStatusSessionState status = default(ApproverStatusSessionState), string externalId = default(string))
        {
            this.Guid = guid;
            this.Email = email;
            this.Description = description;
            this.IndexOrder = indexOrder;
            this.Status = status;
            this.ExternalId = externalId;
        }
        
        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public Guid? Guid { get; set; }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ApproverStatusSessionState Status { get; set; }

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
            sb.Append("class ApproverStatusSessionResponse {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IndexOrder: ").Append(IndexOrder).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ApproverStatusSessionResponse);
        }

        /// <summary>
        /// Returns true if ApproverStatusSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApproverStatusSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApproverStatusSessionResponse input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IndexOrder != null)
                    hashCode = hashCode * 59 + this.IndexOrder.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
