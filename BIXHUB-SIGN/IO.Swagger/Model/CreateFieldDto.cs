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
    /// CreateFieldDto
    /// </summary>
    [DataContract]
        public partial class CreateFieldDto :  IEquatable<CreateFieldDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFieldDto" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="longDescription">longDescription.</param>
        /// <param name="indexOrder">indexOrder.</param>
        /// <param name="optional">optional.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="values">values.</param>
        /// <param name="radioButtonFields">radioButtonFields.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="font">font.</param>
        /// <param name="backGroundColor">backGroundColor.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="multiLine">multiLine.</param>
        /// <param name="position">position.</param>
        public CreateFieldDto(FieldType type = default(FieldType), string shortDescription = default(string), string longDescription = default(string), float? indexOrder = default(float?), bool? optional = default(bool?), string externalId = default(string), List<string> values = default(List<string>), List<CreateRadioButtonFieldDto> radioButtonFields = default(List<CreateRadioButtonFieldDto>), double? fontSize = default(double?), FontAbleTech font = default(FontAbleTech), ColorDto backGroundColor = default(ColorDto), int? maxLength = default(int?), bool? multiLine = default(bool?), CreatePositionDto position = default(CreatePositionDto))
        {
            this.Type = type;
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
            this.IndexOrder = indexOrder;
            this.Optional = optional;
            this.ExternalId = externalId;
            this.Values = values;
            this.RadioButtonFields = radioButtonFields;
            this.FontSize = fontSize;
            this.Font = font;
            this.BackGroundColor = backGroundColor;
            this.MaxLength = maxLength;
            this.MultiLine = multiLine;
            this.Position = position;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public FieldType Type { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets LongDescription
        /// </summary>
        [DataMember(Name="longDescription", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Gets or Sets IndexOrder
        /// </summary>
        [DataMember(Name="indexOrder", EmitDefaultValue=false)]
        public float? IndexOrder { get; set; }

        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Gets or Sets RadioButtonFields
        /// </summary>
        [DataMember(Name="radioButtonFields", EmitDefaultValue=false)]
        public List<CreateRadioButtonFieldDto> RadioButtonFields { get; set; }

        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or Sets Font
        /// </summary>
        [DataMember(Name="font", EmitDefaultValue=false)]
        public FontAbleTech Font { get; set; }

        /// <summary>
        /// Gets or Sets BackGroundColor
        /// </summary>
        [DataMember(Name="backGroundColor", EmitDefaultValue=false)]
        public ColorDto BackGroundColor { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets MultiLine
        /// </summary>
        [DataMember(Name="multiLine", EmitDefaultValue=false)]
        public bool? MultiLine { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public CreatePositionDto Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFieldDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  IndexOrder: ").Append(IndexOrder).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  RadioButtonFields: ").Append(RadioButtonFields).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  BackGroundColor: ").Append(BackGroundColor).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MultiLine: ").Append(MultiLine).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as CreateFieldDto);
        }

        /// <summary>
        /// Returns true if CreateFieldDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFieldDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFieldDto input)
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
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
                ) && 
                (
                    this.IndexOrder == input.IndexOrder ||
                    (this.IndexOrder != null &&
                    this.IndexOrder.Equals(input.IndexOrder))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.RadioButtonFields == input.RadioButtonFields ||
                    this.RadioButtonFields != null &&
                    input.RadioButtonFields != null &&
                    this.RadioButtonFields.SequenceEqual(input.RadioButtonFields)
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.Font == input.Font ||
                    (this.Font != null &&
                    this.Font.Equals(input.Font))
                ) && 
                (
                    this.BackGroundColor == input.BackGroundColor ||
                    (this.BackGroundColor != null &&
                    this.BackGroundColor.Equals(input.BackGroundColor))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.MultiLine == input.MultiLine ||
                    (this.MultiLine != null &&
                    this.MultiLine.Equals(input.MultiLine))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.IndexOrder != null)
                    hashCode = hashCode * 59 + this.IndexOrder.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.RadioButtonFields != null)
                    hashCode = hashCode * 59 + this.RadioButtonFields.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.Font != null)
                    hashCode = hashCode * 59 + this.Font.GetHashCode();
                if (this.BackGroundColor != null)
                    hashCode = hashCode * 59 + this.BackGroundColor.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.MultiLine != null)
                    hashCode = hashCode * 59 + this.MultiLine.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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
