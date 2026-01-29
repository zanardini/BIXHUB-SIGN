
# Abletech.Bix.SignService.Contract.Model.V1.CreateAttachmentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Attachment&#39;s description | 
**Mandatory** | **bool** | If true, Signer must upload this Attachment to complete the Sign Session | [optional] 
**AttachToAuditTrail** | **bool?** | If true, Attachments will be attached to the AuditTrail generated at the end of the Sign Session | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Attachment in other software. ExternalIds are not guaranteed to be unique | [optional] 
**IndexOrder** | **float** | Order in which Attachments will be presented to Signer | [optional] 
**AttachmentValidationTypeAi** | **AttachmentValidationTypeAiDto** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

