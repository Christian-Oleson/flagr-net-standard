# Flagr.Api.Api.HealthApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHealth**](HealthApi.md#gethealth) | **GET** /health | 


<a name="gethealth"></a>
# **GetHealth**
> Health GetHealth ()



Check if Flagr is healthy

### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class GetHealthExample
    {
        public void main()
        {
            var apiInstance = new HealthApi();

            try
            {
                Health result = apiInstance.GetHealth();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.GetHealth: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Health**](Health.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

