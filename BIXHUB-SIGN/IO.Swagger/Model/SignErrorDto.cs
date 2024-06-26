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
    /// SignErrorDto
    /// </summary>
    [DataContract]
        public partial class SignErrorDto :  IEquatable<SignErrorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignErrorDto" /> class.
        /// </summary>
        /// <param name="guid">guid.</param>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        /// <param name="timeStamp">timeStamp.</param>
        public SignErrorDto(Guid? guid = default(Guid?), SignErrorType type = default(SignErrorType), string details = default(string), DateTime? timeStamp = default(DateTime?))
        {
            this.Guid = guid;
            this.Type = type;
            this.Details = details;
            this.TimeStamp = timeStamp;
        }
        
        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public Guid? Guid { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public SignErrorType Type { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name="timeStamp", EmitDefaultValue=false)]
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignErrorDto {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
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
            return this.Equals(input as SignErrorDto);
        }

        /// <summary>
        /// Returns true if SignErrorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SignErrorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignErrorDto input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.TimeStamp == input.TimeStamp ||
                    (this.TimeStamp != null &&
                    this.TimeStamp.Equals(input.TimeStamp))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.TimeStamp != null)
                    hashCode = hashCode * 59 + this.TimeStamp.GetHashCode();
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
