
# Abletech.Bix.SignService.Contract.Model.V1.CreateApproverDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Approver&#39;s email address; It may receive notifications or OTP | 
**Description** | **string** | Approver&#39;s description | 
**IndexOrder** | **float** | Approver&#39;s index order; Approvers will approve the Sign Session in order according to this property | [optional] 
**RedirectUri** | **string** | URL to which the Approver will be redirected after the approval process is complete | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Approver in other software. ExternalIds are not guaranteed to be unique | [optional] 
**Language** | **string** | Language in which the Approver will receive automatic notifications. This must be entered in accordance with the ISO 639 standard | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

