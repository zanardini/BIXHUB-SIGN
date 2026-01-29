
# Abletech.Bix.SignService.Contract.Model.V1.ApproverStatusSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **Guid** | Approver&#39;s guid | [optional] 
**Email** | **string** | Approver&#39;s email address; It may receive notifications or OTP | [optional] 
**Description** | **string** | Approver&#39;s description | [optional] 
**IndexOrder** | **float** | Approver&#39;s index order; Approvers will approve the Sign Session in order according to this property | [optional] 
**Status** | **ApproverStatusSessionState** |  | 
**ExternalId** | **string** | Optional identifier to recognize the Approver in other software. ExternalIds are not guaranteed to be unique | [optional] 
**FirstAccessDate** | **DateTime?** | Date the Approver first visited the received link | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

