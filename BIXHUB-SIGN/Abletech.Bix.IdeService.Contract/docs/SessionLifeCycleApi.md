# Abletech.Bix.IdeService.Contract.Client.V1.SessionLifeCycleApi

All URIs are relative to */OnBoardingService*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SessionLifeCycleCreatePost**](SessionLifeCycleApi.md#apiv1sessionlifecyclecreatepost) | **POST** /api/v1/SessionLifeCycle/Create | Create the identification session
[**ApiV1SessionLifeCycleDeleteSessionGuidDelete**](SessionLifeCycleApi.md#apiv1sessionlifecycledeletesessionguiddelete) | **DELETE** /api/v1/SessionLifeCycle/Delete/{sessionGuid} | Delete an identification session
[**ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetacquiredidinfosessionguidpost) | **POST** /api/v1/SessionLifeCycle/GetAcquiredIDInfo/{sessionGuid} | Returns acquired or verified informations of a prospect customer during the identification session
[**ApiV1SessionLifeCycleGetAcquiredUserInfoSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetacquireduserinfosessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAcquiredUserInfo/{sessionGuid} | Returns acquired or verified informations of a prospect customer during the identification session
[**ApiV1SessionLifeCycleGetAllPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetallpost) | **POST** /api/v1/SessionLifeCycle/GetAll | Returns a list of identification sessions
[**ApiV1SessionLifeCycleGetAuditLogBase64SessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetauditlogbase64sessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAuditLogBase64/{sessionGuid} | Returns Audit Logs of an identification session
[**ApiV1SessionLifeCycleGetAuditLogSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetauditlogsessionguidget) | **GET** /api/v1/SessionLifeCycle/GetAuditLog/{sessionGuid} | Returns Audit Logs of an identification session
[**ApiV1SessionLifeCycleGetDigitalIdentityDataSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetdigitalidentitydatasessionguidget) | **GET** /api/v1/SessionLifeCycle/GetDigitalIdentityData/{sessionGuid} | 
[**ApiV1SessionLifeCycleGetIdCardBackSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetidcardbacksessionguidget) | **GET** /api/v1/SessionLifeCycle/GetIdCardBack/{sessionGuid} | 
[**ApiV1SessionLifeCycleGetIdCardFrontSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetidcardfrontsessionguidget) | **GET** /api/v1/SessionLifeCycle/GetIdCardFront/{sessionGuid} | 
[**ApiV1SessionLifeCycleGetLivenessDetectionSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetlivenessdetectionsessionguidget) | **GET** /api/v1/SessionLifeCycle/GetLivenessDetection/{sessionGuid} | 
[**ApiV1SessionLifeCycleGetSelfieSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetselfiesessionguidget) | **GET** /api/v1/SessionLifeCycle/GetSelfie/{sessionGuid} | 
[**ApiV1SessionLifeCycleGetSessionGuidGet**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetsessionguidget) | **GET** /api/v1/SessionLifeCycle/Get/{sessionGuid} | Returns info of an identification sessione
[**ApiV1SessionLifeCycleGetStatusPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclegetstatuspost) | **POST** /api/v1/SessionLifeCycle/GetStatus | Returns status of a list of identification session
[**ApiV1SessionLifeCycleSendEmailSessionGuidPost**](SessionLifeCycleApi.md#apiv1sessionlifecyclesendemailsessionguidpost) | **POST** /api/v1/SessionLifeCycle/SendEmail/{sessionGuid} | Send an email with the link to activate the identification session
[**ApiV1SessionLifeCycleUpdateSessionGuidPut**](SessionLifeCycleApi.md#apiv1sessionlifecycleupdatesessionguidput) | **PUT** /api/v1/SessionLifeCycle/Update/{sessionGuid} | Update attributes, parameters or metadata of an identification session



## ApiV1SessionLifeCycleCreatePost

> CreateSessionResponse ApiV1SessionLifeCycleCreatePost (CreateSessionRequest createSessionRequest = null)

Create the identification session

Permits to create the identification session for a prospect user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleCreatePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var createSessionRequest = new CreateSessionRequest(); // CreateSessionRequest |  (optional) 

            try
            {
                // Create the identification session
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

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleDeleteSessionGuidDelete

> void ApiV1SessionLifeCycleDeleteSessionGuidDelete (Guid sessionGuid)

Delete an identification session

Delete an identification session if exist

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleDeleteSessionGuidDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Delete an identification session
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
- **Accept**: application/json


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


## ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost

> GetAcquiredIDInfoResponse ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost (Guid sessionGuid, GetAcquiredIDInfoRequest getAcquiredIDInfoRequest = null)

Returns acquired or verified informations of a prospect customer during the identification session

Returns acquired or verified informations of a prospect customer during the identification session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var getAcquiredIDInfoRequest = new GetAcquiredIDInfoRequest(); // GetAcquiredIDInfoRequest |  (optional) 

            try
            {
                // Returns acquired or verified informations of a prospect customer during the identification session
                GetAcquiredIDInfoResponse result = apiInstance.ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost(sessionGuid, getAcquiredIDInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAcquiredIDInfoSessionGuidPost: " + e.Message );
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
 **getAcquiredIDInfoRequest** | [**GetAcquiredIDInfoRequest**](GetAcquiredIDInfoRequest.md)|  | [optional] 

### Return type

[**GetAcquiredIDInfoResponse**](GetAcquiredIDInfoResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **412** | Precondition Failed |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAcquiredUserInfoSessionGuidGet

> GetAcquiredUserInfo ApiV1SessionLifeCycleGetAcquiredUserInfoSessionGuidGet (Guid sessionGuid)

Returns acquired or verified informations of a prospect customer during the identification session

Returns acquired or verified informations of a prospect customer during the identification session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAcquiredUserInfoSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Returns acquired or verified informations of a prospect customer during the identification session
                GetAcquiredUserInfo result = apiInstance.ApiV1SessionLifeCycleGetAcquiredUserInfoSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAcquiredUserInfoSessionGuidGet: " + e.Message );
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

[**GetAcquiredUserInfo**](GetAcquiredUserInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **412** | Precondition Failed |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAllPost

> GetAllSessionResponse ApiV1SessionLifeCycleGetAllPost (GetAllSessionRequest getAllSessionRequest = null)

Returns a list of identification sessions

Returns a list of identification sessions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAllPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var getAllSessionRequest = new GetAllSessionRequest(); // GetAllSessionRequest |  (optional) 

            try
            {
                // Returns a list of identification sessions
                GetAllSessionResponse result = apiInstance.ApiV1SessionLifeCycleGetAllPost(getAllSessionRequest);
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

[**GetAllSessionResponse**](GetAllSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetAuditLogBase64SessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetAuditLogBase64SessionGuidGet (Guid sessionGuid)

Returns Audit Logs of an identification session

Returns Audit Logs in pdf format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAuditLogBase64SessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Returns Audit Logs of an identification session
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetAuditLogBase64SessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditLogBase64SessionGuidGet: " + e.Message );
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
- **Accept**: application/json


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


## ApiV1SessionLifeCycleGetAuditLogSessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetAuditLogSessionGuidGet (Guid sessionGuid)

Returns Audit Logs of an identification session

Returns Audit Logs in pdf format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetAuditLogSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Returns Audit Logs of an identification session
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetAuditLogSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetAuditLogSessionGuidGet: " + e.Message );
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
- **Accept**: application/json


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


## ApiV1SessionLifeCycleGetDigitalIdentityDataSessionGuidGet

> DigitalIdentityResponse ApiV1SessionLifeCycleGetDigitalIdentityDataSessionGuidGet (Guid sessionGuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetDigitalIdentityDataSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                DigitalIdentityResponse result = apiInstance.ApiV1SessionLifeCycleGetDigitalIdentityDataSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetDigitalIdentityDataSessionGuidGet: " + e.Message );
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

[**DigitalIdentityResponse**](DigitalIdentityResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetIdCardBackSessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetIdCardBackSessionGuidGet (Guid sessionGuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetIdCardBackSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetIdCardBackSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetIdCardBackSessionGuidGet: " + e.Message );
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
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetIdCardFrontSessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetIdCardFrontSessionGuidGet (Guid sessionGuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetIdCardFrontSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetIdCardFrontSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetIdCardFrontSessionGuidGet: " + e.Message );
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
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetLivenessDetectionSessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetLivenessDetectionSessionGuidGet (Guid sessionGuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetLivenessDetectionSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetLivenessDetectionSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetLivenessDetectionSessionGuidGet: " + e.Message );
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
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetSelfieSessionGuidGet

> System.IO.Stream ApiV1SessionLifeCycleGetSelfieSessionGuidGet (Guid sessionGuid)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetSelfieSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                System.IO.Stream result = apiInstance.ApiV1SessionLifeCycleGetSelfieSessionGuidGet(sessionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleGetSelfieSessionGuidGet: " + e.Message );
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
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ApiV1SessionLifeCycleGetSessionGuidGet

> GetSessionResponse ApiV1SessionLifeCycleGetSessionGuidGet (Guid sessionGuid)

Returns info of an identification sessione

Returns the identification session's metadata/parameters/attributes risk score associated if the flow is completed

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetSessionGuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 

            try
            {
                // Returns info of an identification sessione
                GetSessionResponse result = apiInstance.ApiV1SessionLifeCycleGetSessionGuidGet(sessionGuid);
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

[**GetSessionResponse**](GetSessionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


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


## ApiV1SessionLifeCycleGetStatusPost

> List&lt;GetStatusSessionResponse&gt; ApiV1SessionLifeCycleGetStatusPost (List<Guid> requestBody = null)

Returns status of a list of identification session

Returns status and risk score of a identification session base on the flow types

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleGetStatusPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Returns status of a list of identification session
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

- **Content-Type**: application/json
- **Accept**: application/json


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


## ApiV1SessionLifeCycleSendEmailSessionGuidPost

> void ApiV1SessionLifeCycleSendEmailSessionGuidPost (Guid sessionGuid, SendEmailRequest sendEmailRequest = null)

Send an email with the link to activate the identification session

Send an email with the link to activate the identification session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleSendEmailSessionGuidPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var sendEmailRequest = new SendEmailRequest(); // SendEmailRequest |  (optional) 

            try
            {
                // Send an email with the link to activate the identification session
                apiInstance.ApiV1SessionLifeCycleSendEmailSessionGuidPost(sessionGuid, sendEmailRequest);
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


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


## ApiV1SessionLifeCycleUpdateSessionGuidPut

> void ApiV1SessionLifeCycleUpdateSessionGuidPut (Guid sessionGuid, UpdateSessionRequest updateSessionRequest = null)

Update attributes, parameters or metadata of an identification session

Update parameters or metadata of an identification session

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1SessionLifeCycleUpdateSessionGuidPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionLifeCycleApi(Configuration.Default);
            var sessionGuid = "sessionGuid_example";  // Guid | 
            var updateSessionRequest = new UpdateSessionRequest(); // UpdateSessionRequest |  (optional) 

            try
            {
                // Update attributes, parameters or metadata of an identification session
                apiInstance.ApiV1SessionLifeCycleUpdateSessionGuidPut(sessionGuid, updateSessionRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SessionLifeCycleApi.ApiV1SessionLifeCycleUpdateSessionGuidPut: " + e.Message );
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

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **412** | Precondition Failed |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

