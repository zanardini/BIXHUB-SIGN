
# Abletech.Bix.SignService.Contract.Model.V1.SignerSessionDetailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **Guid** | Signer&#39;s guid | [optional] 
**Email** | **string** | Signer&#39;s email address; It may receive notifications or OTP | [optional] 
**Description** | **string** | Signer&#39;s description | [optional] 
**TaxCode** | **string** | Signer&#39;s taxcode | [optional] 
**IndexOrder** | **float** | Signer&#39;s index order; Signers will sign the Sign Session in order according to this property | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Signer in other software. ExternalIds are not guaranteed to be unique | [optional] 
**Attachments** | [**List&lt;AttachmentSessionDetailResponse&gt;**](AttachmentSessionDetailResponse.md) | List of Attachments that the Signer can upload | [optional] 
**FieldGroups** | [**List&lt;FieldGroupSessionDetailResponse&gt;**](FieldGroupSessionDetailResponse.md) | List of FieldGroups that the Signer will have to complete. Each FieldGroup can be validated via a different OTP | [optional] 
**Graphometric** | **bool** | If true, the Signer will be required to sign on specific devices that can detect stroke pressure | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

