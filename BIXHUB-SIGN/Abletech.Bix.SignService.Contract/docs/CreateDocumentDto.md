
# Abletech.Bix.SignService.Contract.Model.V1.CreateDocumentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Document&#39;s description | 
**FileGuid** | **Guid** | The &#39;fileGuid&#39; obtained via the &#39;Upload File&#39; API | 
**SealPositions** | [**List&lt;CreatePositionDto&gt;**](CreatePositionDto.md) | List of Document locations where a rosette should be placed at the end of the Sign Session | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Document in other software.  ExternalIds are not guaranteed to be unique | [optional] 
**MandatoryRead** | **bool** | If true, Signers will be forced to read this Document to the end before they can begin signing | [optional] 
**IndexOrder** | **float** | Order in which Documents will be presented to Approvers | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

