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
    /// GetAllSessionRequest
    /// </summary>
    [DataContract]
        public partial class GetAllSessionRequest :  IEquatable<GetAllSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllSessionRequest" /> class.
        /// </summary>
        /// <param name="skip">skip.</param>
        /// <param name="take">take.</param>
        public GetAllSessionRequest(int? skip = default(int?), int? take = default(int?))
        {
            this.Skip = skip;
            this.Take = take;
        }
        
        /// <summary>
        /// Gets or Sets Skip
        /// </summary>
        [DataMember(Name="skip", EmitDefaultValue=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// Gets or Sets Take
        /// </summary>
        [DataMember(Name="take", EmitDefaultValue=false)]
        public int? Take { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAllSessionRequest {\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Take: ").Append(Take).Append("\n");
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
            return this.Equals(input as GetAllSessionRequest);
        }

        /// <summary>
        /// Returns true if GetAllSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAllSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAllSessionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Skip == input.Skip ||
                    (this.Skip != null &&
                    this.Skip.Equals(input.Skip))
                ) && 
                (
                    this.Take == input.Take ||
                    (this.Take != null &&
                    this.Take.Equals(input.Take))
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
                if (this.Skip != null)
                    hashCode = hashCode * 59 + this.Skip.GetHashCode();
                if (this.Take != null)
                    hashCode = hashCode * 59 + this.Take.GetHashCode();
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
