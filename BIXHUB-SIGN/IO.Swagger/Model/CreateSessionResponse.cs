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
    /// CreateSessionResponse
    /// </summary>
    [DataContract]
        public partial class CreateSessionResponse :  IEquatable<CreateSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionGuid">sessionGuid.</param>
        public CreateSessionResponse(Guid? sessionGuid = default(Guid?))
        {
            this.SessionGuid = sessionGuid;
        }
        
        /// <summary>
        /// Gets or Sets SessionGuid
        /// </summary>
        [DataMember(Name="sessionGuid", EmitDefaultValue=false)]
        public Guid? SessionGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSessionResponse {\n");
            sb.Append("  SessionGuid: ").Append(SessionGuid).Append("\n");
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
            return this.Equals(input as CreateSessionResponse);
        }

        /// <summary>
        /// Returns true if CreateSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSessionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionGuid == input.SessionGuid ||
                    (this.SessionGuid != null &&
                    this.SessionGuid.Equals(input.SessionGuid))
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
