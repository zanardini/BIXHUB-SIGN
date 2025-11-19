
# Abletech.Bix.SignService.Contract.Model.V1.GetSessionDetailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **Guid** |  | [optional] 
**Description** | **string** |  | [optional] 
**Process** | **SignSessionProcessTypeDto** |  | 
**Status** | **SignSessionStatus** |  | 
**WorkFlow** | **WorkFlowType** |  | 
**CreatedDate** | **DateTime** |  | [optional] 
**UpdatedDate** | **DateTime** |  | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**ExtraProperties** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Approvers** | [**List&lt;ApproverSessionDetailResponse&gt;**](ApproverSessionDetailResponse.md) |  | [optional] 
**Documents** | [**List&lt;DocumentSessionDetailResponse&gt;**](DocumentSessionDetailResponse.md) |  | [optional] 
**Signers** | [**List&lt;SignerSessionDetailResponse&gt;**](SignerSessionDetailResponse.md) |  | [optional] 
**Followers** | [**List&lt;FollowerSessionDetailResponse&gt;**](FollowerSessionDetailResponse.md) |  | [optional] 
**ExternalId** | **string** |  | [optional] 
**ExpirationDate** | **DateTime?** |  | [optional] 
**RejectionDate** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

