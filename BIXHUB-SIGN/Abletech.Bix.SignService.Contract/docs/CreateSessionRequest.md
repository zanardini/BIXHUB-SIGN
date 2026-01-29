
# Abletech.Bix.SignService.Contract.Model.V1.CreateSessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Process** | **SignSessionProcessTypeDto** |  | 
**WorkFlow** | **WorkFlowType** |  | 
**Description** | **string** | Description of the Sign Session; It will be visible to the involved actors | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Metadata for legal archiving; Allowed Values:  - **OGGETTO**: It will be written in the metadata OGGETTO during the preservation in ARXivar eArchiving.  - **EXTERNAL_ID**: It will be written in the metadata EXTERNAL_ID during the preservation in ARXivar eArchiving. | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | Parameters to modify backend behavior; Allowed Values:  - **language**: It will be the default language for all actors for which it has not been specified. This must be entered in accordance with the ISO 639 standard.  - **emailTemplate.approverInitialUrl**: Guid of email template to use to send the initial Url to Approvers.  - **emailTemplate.approverReminderUrl**: Guid of email template to use to send the a reminder to Approvers.  - **emailTemplate.signerInitialUrl**: Guid of email template to use to send the initial Url to Signers.  - **emailTemplate.signerIdeInitialUrl**: Guid of email template to use to send the initial Url to Signers who will have to undergo an identification process.  - **emailTemplate.signerReminderUrl**: Guid of email template to use to send the a reminder to Signers.  - **emailTemplate.signerCompleteUrl**: Guid of email template to use to send the finel Url to Signers. The documents can be downloaded from the page reached via this Url.  - **emailTemplate.followerCompleteUrl**: Guid of email template to use to send the finel Url to Followers. The documents can be downloaded from the page reached via this Url.  - **emailTemplate.signerReject**: Guid of email template to use to notify Signers who have already signed documents that the Sign Session has been canceled because a Signer refused to sign.  - **emailTemplate.approverReject**: Guid of email template to use to inform Approvers who have already approved the Sign Session that the Sign Session itself will be canceled because an Approver refused to approve it.  - **emailTemplate.approverInitialOtp**: Guid of email template to use to send OTP to Approvers when opening the Sign Session.  - **emailTemplate.signerInitialOtp**: Guid of email template to use to send OTP to Signers when opening the Sign Session.  - **emailTemplate.signerConfirmFieldGroupOtp**: Guid of email template to use to send OTP to Signers when completing a FieldGroup. | [optional] 
**Attributes** | **Dictionary&lt;string, string&gt;** | Attributes to modify frontend behavior; Allowed Values:  - [**Deprecated**] **otp.expireInSeconds**: Duration expressed in seconds of OTPs sent to actors.  - [**Deprecated**] **otp.message**: Text of the message used when sending OTPs via SMS.  - **dateformat**: Format in which the date will be written on the final PDF within the DatePicker fields | [optional] 
**Webhooks** | [**List&lt;CreateWebhookDto&gt;**](CreateWebhookDto.md) | List of URLs that should receive a Post API call when the session proceeds | [optional] 
**Approvers** | [**List&lt;CreateApproverDto&gt;**](CreateApproverDto.md) | List of Approvers who will need to approve the Sign Session before the Signers can start signing documents | [optional] 
**Followers** | [**List&lt;CreateFollowerDto&gt;**](CreateFollowerDto.md) | List of Followers who will be notified when the last Signer has successfully completed the Sign Session. They will be able to see all the Signers involved and download all the documents | [optional] 
**Documents** | [**List&lt;CreateDocumentDto&gt;**](CreateDocumentDto.md) | List of Documents that will be viewed and/or signed during the Sign Session | [optional] 
**Signers** | [**List&lt;CreateSignerDto&gt;**](CreateSignerDto.md) | List of Signers who will have to sign the documents in this Sign Session | [optional] 
**RequireIdentificationForSigners** | **bool?** | If true, all Signers will have to identify themselves unless otherwise specified at the individual Signer level | [optional] 
**RequireStrongAuthForSigners** | **bool?** | If true, Signers will have to enter an OTP when opening the Sign Session. [**Deprecated**]: Use Signer property requireIdentification | [optional] 
**RequireStrongAuthForApprovers** | **bool?** | If true, Approvers will have to enter an OTP when opening the Sign Session | [optional] 
**RequireTimestampingForDocuments** | **bool?** | If true, a timestamp will be applied to Documents at the end of the Sign Session | [optional] 
**LockAllChangesInSignedDocuments** | **bool?** | If true, at the end of the Sign Session the Documents will be sealed to prevent further changes | [optional] 
**AcquireBiometricData** | **bool?** | If true, biometric data of all Signers will be acquired with the graphometric property set to true | [optional] 
**ExternalId** | **string** | Optional identifier to recognize the Sign Session in other software. ExternalIds are not guaranteed to be unique. If Metadata EXTERNAL_ID has no value, this property will be written in the metadata EXTERNAL_ID during the preservation in ARXivar eArchiving | [optional] 
**RetentionDays** | **int?** | Number of days the Sign Session can be completed from the time of Publish. If the last Signer has not completed the process by the time the Sign Session expires, the Sign Session will be deleted | [optional] 
**DaysToDownload** | **int?** | Number of days that Documents will be available for download after the Sign Session is completed | [optional] 
**AutomaticReminder** | **AutomaticReminderType** |  | 
**ExtraProperties** | **Dictionary&lt;string, string&gt;** | Any extra properties to add to the Sign Session | [optional] 
**CustomAutomaticReminderDays** | **int?** | Number of days after the first notification to send an automatic reminder. This value is read only if the automaticReminder property has a value of Custom | [optional] 
**IsPrivate** | **bool** | If true, the Sign Session will be visible only to who created it and to users whose email addresses are included in the privateViewers property | [optional] 
**PrivateViewers** | **List&lt;string&gt;** | List of email of the only users who can see the Sign Session if the isPrivate property is true | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

