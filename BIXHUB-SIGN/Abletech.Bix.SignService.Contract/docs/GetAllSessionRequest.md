
# Abletech.Bix.SignService.Contract.Model.V1.GetAllSessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessUnitGuid** | **Guid?** | BusinessUnit&#39;s guid | [optional] 
**SessionGuid** | **Guid?** | Guid of Sign Session | [optional] 
**Process** | **SignSessionProcessTypeDto** |  | [optional] 
**WorkFlow** | **WorkFlowType** |  | [optional] 
**SessionStatus** | **SignSessionStatus** |  | [optional] 
**FromCreationDate** | **DateTime?** |  | [optional] 
**ToCreationDate** | **DateTime?** |  | [optional] 
**Skip** | **int?** |  | [optional] 
**Take** | **int?** |  | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Sign Session in other software. ExternalIds are not guaranteed to be unique. If Metadata EXTERNAL_ID has no value, this property will be written in the metadata EXTERNAL_ID during the preservation in ARXivar eArchiving | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

