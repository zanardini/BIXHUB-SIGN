
# Abletech.Bix.SignService.Contract.Model.V1.SignerStatusSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **Guid** | Signer&#39;s guid | [optional] 
**Email** | **string** | Signer&#39;s email address; It may receive notifications or OTP | [optional] 
**Description** | **string** | Signer&#39;s description | [optional] 
**TaxCode** | **string** | Signer&#39;s taxcode | [optional] 
**IndexOrder** | **float** | Signer&#39;s index order; Signers will sign the Sign Session in order according to this property | [optional] 
**Status** | **SignerStatusSessionState** |  | 
**Attachments** | [**List&lt;AttachmentStatusSessionResponse&gt;**](AttachmentStatusSessionResponse.md) | List of Attachments that the Signer can upload | [optional] 
**IdentificationSession** | [**IdentificationSessionStatusSessionResponse**](IdentificationSessionStatusSessionResponse.md) |  | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Signer in other software. ExternalIds are not guaranteed to be unique | [optional] 
**FirstAccessDate** | **DateTime?** | Date the Signer first visited the received link | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

