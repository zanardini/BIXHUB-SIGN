
# Abletech.Bix.SignService.Contract.Model.V1.CreateSignerDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Signer&#39;s description | 
**Email** | **string** | Signer&#39;s email address; It may receive notifications or OTP | [optional] 
**PhoneNumber** | **string** | Signer&#39;s phone number; It may receive notifications or OTP | [optional] 
**TaxCode** | **string** | Signer&#39;s taxcode | [optional] 
**VerificationMode** | **VerificationModeDto** |  | 
**IndexOrder** | **float** | Signer&#39;s index order; Signers will sign the Sign Session in order according to this property | [optional] 
**RedirectUri** | **string** | URL to which the Signer will be redirected after the sign process is complete | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Signer in other software. ExternalIds are not guaranteed to be unique | [optional] 
**FieldGroups** | [**List&lt;CreateFieldGroupDto&gt;**](CreateFieldGroupDto.md) | List of FieldGroups that the Signer will have to complete. Each FieldGroup can be validated via a different OTP | [optional] 
**Attachments** | [**List&lt;CreateAttachmentDto&gt;**](CreateAttachmentDto.md) | List of Attachments that the Signer can upload | [optional] 
**Language** | **string** | Language in which the Signer will receive automatic notifications. This must be entered in accordance with the ISO 639 standard | [optional] 
**RequireIdentification** | **bool?** | If true, the Signer will be asked to identify themselves before they can sign Documents | [optional] 
**Graphometric** | **bool** | If true, the Signer will be required to sign on specific devices that can detect stroke pressure | [optional] 
**Base64SignatureImage** | **string** | Base64 image that the Signer will use to sign Documents | [optional] 
**NotificationChannel** | **NotificationChannel** |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

