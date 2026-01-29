
# Abletech.Bix.SignService.Contract.Model.V1.CreateFieldDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **FieldType** |  | 
**ShortDescription** | **string** | Field&#39;s description | 
**IndexOrder** | **float** | Field&#39;s order in this Document. This order is non-binding, it provides the signer with a guided signing experience | [optional] 
**Optional** | **bool** | If true, the Field must be filled in to complete the Sign Session | [optional] 
**InitialValue** | **string** | Field&#39;s initial value, written when the Signer opens the Sign Session. It can only be filled if type property is set to TextBox | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Field in other software. ExternalIds are not guaranteed to be unique | [optional] 
**Values** | **List&lt;string&gt;** | List of values Signer can choose from. It&#39;s only read if type property is set to ComboBox | [optional] 
**RadioButtonFields** | [**List&lt;CreateRadioButtonFieldDto&gt;**](CreateRadioButtonFieldDto.md) | List of RadioButtons Signer can choose from. It&#39;s only read if type property is set to RadioGroup | [optional] 
**FontSize** | **double?** | Font size that the text in this Field will be written in. It&#39;s only read if type property is set to TextBox | [optional] 
**Font** | **FontAbleTech** |  | [optional] 
**BackGroundColor** | [**ColorDto**](ColorDto.md) |  | [optional] 
**MaxLength** | **int?** | The maximum length of text that can be written in this Field. It&#39;s only read if type property is set to TextBox | [optional] 
**MultiLine** | **bool?** | If true, the text in this Field can wrap. It&#39;s only read if type property is set to TextBox | [optional] 
**RegexPattern** | **string** | Pattern that the text written in this Field must follow. It&#39;s only read if type property is set to TextBox | [optional] 
**DatePickerConstraint** | **DatePickerConstraint** |  | [optional] 
**Position** | [**CreatePositionDto**](CreatePositionDto.md) |  | [optional] 
**Immutable** | **bool** | If true, the value of this Field cannot be edited. It&#39;s only read if type property is set to TextBox, and InitialValue parameter has a value | [optional] 
**TextColor** | [**ColorDto**](ColorDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

