
# Abletech.Bix.SignService.Contract.Model.V1.CreateSessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Process** | **SignSessionProcessTypeDto** |  | 
**WorkFlow** | **WorkFlowType** |  | 
**Description** | **string** |  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Webhooks** | [**List&lt;CreateWebhookDto&gt;**](CreateWebhookDto.md) |  | [optional] 
**Approvers** | [**List&lt;CreateApproverDto&gt;**](CreateApproverDto.md) |  | [optional] 
**Followers** | [**List&lt;CreateFollowerDto&gt;**](CreateFollowerDto.md) |  | [optional] 
**Documents** | [**List&lt;CreateDocumentDto&gt;**](CreateDocumentDto.md) |  | [optional] 
**Signers** | [**List&lt;CreateSignerDto&gt;**](CreateSignerDto.md) |  | [optional] 
**RequireIdentificationForSigners** | **bool?** |  | [optional] 
**RequireStrongAuthForSigners** | **bool?** |  | [optional] 
**RequireStrongAuthForApprovers** | **bool?** |  | [optional] 
**RequireTimestampingForDocuments** | **bool?** |  | [optional] 
**LockAllChangesInSignedDocuments** | **bool?** |  | [optional] 
**AcquireBiometricData** | **bool?** |  | [optional] 
**ExternalId** | **string** |  | [optional] 
**RetentionDays** | **int?** |  | [optional] 
**DaysToDownload** | **int?** |  | [optional] 
**AutomaticReminder** | **AutomaticReminderType** |  | 
**ExtraFields** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**CustomAutomaticReminderDays** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

