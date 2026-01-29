
# Abletech.Bix.SignService.Contract.Model.V1.GetStatusSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SessionGuid** | **Guid** | Guid of Sign Session | [optional] 
**Process** | **SignSessionProcessTypeDto** |  | 
**Status** | **SignSessionStatus** |  | 
**Reason** | **string** | Reason why the Sign Session was rejected | [optional] 
**CreatedDate** | **DateTime** | Sign Session creation date (UTC standard) | [optional] 
**CompletedDate** | **DateTime?** | Sign Session completion date (UTC standard) | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Sign Session in other software. ExternalIds are not guaranteed to be unique. If Metadata EXTERNAL_ID has no value, this property will be written in the metadata EXTERNAL_ID during the preservation in ARXivar eArchiving | [optional] 
**NextActors** | [**List&lt;NextActorStatusSessionResponse&gt;**](NextActorStatusSessionResponse.md) | List of upcoming actors with a valid link | [optional] 
**Approvers** | [**List&lt;ApproverStatusSessionResponse&gt;**](ApproverStatusSessionResponse.md) | List of Approvers who will need to approve the Sign Session before the Signers can start signing documents | [optional] 
**Signers** | [**List&lt;SignerStatusSessionResponse&gt;**](SignerStatusSessionResponse.md) | List of Signers who will have to sign the documents in this Sign Session | [optional] 
**Errors** | [**List&lt;SignErrorDto&gt;**](SignErrorDto.md) | List of non-blocking errors that occurred while continuing this Sign Session | [optional] 
**ExpirationDate** | **DateTime?** | Sign Session expiration date (UTC standard) | [optional] 
**RejectionDate** | **DateTime?** | Date an Approver or Signer rejected the Sign Session (UTC standard) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

