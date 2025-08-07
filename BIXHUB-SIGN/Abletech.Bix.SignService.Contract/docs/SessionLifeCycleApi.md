# Abletech.Bix.SignService.Contract.Client.V1.SessionLifeCycleApi

All URIs are relative to */SignService*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SessionLifeCycleCreateAndPublishPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclecreateandpublishpost) | **POST** /api/v1/SessionLifeCycle/CreateAndPublish | 
[**ApiV1SessionLifeCycleCreatePost**](SessionLifeCycleApi.md#apiv1sessionlifecyclecreatepost) | **POST** /api/v1/SessionLifeCycle/Create | Create a signature session
[**ApiV1SessionLifeCycleDeleteSessionGuidDelete**](SessionLifeCycleApi.md#apiv1sessionlifecycledeletesessionguiddelete) | **DELETE** /api/v1/SessionLifeCycle/Delete/{sessionGuid} | Delete a signature session
[**ApiV1SessionLifeCycleGetAllPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetallpost) | **POST** /api/v1/SessionLifeCycle/GetAll | Return all signature sessions with the status
[**ApiV1SessionLifeCycleGetAttachmentBase64SessionGuidSignerGuidAttachmentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetattachmentbase64sessionguidsignerguidattachmentguidget) | **GET** /api/v1/SessionLifeCycle/GetAttachmentBase64/{sessionGuid}/{signerGuid}/{attachmentGuid} | 
[**ApiV1SessionLifeCycleGetAttachmentSessionGuidSignerGuidAttachmentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetattachmentsessionguidsignerguidattachmentguidget) | **GET** /api/v1/SessionLifeCycle/GetAttachment/{sessionGuid}/{signerGuid}/{attachmentGuid} | Returns attachment uploaded by user during signature session
[**ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetaudittrail64sessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAuditTrail64/{sessionGuid} | 
[**ApiV1SessionLifeCycleGetAuditTrailSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetaudittrailsessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAuditTrail/{sessionGuid} | Returns Audit Trail of a signature session
[**ApiV1SessionLifeCycleGetErrorsGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegeterrorsget) | **GET** /api/v1/SessionLifeCycle/GetErrors | Returns errors details of a list of signature sessions
[**ApiV1SessionLifeCycleGetFieldsSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetfieldssessionguidget) | **GET** /api/v1/SessionLifeCycle/GetFields/{sessionGuid} | Return info of all fields in a flatten way
[**ApiV1SessionLifeCycleGetSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsessionguidget) | **GET** /api/v1/SessionLifeCycle/Get/{sessionGuid} | Return info of a signature session
[**ApiV1SessionLifeCycleGetSignedResultBase64SessionGuidDocumentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsignedresultbase64sessionguiddocumentguidget) | **GET** /api/v1/SessionLifeCycle/GetSignedResultBase64/{sessionGuid}/{documentGuid} | 
[**ApiV1SessionLifeCycleGetSignedResultSessionGuidDocumentGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsignedresultsessionguiddocumentguidget) | **GET** /api/v1/SessionLifeCycle/GetSignedResult/{sessionGuid}/{documentGuid} | Returns signed document by documentGuid and sessionGuid
[**ApiV1SessionLifeCycleGetStatusPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetstatuspost) | **POST** /api/v1/SessionLifeCycle/GetStatus | Returns status details of a list of signature sessions
[**ApiV1SessionLifeCycleMarkErrorAsFixedSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclemarkerrorasfixedsessionguidpost) | **POST** /api/v1/SessionLifeCycle/MarkErrorAsFixed/{sessionGuid} | 
[**ApiV1SessionLifeCyclePublishSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclepublishsessionguidpost) | **POST** /api/v1/SessionLifeCycle/Publish/{sessionGuid} | Make signature session viewable
[**ApiV1SessionLifeCycleRestoreIdentificationSessionSessionGuidSignerGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclerestoreidentificationsessionsessionguidsignerguidpost) | **POST** /api/v1/SessionLifeCycle/RestoreIdentificationSession/{sessionGuid}/{signerGuid} | 
[**ApiV1SessionLifeCycleSendEmailSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclesendemailsessionguidpost) | **POST** /api/v1/SessionLifeCycle/SendEmail/{sessionGuid} | Send an email to next user with the link to activate the signature session
[**ApiV1SessionLifeCycleUpdateSessionGuidPatch**](SessionLifeCycleApi.md#apiv1sessionlifecycleupdatesessionguidpatch) | **PATCH** /api/v1/SessionLifeCycle/Update/{sessionGuid} | Update attributes, parameters or metadata of an signature session
[**ApiV1SessionLifeCycleUploadFileBase64Post**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilebase64post) | **POST** /api/v1/SessionLifeCycle/UploadFileBase64 | 
[**ApiV1SessionLifeCycleUploadFilePost**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilepost) | **POST** /api/v1/SessionLifeCycle/UploadFile | Upload a document in format pdf
[**ApiV1SessionLifeCycleUploadFilesBase64Post**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilesbase64post) | **POST** /api/v1/SessionLifeCycle/UploadFilesBase64 | 
[**ApiV1SessionLifeCycleUploadFilesPost**](SessionLifeCycleApi.md#apiv1sessionlifecycleuploadfilespost) | **POST** /api/v1/SessionLifeCycle/UploadFiles | Upload documents in format pdf



## ApiV1SessionLifeCycleCreateAndPublishPost

> PublishSessionResponse ApiV1SessionLifeCycleCreateAndPublishPost (CreateSessionRequest createSessionRequest = null)



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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Create a signature session

Permits to create the signature session in draft state. In order to make session viewable call publish API after create.

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
                // Create a signature session
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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Delete a signature session

Delete a signature session if exist and if is in a deletable status

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
                // Delete a signature session
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

Return all signature sessions with the status

Return all signature sessions with the status, for more details about session status use API GetStatus

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
                // Return all signature sessions with the status
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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Returns attachment uploaded by user during signature session

Returns attachment uploaded by user during signature session

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
                // Returns attachment uploaded by user during signature session
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet

> FileDataBase64 ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet (Guid sessionGuid, Guid? documentGuid = null)



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
            var documentGuid = "documentGuid_example";  // Guid? |  (optional) 

            try
            {
                FileDataBase64 result = apiInstance.ApiV1SessionLifeCycleGetAuditTrail64SessionGuidGet(sessionGuid, documentGuid);
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
 **documentGuid** | **Guid?**|  | [optional] 

### Return type

[**FileDataBase64**](FileDataBase64.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Returns Audit Trail of a signature session

Returns Audit Trail in pdf format with the evidence of all operations executed by users during the signature session

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
                // Returns Audit Trail of a signature session
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Returns errors details of a list of signature sessions

Returns errors details of a list of signature sessions. For example if you use webhooks and your registered endpoint is not reachable for 24h, with this API you could acquire this information, and remediate.

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
                // Returns errors details of a list of signature sessions
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Return info of all fields in a flatten way

Return info of all fields in flatten way in order to make easy the acquisition of a selected values by users for fields

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
                // Return info of all fields in a flatten way
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Return info of a signature session

Returns the signature session's metadata/parameters/attributes and the details about approvers, signers, documents, attachments and fields.

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
                // Return info of a signature session
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Returns signed document by documentGuid and sessionGuid

Returns signed document by sessionGuid and documentGuid, use API Get to obtain all the documents guid of a created session.

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
                // Returns signed document by documentGuid and sessionGuid
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Returns status details of a list of signature sessions

Returns status details of a list of signature sessions base on the process types

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
                // Returns status details of a list of signature sessions
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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
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

Make signature session viewable

Make signature session viewable, after this operation any ather modification are not allowed

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
                // Make signature session viewable
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Send an email to next user with the link to activate the signature session

Send an email to next user with the link to activate the signature session. This API offers option reminder in order to use different template for reminder operation.

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
                // Send an email to next user with the link to activate the signature session
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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Update attributes, parameters or metadata of an signature session

Update attributes, parameters or metadata of an signature session

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
                // Update attributes, parameters or metadata of an signature session
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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Upload a document in format pdf

Permits document upload for preparing a signature session.

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
                // Upload a document in format pdf
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

- **Content-Type**: application/json; x-api-version=1.0, text/json; x-api-version=1.0, application/*+json; x-api-version=1.0
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


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

Upload documents in format pdf

Permits documents upload for preparing a signature session.

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
                // Upload documents in format pdf
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
- **Accept**: text/plain; x-api-version=1.0, application/json; x-api-version=1.0, text/json; x-api-version=1.0


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

