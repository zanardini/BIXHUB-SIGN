# Abletech.Bix.IdeService.Contract.Client.V1.MonitoringApi

All URIs are relative to */OnBoardingService*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1MonitoringHealthyGet**](MonitoringApi.md#apiv1monitoringhealthyget) | **GET** /api/v1/Monitoring/Healthy | 



## ApiV1MonitoringHealthyGet

> void ApiV1MonitoringHealthyGet ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.IdeService.Contract.Client.V1;
using Abletech.Bix.IdeService.Contract.Client;
using Abletech.Bix.IdeService.Contract.Model.V1;

namespace Example
{
    public class ApiV1MonitoringHealthyGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/OnBoardingService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MonitoringApi(Configuration.Default);

            try
            {
                apiInstance.ApiV1MonitoringHealthyGet();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MonitoringApi.ApiV1MonitoringHealthyGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

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

