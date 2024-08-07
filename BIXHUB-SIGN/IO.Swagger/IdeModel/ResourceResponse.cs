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
    /// ResourceResponse
    /// </summary>
    [DataContract]
        public partial class ResourceResponse :  IEquatable<ResourceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceResponse" /> class.
        /// </summary>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="fileData">fileData.</param>
        public ResourceResponse(string mimeType = default(string), byte[] fileData = default(byte[]))
        {
            this.MimeType = mimeType;
            this.FileData = fileData;
        }
        
        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets FileData
        /// </summary>
        [DataMember(Name="fileData", EmitDefaultValue=false)]
        public byte[] FileData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceResponse {\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  FileData: ").Append(FileData).Append("\n");
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
            return this.Equals(input as ResourceResponse);
        }

        /// <summary>
        /// Returns true if ResourceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.FileData == input.FileData ||
                    (this.FileData != null &&
                    this.FileData.Equals(input.FileData))
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
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.FileData != null)
                    hashCode = hashCode * 59 + this.FileData.GetHashCode();
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
