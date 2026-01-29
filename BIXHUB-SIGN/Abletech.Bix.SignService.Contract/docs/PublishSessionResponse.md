
# Abletech.Bix.SignService.Contract.Model.V1.PublishSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Approvers** | [**List&lt;PublishSessionApproversResponse&gt;**](PublishSessionApproversResponse.md) | List of Approvers who will need to approve the Sign Session before the Signers can start signing documents | [optional] 
**Signers** | [**List&lt;PublishSessionSignersResponse&gt;**](PublishSessionSignersResponse.md) | List of Signers who will have to sign the documents in this Sign Session | [optional] 
**Errors** | [**List&lt;PublishSessionErrorsResponse&gt;**](PublishSessionErrorsResponse.md) | List of non-blocking errors that occurred publishing this Sign Session | [optional] 
**SessionGuid** | **Guid** | Guid of the newly created Sign Session | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

