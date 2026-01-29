# Abletech.Bix.SignService.Contract.Client.V1.SessionLifeCycleApi

All URIs are relative to */SignService*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SessionLifeCycleCreateAndPublishPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclecreateandpublishpost) | **POST** /api/v1/SessionLifeCycle/CreateAndPublish | Create and Publish
[**ApiV1SessionLifeCycleCreatePost**](SessionLifeCycleApi.md#apiv1sessionlifecyclecreatepost) | **POST** /api/v1/SessionLifeCycle/Create | Create File
[**ApiV1SessionLifeCycleDeleteSessionGuidDelete**](SessionLifeCycleApi.md#apiv1sessionlifecycledeletesessionguiddelete) | **DELETE** /api/v1/SessionLifeCycle/Delete/{sessionGuid} | Delete session
[**ApiV1SessionLifeCycleGetAllPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetallpost) | **POST** /api/v1/SessionLifeCycle/GetAll | Get Sessions
[**ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetattachmentbase64sessionguidsignerguidattachmentguidget) | **GET** /api/v1/SessionLifeCycle/GetAttachmentBase64/{sessionGuid}/{signerGuid}/{attachmentGuid} | Get Attachment Base64
[**ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetattachmentsessionguidsignerguidattachmentguidget) | **GET** /api/v1/SessionLifeCycle/GetAttachment/{sessionGuid}/{signerGuid}/{attachmentGuid} | Get Attachment
[**ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetaudittrail64sessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAuditTrail64/{sessionGuid} | Get AuditTrail Base64
[**ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetaudittrailsessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAuditTrail/{sessionGuid} | Get AuditTrail
[**ApiV1SessionLifeCycleGetErrorsGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegeterrorsget) | **GET** /api/v1/SessionLifeCycle/GetErrors | Get Errors
[**ApiV1SessionLifeCycleGetFieldsSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetfieldssessionguidget) | **GET** /api/v1/SessionLifeCycle/GetFields/{sessionGuid} | Get Fields
[**ApiV1SessionLifeCycleGetSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsessionguidget) | **GET** /api/v1/SessionLifeCycle/Get/{sessionGuid} | Get Session
[**ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsignedresultbase64sessionguiddocumentguidget) | **GET** /api/v1/SessionLifeCycle/GetSignedResultBase64/{sessionGuid}/{documentGuid} | Get Signed Result Base64
[**ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsignedresultsessionguiddocumentguidget) | **GET** /api/v1/SessionLifeCycle/GetSignedResult/{sessionGuid}/{documentGuid} | Get Signed Result
[**ApiV1SessionLifeCycleGetStatusPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetstatuspost) | **POST** /api/v1/SessionLifeCycle/GetStatus | Get Sessions Status
[**ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclemarkerrorasfixedsessionguidpost) | **POST** /api/v1/SessionLifeCycle/MarkErrorAsFixed/{sessionGuid} | Fix Error
[**ApiV1SessionLifeCyclePublishSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclepublishsessionguidpost) | **POST** /api/v1/SessionLifeCycle/Publish/{sessionGuid} | Publish
[**ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclerestoreidentificationsessionsessionguidsignerguidpost) | **POST** /api/v1/SessionLifeCycle/RestoreIdentificationSession/{sessionGuid}/{signerGuid} | Restore Identification
[**ApiV1SessionLifeCycleSendEmailSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclesendemailsessionguidpost) | **POST** /api/v1/SessionLifeCycle/SendEmail/{sessionGuid} | Send Email
[**ApiV1SessionLifeCycleSendNotificationSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclesendnotificationsessionguidpost) | **POST** /api/v1/SessionLifeCycle/SendNotification/{sessionGuid} | Send Notification
[**ApiV1SessionLifeCycleUpdateSessionGuidPatch**](SessionLifeCycleApi.md#apiv1sessionlifecycleupdatesessionguidpatch) | **PATCH** /api/v1/SessionLifeCycle/Update/{sessionGuid} | Update session
[**ApiV1SessionLifeCycleUploadFileBase64Post**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilebase64post) | **POST** /api/v1/SessionLifeCycle/UploadFileBase64 | Upload File Base64
[**ApiV1SessionLifeCycleUploadFilePost**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilepost) | **POST** /api/v1/SessionLifeCycle/UploadFile | Upload File
[**ApiV1SessionLifeCycleUploadFilesBase64Post**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilesbase64post) | **POST** /api/v1/SessionLifeCycle/UploadFilesBase64 | Upload Files Base64
[**ApiV1SessionLifeCycleUploadFilesPost**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilespost) | **POST** /api/v1/SessionLifeCycle/UploadFiles | Upload Files



## ApiV1SessionLifeCycleCreateAndPublishPost

> PublishSessionResponse ApiV1SessionLifeCycleCreateAndPublishPost (CreateSessionRequest createSessionRequest = null)

Create and Publish

Allows creation and publication of a Sign Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleCreateAndPublishPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var createSessionRequest = new CreateSessionRequest(); // CreateSessionRequest |  (optional) 

            try
            {
                // Create and Publish
                PublishSessionResponse result = apiInstance.ApiV1SessionLifeCycleCreateAndPublishPost(createSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleCreateAndPublishPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSessionRequest** | [**CreateSessionRequest**](CreateSessionRequest.md)|  | [optional] 

### Return type

[**PublishSessionResponse**](PublishSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleCreatePost

> CreateSessionResponse ApiV1SessionLifeCycleCreatePost (CreateSessionRequest createSessionRequest = null)

Create File

Allows the creation of a Sign Session. The Sign Session must then be published before it can be started

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleCreatePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var createSessionRequest = new CreateSessionRequest(); // CreateSessionRequest |  (optional) 

            try
            {
                // Create File
                CreateSessionResponse result = apiInstance.ApiV1SessionLifeCycleCreatePost(createSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleCreatePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createSessionRequest** | [**CreateSessionRequest**](CreateSessionRequest.md)|  | [optional] 

### Return type

[**CreateSessionResponse**](CreateSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleDeleteSessionGuidDelete

> void ApiV1SessionLifeCycleDeleteSessionGuidDelete (Guid sessionGuid)

Delete session

Deletes a Sign Session, if it exists and is in a state that allows deletion

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleDeleteSessionGuidDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Delete session
                apiInstance.ApiV1SessionLifeCycleDeleteSessionGuidDelete(sessionGuid);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleDeleteSessionGuidDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAllPost

> GetAllSessionResponseGetPaginatedListResponse ApiV1SessionLifeCycleGetAllPost (GetAllSessionRequest getAllSessionRequest = null)

Get Sessions

Returns a list of Sign Sessions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAllPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var getAllSessionRequest = new GetAllSessionRequest(); // GetAllSessionRequest |  (optional) 

            try
            {
                // Get Sessions
                GetAllSessionResponseGetPaginatedListResponse result = apiInstance.ApiV1SessionLifeCycleGetAllPost(getAllSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAllPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getAllSessionRequest** | [**GetAllSessionRequest**](GetAllSessionRequest.md)|  | [optional] 

### Return type

[**GetAllSessionResponseGetPaginatedListResponse**](GetAllSessionResponseGetPaginatedListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGet

> FileDataBase64 ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGet (Guid sessionGuid, Guid signerGuid, Guid attachmentGuid)

Get Attachment Base64

[**Deprecated**] Endpoint, please use Get Attachment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var signerGuid = "signerGuid_example";  // Guid | 
            var attachmentGuid = "attachmentGuid_example";  // Guid | 

            try
            {
                // Get Attachment Base64
                FileDataBase64 result = apiInstance.ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGet(sessionGuid, signerGuid, attachmentGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **signerGuid** | **Guid**|  | 
 **attachmentGuid** | **Guid**|  | 

### Return type

[**FileDataBase64**](FileDataBase64.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGet (Guid sessionGuid, Guid signerGuid, Guid attachmentGuid)

Get Attachment

Returns the file attached by a Signer during a Sign Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var signerGuid = "signerGuid_example";  // Guid | 
            var attachmentGuid = "attachmentGuid_example";  // Guid | 

            try
            {
                // Get Attachment
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGet(sessionGuid, signerGuid, attachmentGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **signerGuid** | **Guid**|  | 
 **attachmentGuid** | **Guid**|  | 

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet

> FileDataBase64 ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet (Guid sessionGuid)

Get AuditTrail Base64

[**Deprecated**] Endpoint, please use Get AuditTrail

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Get AuditTrail Base64
                FileDataBase64 result = apiInstance.ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 

### Return type

[**FileDataBase64**](FileDataBase64.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet (Guid sessionGuid)

Get AuditTrail

Returns a PDF containing the evidence of all the operations performed by the actors during the Sign Session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAuditTrailSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Get AuditTrail
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetErrorsGet

> List&lt;GetErrorsSessionResponse&gt; ApiV1SessionLifeCycleGetErrorsGet (int? take = null, int? skip = null)

Get Errors

Returns errors related to a list of sessions. For example, if you're using webhooks and your endpoint is unreachable for 24 hours, this API can retrieve that information and resolve the issue.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetErrorsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var take = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 

            try
            {
                // Get Errors
                List<GetErrorsSessionResponse> result = apiInstance.ApiV1SessionLifeCycleGetErrorsGet(take, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetErrorsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **take** | **int?**|  | [optional] 
 **skip** | **int?**|  | [optional] 

### Return type

[**List&lt;GetErrorsSessionResponse&gt;**](GetErrorsSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetFieldsSessionGuidGet

> List&lt;GetFieldsDtoResponse&gt; ApiV1SessionLifeCycleGetFieldsSessionGuidGet (Guid sessionGuid, Guid? documentGuid = null, Guid? signerGuid = null, Guid? fieldGroupGuid = null)

Get Fields

Returns fields information in a flattened format, making it easier to read the keys/values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetFieldsSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var documentGuid = "documentGuid_example";  // Guid? |  (optional) 
            var signerGuid = "signerGuid_example";  // Guid? |  (optional) 
            var fieldGroupGuid = "fieldGroupGuid_example";  // Guid? |  (optional) 

            try
            {
                // Get Fields
                List<GetFieldsDtoResponse> result = apiInstance.ApiV1SessionLifeCycleGetFieldsSessionGuidGet(sessionGuid, documentGuid, signerGuid, fieldGroupGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetFieldsSessionGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **documentGuid** | **Guid?**|  | [optional] 
 **signerGuid** | **Guid?**|  | [optional] 
 **fieldGroupGuid** | **Guid?**|  | [optional] 

### Return type

[**List&lt;GetFieldsDtoResponse&gt;**](GetFieldsDtoResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetSessionGuidGet

> GetSessionDetailResponse ApiV1SessionLifeCycleGetSessionGuidGet (Guid sessionGuid)

Get Session

Returns information about Sign Session, actors and documents

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Get Session
                GetSessionDetailResponse result = apiInstance.ApiV1SessionLifeCycleGetSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetSessionGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 

### Return type

[**GetSessionDetailResponse**](GetSessionDetailResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGet

> FileDataBase64 ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGet (Guid sessionGuid, Guid documentGuid)

Get Signed Result Base64

[**Deprecated**] Endpoint, please use Get Signed Result

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var documentGuid = "documentGuid_example";  // Guid | 

            try
            {
                // Get Signed Result Base64
                FileDataBase64 result = apiInstance.ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGet(sessionGuid, documentGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **documentGuid** | **Guid**|  | 

### Return type

[**FileDataBase64**](FileDataBase64.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet (Guid sessionGuid, Guid documentGuid)

Get Signed Result

If the Sign Session is completed, the signed PDF is returned. Use the Get Session Endpoint to get documents Guids.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var documentGuid = "documentGuid_example";  // Guid | 

            try
            {
                // Get Signed Result
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet(sessionGuid, documentGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **documentGuid** | **Guid**|  | 

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetStatusPost

> List&lt;GetStatusSessionResponse&gt; ApiV1SessionLifeCycleGetStatusPost (List<Guid> requestBody = null)

Get Sessions Status

Returns the status of a list of Sign Sessions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetStatusPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Get Sessions Status
                List<GetStatusSessionResponse> result = apiInstance.ApiV1SessionLifeCycleGetStatusPost(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetStatusPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestBody** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 

### Return type

[**List&lt;GetStatusSessionResponse&gt;**](GetStatusSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPost

> void ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPost (Guid sessionGuid, FixErrorRequest fixErrorRequest = null)

Fix Error

Allows the removal of errors that are returned by Get Errors

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var fixErrorRequest = new FixErrorRequest(); // FixErrorRequest |  (optional) 

            try
            {
                // Fix Error
                apiInstance.ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPost(sessionGuid, fixErrorRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **fixErrorRequest** | [**FixErrorRequest**](FixErrorRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCyclePublishSessionGuidPost

> PublishSessionResponse ApiV1SessionLifeCyclePublishSessionGuidPost (Guid sessionGuid)

Publish

Makes a Sign Session visible, after this operation it will no longer be possible to update the Sign Session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCyclePublishSessionGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Publish
                PublishSessionResponse result = apiInstance.ApiV1SessionLifeCyclePublishSessionGuidPost(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCyclePublishSessionGuidPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 

### Return type

[**PublishSessionResponse**](PublishSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPost

> RestoreIdentificationSessionResponse ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPost (Guid sessionGuid, Guid signerGuid)

Restore Identification

Allows you to restore the Identification Session linked to a Sign Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var signerGuid = "signerGuid_example";  // Guid | 

            try
            {
                // Restore Identification
                RestoreIdentificationSessionResponse result = apiInstance.ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPost(sessionGuid, signerGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **signerGuid** | **Guid**|  | 

### Return type

[**RestoreIdentificationSessionResponse**](RestoreIdentificationSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleSendEmailSessionGuidPost

> ActorType ApiV1SessionLifeCycleSendEmailSessionGuidPost (Guid sessionGuid, SendEmailRequest sendEmailRequest = null)

Send Email

[**Deprecated**] Endpoint, please use Send Notification

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleSendEmailSessionGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var sendEmailRequest = new SendEmailRequest(); // SendEmailRequest |  (optional) 

            try
            {
                // Send Email
                ActorType result = apiInstance.ApiV1SessionLifeCycleSendEmailSessionGuidPost(sessionGuid, sendEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleSendEmailSessionGuidPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **sendEmailRequest** | [**SendEmailRequest**](SendEmailRequest.md)|  | [optional] 

### Return type

[**ActorType**](ActorType.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleSendNotificationSessionGuidPost

> ActorType ApiV1SessionLifeCycleSendNotificationSessionGuidPost (Guid sessionGuid, SendEmailRequest sendEmailRequest = null)

Send Notification

Send a notification to the next actor containing the link to proceed with the Sign Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleSendNotificationSessionGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var sendEmailRequest = new SendEmailRequest(); // SendEmailRequest |  (optional) 

            try
            {
                // Send Notification
                ActorType result = apiInstance.ApiV1SessionLifeCycleSendNotificationSessionGuidPost(sessionGuid, sendEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleSendNotificationSessionGuidPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **sendEmailRequest** | [**SendEmailRequest**](SendEmailRequest.md)|  | [optional] 

### Return type

[**ActorType**](ActorType.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleUpdateSessionGuidPatch

> void ApiV1SessionLifeCycleUpdateSessionGuidPatch (Guid sessionGuid, UpdateSessionRequest updateSessionRequest = null)

Update session

Update data of a Sign Session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleUpdateSessionGuidPatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var updateSessionRequest = new UpdateSessionRequest(); // UpdateSessionRequest |  (optional) 

            try
            {
                // Update session
                apiInstance.ApiV1SessionLifeCycleUpdateSessionGuidPatch(sessionGuid, updateSessionRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleUpdateSessionGuidPatch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionGuid** | **Guid**|  | 
 **updateSessionRequest** | [**UpdateSessionRequest**](UpdateSessionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleUploadFileBase64Post

> SavedFileResponse ApiV1SessionLifeCycleUploadFileBase64Post (UploadFileBase64Request uploadFileBase64Request = null)

Upload File Base64

[**Deprecated**] Endpoint, please use Upload File

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleUploadFileBase64PostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var uploadFileBase64Request = new UploadFileBase64Request(); // UploadFileBase64Request |  (optional) 

            try
            {
                // Upload File Base64
                SavedFileResponse result = apiInstance.ApiV1SessionLifeCycleUploadFileBase64Post(uploadFileBase64Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleUploadFileBase64Post: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadFileBase64Request** | [**UploadFileBase64Request**](UploadFileBase64Request.md)|  | [optional] 

### Return type

[**SavedFileResponse**](SavedFileResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleUploadFilePost

> SavedFileResponse ApiV1SessionLifeCycleUploadFilePost (System.IO.Stream file = null)

Upload File

Allows uploading a PDF file

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleUploadFilePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Upload File
                SavedFileResponse result = apiInstance.ApiV1SessionLifeCycleUploadFilePost(file);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleUploadFilePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**|  | [optional] 

### Return type

[**SavedFileResponse**](SavedFileResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleUploadFilesBase64Post

> List&lt;SavedFileResponse&gt; ApiV1SessionLifeCycleUploadFilesBase64Post (UploadFilesRequest uploadFilesRequest = null)

Upload Files Base64

[**Deprecated**] Endpoint, please use Upload Files

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleUploadFilesBase64PostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var uploadFilesRequest = new UploadFilesRequest(); // UploadFilesRequest |  (optional) 

            try
            {
                // Upload Files Base64
                List<SavedFileResponse> result = apiInstance.ApiV1SessionLifeCycleUploadFilesBase64Post(uploadFilesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleUploadFilesBase64Post: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadFilesRequest** | [**UploadFilesRequest**](UploadFilesRequest.md)|  | [optional] 

### Return type

[**List&lt;SavedFileResponse&gt;**](SavedFileResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleUploadFilesPost

> List&lt;SavedFileResponse&gt; ApiV1SessionLifeCycleUploadFilesPost (List<System.IO.Stream> files = null)

Upload Files

Allows uploading multiple PDF files

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleUploadFilesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var files = new List<System.IO.Stream>(); // List<System.IO.Stream> |  (optional) 

            try
            {
                // Upload Files
                List<SavedFileResponse> result = apiInstance.ApiV1SessionLifeCycleUploadFilesPost(files);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleUploadFilesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;System.IO.Stream&gt;**](System.IO.Stream.md)|  | [optional] 

### Return type

[**List&lt;SavedFileResponse&gt;**](SavedFileResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

