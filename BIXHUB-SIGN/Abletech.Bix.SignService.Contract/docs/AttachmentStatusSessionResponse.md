
# Abletech.Bix.SignService.Contract.Model.V1.AttachmentStatusSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **Guid** | Attachment&#39;s guid | [optional] 
**Mandatory** | **bool** | If true, Signer must upload this Attachment to complete the Sign Session | [optional] 
**Uploaded** | **bool** | If true, Signer has already uploaded this Attachment | [optional] 
**IndexOrder** | **float** | Order in which Attachments will be presented to Signer | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Attachment in other software. ExternalIds are not guaranteed to be unique | [optional] 
**AttachmentValidationTypeAI** | **AttachmentValidationTypeAiDto** |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

