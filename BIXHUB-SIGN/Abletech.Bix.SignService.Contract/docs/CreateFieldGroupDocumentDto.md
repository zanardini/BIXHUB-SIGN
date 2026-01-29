
# Abletech.Bix.SignService.Contract.Model.V1.CreateFieldGroupDocumentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileGuid** | **Guid** | The &#39;fileGuid&#39; obtained via the &#39;Upload File&#39; API. It must match the &#39;fileGuid&#39; of a Document | 
**IndexOrder** | **float** | Document&#39;s order in this FieldGroup. This order is non-binding, it provides the signer with a guided signing experience | [optional] 
**Fields** | [**List&lt;CreateFieldDto&gt;**](CreateFieldDto.md) | List of Fields in this Document belonging to FieldGroup | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

