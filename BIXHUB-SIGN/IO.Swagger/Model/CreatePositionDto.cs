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
    /// CreatePositionDto
    /// </summary>
    [DataContract]
        public partial class CreatePositionDto :  IEquatable<CreatePositionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePositionDto" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="acroFieldTag">acroFieldTag.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="top">top.</param>
        /// <param name="left">left.</param>
        /// <param name="label">label.</param>
        /// <param name="occurence">occurence.</param>
        /// <param name="offsetX">offsetX.</param>
        /// <param name="offsetY">offsetY.</param>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        public CreatePositionDto(PositionType type = default(PositionType), string acroFieldTag = default(string), int? pageNumber = default(int?), float? top = default(float?), float? left = default(float?), string label = default(string), int? occurence = default(int?), float? offsetX = default(float?), float? offsetY = default(float?), float? width = default(float?), float? height = default(float?))
        {
            this.Type = type;
            this.AcroFieldTag = acroFieldTag;
            this.PageNumber = pageNumber;
            this.Top = top;
            this.Left = left;
            this.Label = label;
            this.Occurence = occurence;
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.Width = width;
            this.Height = height;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public PositionType Type { get; set; }

        /// <summary>
        /// Gets or Sets AcroFieldTag
        /// </summary>
        [DataMember(Name="acroFieldTag", EmitDefaultValue=false)]
        public string AcroFieldTag { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets Top
        /// </summary>
        [DataMember(Name="top", EmitDefaultValue=false)]
        public float? Top { get; set; }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public float? Left { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Occurence
        /// </summary>
        [DataMember(Name="occurence", EmitDefaultValue=false)]
        public int? Occurence { get; set; }

        /// <summary>
        /// Gets or Sets OffsetX
        /// </summary>
        [DataMember(Name="offsetX", EmitDefaultValue=false)]
        public float? OffsetX { get; set; }

        /// <summary>
        /// Gets or Sets OffsetY
        /// </summary>
        [DataMember(Name="offsetY", EmitDefaultValue=false)]
        public float? OffsetY { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public float? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public float? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePositionDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AcroFieldTag: ").Append(AcroFieldTag).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Occurence: ").Append(Occurence).Append("\n");
            sb.Append("  OffsetX: ").Append(OffsetX).Append("\n");
            sb.Append("  OffsetY: ").Append(OffsetY).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as CreatePositionDto);
        }

        /// <summary>
        /// Returns true if CreatePositionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePositionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePositionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AcroFieldTag == input.AcroFieldTag ||
                    (this.AcroFieldTag != null &&
                    this.AcroFieldTag.Equals(input.AcroFieldTag))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.Top == input.Top ||
                    (this.Top != null &&
                    this.Top.Equals(input.Top))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Occurence == input.Occurence ||
                    (this.Occurence != null &&
                    this.Occurence.Equals(input.Occurence))
                ) && 
                (
                    this.OffsetX == input.OffsetX ||
                    (this.OffsetX != null &&
                    this.OffsetX.Equals(input.OffsetX))
                ) && 
                (
                    this.OffsetY == input.OffsetY ||
                    (this.OffsetY != null &&
                    this.OffsetY.Equals(input.OffsetY))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AcroFieldTag != null)
                    hashCode = hashCode * 59 + this.AcroFieldTag.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.Top != null)
                    hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Occurence != null)
                    hashCode = hashCode * 59 + this.Occurence.GetHashCode();
                if (this.OffsetX != null)
                    hashCode = hashCode * 59 + this.OffsetX.GetHashCode();
                if (this.OffsetY != null)
                    hashCode = hashCode * 59 + this.OffsetY.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
