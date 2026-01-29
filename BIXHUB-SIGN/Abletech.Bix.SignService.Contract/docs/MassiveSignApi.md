# Abletech.Bix.SignService.Contract.Client.V1.MassiveSignApi

All URIs are relative to */SignService*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1MassiveSignGetCertificateGet**](MassiveSignApi.md#apiv1massivesigngetcertificateget) | **GET** /api/v1/MassiveSign/GetCertificate | Get Certificate
[**ApiV1MassiveSignSignPkcs1Post**](MassiveSignApi.md#apiv1massivesignsignpkcs1post) | **POST** /api/v1/MassiveSign/SignPkcs1 | Sign PKCS#1



## ApiV1MassiveSignGetCertificateGet

> GetCertificateResponse ApiV1MassiveSignGetCertificateGet ()

Get Certificate

Return the signing certificate

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1MassiveSignGetCertificateGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MassiveSignApi(Configuration.Default);

            try
            {
                // Get Certificate
                GetCertificateResponse result = apiInstance.ApiV1MassiveSignGetCertificateGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MassiveSignApi.ApiV1MassiveSignGetCertificateGet: " + e.Message );
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

[**GetCertificateResponse**](GetCertificateResponse.md)

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


## ApiV1MassiveSignSignPkcs1Post

> SignPkcs1Response ApiV1MassiveSignSignPkcs1Post (SignPkcs1Request signPkcs1Request = null)

Sign PKCS#1

Sign an array of hashes using PKCS#1 signatures. The hashes must be calculated with SHA-256, which is the only supported hash algorithm. Provide hashes in base64 format

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Abletech.Bix.SignService.Contract.Client.V1;
using Abletech.Bix.SignService.Contract.Client;
using Abletech.Bix.SignService.Contract.Model.V1;

namespace Example
{
    public class ApiV1MassiveSignSignPkcs1PostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "/SignService";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MassiveSignApi(Configuration.Default);
            var signPkcs1Request = new SignPkcs1Request(); // SignPkcs1Request |  (optional) 

            try
            {
                // Sign PKCS#1
                SignPkcs1Response result = apiInstance.ApiV1MassiveSignSignPkcs1Post(signPkcs1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MassiveSignApi.ApiV1MassiveSignSignPkcs1Post: " + e.Message );
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
 **signPkcs1Request** | [**SignPkcs1Request**](SignPkcs1Request.md)|  | [optional] 

### Return type

[**SignPkcs1Response**](SignPkcs1Response.md)

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

