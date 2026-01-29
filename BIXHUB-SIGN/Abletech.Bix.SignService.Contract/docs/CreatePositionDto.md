
# Abletech.Bix.SignService.Contract.Model.V1.CreatePositionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **PositionType** |  | 
**AcroFieldTag** | **string** | Identifier of the Acrofield to find. It&#39;s only read if type property is set to AcroField | [optional] 
**PageNumber** | **int?** | Number of PDF page. Set to &#39;1&#39; to select the first page of the PDF | [optional] 
**Top** | **float?** | Distance from the top edge of the page, expressed as a percentage of the page height | [optional] 
**Left** | **float?** | Distance from the left edge of the page, expressed as a percentage of the page width | [optional] 
**Label** | **string** | Label to search in the PDF. It&#39;s only read if type property is set to Label | [optional] 
**Occurrence** | **int?** | Occurrence of the Label within the PDF (If pageNumber is set, the search is restricted to that page). It&#39;s only read if type property is set to Label | [optional] 
**OffsetX** | **float?** | Move on the X-axis relative to the Label position to insert the new Acrofield, expressed as a percentage of the page width. It&#39;s only read if type property is set to Label | [optional] 
**OffsetY** | **float?** | Move on the Y-axis relative to the Label position to insert the new Acrofield, expressed as a percentage of the page height. It&#39;s only read if type property is set to Label | [optional] 
**Width** | **float?** | Width of the new Acrofield that will be added, expressed as a percentage of the page width | [optional] 
**Height** | **float?** | Height of the new Acrofield that will be added, expressed as a percentage of the page height | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

