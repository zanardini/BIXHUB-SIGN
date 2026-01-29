
# Abletech.Bix.SignService.Contract.Model.V1.GetSessionDetailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **Guid** | Guid of Sign Session | [optional] 
**Description** | **string** | Description of the Sign Session | [optional] 
**Process** | **SignSessionProcessTypeDto** |  | 
**Status** | **SignSessionStatus** |  | 
**WorkFlow** | **WorkFlowType** |  | 
**CreatedDate** | **DateTime** | Sign Session creation date (UTC standard) | [optional] 
**UpdatedDate** | **DateTime** | Sign Session update date (UTC standard) | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | Parameters to modify backend behavior; Allowed Values:  - **language**: It will be the default language for all actors for which it has not been specified. This must be entered in accordance with the ISO 639 standard.  - **emailTemplate.approverInitialUrl**: Guid of email template to use to send the initial Url to Approvers.  - **emailTemplate.approverReminderUrl**: Guid of email template to use to send the a reminder to Approvers.  - **emailTemplate.signerInitialUrl**: Guid of email template to use to send the initial Url to Signers.  - **emailTemplate.signerIdeInitialUrl**: Guid of email template to use to send the initial Url to Signers who will have to undergo an identification process.  - **emailTemplate.signerReminderUrl**: Guid of email template to use to send the a reminder to Signers.  - **emailTemplate.signerCompleteUrl**: Guid of email template to use to send the finel Url to Signers. The documents can be downloaded from the page reached via this Url.  - **emailTemplate.followerCompleteUrl**: Guid of email template to use to send the finel Url to Followers. The documents can be downloaded from the page reached via this Url.  - **emailTemplate.signerReject**: Guid of email template to use to notify Signers who have already signed documents that the Sign Session has been canceled because a Signer refused to sign.  - **emailTemplate.approverReject**: Guid of email template to use to inform Approvers who have already approved the Sign Session that the Sign Session itself will be canceled because an Approver refused to approve it.  - **emailTemplate.approverInitialOtp**: Guid of email template to use to send OTP to Approvers when opening the Sign Session.  - **emailTemplate.signerInitialOtp**: Guid of email template to use to send OTP to Signers when opening the Sign Session.  - **emailTemplate.signerConfirmFieldGroupOtp**: Guid of email template to use to send OTP to Signers when completing a FieldGroup. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Metadata for legal archiving; Allowed Values:  - **OGGETTO**: It will be written in the metadata OGGETTO during the preservation in ARXivar eArchiving.  - **EXTERNAL_ID**: It will be written in the metadata EXTERNAL_ID during the preservation in ARXivar eArchiving. | [optional] 
**Attributes** | **Dictionary&lt;string, string&gt;** | Attributes to modify frontend behavior; Allowed Values:  - [**Deprecated**] **otp.expireInSeconds**: Duration expressed in seconds of OTPs sent to actors.  - [**Deprecated**] **otp.message**: Text of the message used when sending OTPs via SMS.  - **dateformat**: Format in which the date will be written on the final PDF within the DatePicker fields | [optional] 
**ExtraProperties** | **Dictionary&lt;string, string&gt;** | Extra properties specified when creating Sign Session | [optional] 
**Approvers** | [**List&lt;ApproverSessionDetailResponse&gt;**](ApproverSessionDetailResponse.md) | List of Approvers who will need to approve the Sign Session before the Signers can start signing documents | [optional] 
**Documents** | [**List&lt;DocumentSessionDetailResponse&gt;**](DocumentSessionDetailResponse.md) | List of Documents that will be viewed and/or signed during the Sign Session | [optional] 
**Signers** | [**List&lt;SignerSessionDetailResponse&gt;**](SignerSessionDetailResponse.md) | List of Signers who will have to sign the documents in this Sign Session | [optional] 
**Followers** | [**List&lt;FollowerSessionDetailResponse&gt;**](FollowerSessionDetailResponse.md) | List of Followers who will be notified when the last Signer has successfully completed the Sign Session. They will be able to see all the Signers involved and download all the documents | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Sign Session in other software. ExternalIds are not guaranteed to be unique. If Metadata EXTERNAL_ID has no value, this property will be written in the metadata EXTERNAL_ID during the preservation in ARXivar eArchiving | [optional] 
**ExpirationDate** | **DateTime?** | Sign Session expiration date (UTC standard) | [optional] 
**RejectionDate** | **DateTime?** | Date an Approver or Signer rejected the Sign Session (UTC standard) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

