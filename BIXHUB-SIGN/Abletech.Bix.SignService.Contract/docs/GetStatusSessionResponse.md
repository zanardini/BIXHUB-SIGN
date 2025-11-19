
# Abletech.Bix.SignService.Contract.Model.V1.GetStatusSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SessionGuid** | **Guid** |  | [optional] 
**Process** | **SignSessionProcessTypeDto** |  | 
**Status** | **SignSessionStatus** |  | 
**Reason** | **string** |  | [optional] 
**CreatedDate** | **DateTime** |  | [optional] 
**CompletedDate** | **DateTime?** |  | [optional] 
**ExternalId** | **string** |  | [optional] 
**NextActors** | [**List&lt;NextActorStatusSessionResponse&gt;**](NextActorStatusSessionResponse.md) |  | [optional] 
**Approvers** | [**List&lt;ApproverStatusSessionResponse&gt;**](ApproverStatusSessionResponse.md) |  | [optional] 
**Signers** | [**List&lt;SignerStatusSessionResponse&gt;**](SignerStatusSessionResponse.md) |  | [optional] 
**Errors** | [**List&lt;SignErrorDto&gt;**](SignErrorDto.md) |  | [optional] 
**ExpirationDate** | **DateTime?** |  | [optional] 
**RejectionDate** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

