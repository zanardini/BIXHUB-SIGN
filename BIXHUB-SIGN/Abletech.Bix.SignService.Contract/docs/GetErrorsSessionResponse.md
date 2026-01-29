
# Abletech.Bix.SignService.Contract.Model.V1.GetErrorsSessionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SessionGuid** | **Guid** | Guid of Sign Session | [optional] 
**Process** | **SignSessionProcessTypeDto** |  | 
**Status** | **SignSessionStatus** |  | 
**CreatedDate** | **DateTime** | Sign Session creation date (UTC standard) | [optional] 
**CompletedDate** | **DateTime?** | Sign Session completion date (UTC standard) | [optional] 
**Errors** | [**List&lt;SignErrorDto&gt;**](SignErrorDto.md) | List of non-blocking errors that occurred while continuing this Sign Session | [optional] 
**ErrorsNumber** | **int** | Number of non-blocking errors that occurred while continuing this Sign Session | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

