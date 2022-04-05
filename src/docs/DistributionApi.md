# Flagr.Api.Api.DistributionApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindDistributions**](DistributionApi.md#finddistributions) | **GET** /flags/{flagID}/segments/{segmentID}/distributions | 
[**PutDistributions**](DistributionApi.md#putdistributions) | **PUT** /flags/{flagID}/segments/{segmentID}/distributions | 


<a name="finddistributions"></a>
# **FindDistributions**
> List<Distribution> FindDistributions (long? flagID, long? segmentID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindDistributionsExample
    {
        public void main()
        {
            var apiInstance = new DistributionApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment

            try
            {
                List&lt;Distribution&gt; result = apiInstance.FindDistributions(flagID, segmentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributionApi.FindDistributions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **segmentID** | **long?**| numeric ID of the segment | 

### Return type

[**List<Distribution>**](Distribution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdistributions"></a>
# **PutDistributions**
> List<Distribution> PutDistributions (long? flagID, long? segmentID, PutDistributionsRequest body)



replace the distribution with the new setting

### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PutDistributionsExample
    {
        public void main()
        {
            var apiInstance = new DistributionApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment
            var body = new PutDistributionsRequest(); // PutDistributionsRequest | array of distributions

            try
            {
                List&lt;Distribution&gt; result = apiInstance.PutDistributions(flagID, segmentID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DistributionApi.PutDistributions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **segmentID** | **long?**| numeric ID of the segment | 
 **body** | [**PutDistributionsRequest**](PutDistributionsRequest.md)| array of distributions | 

### Return type

[**List<Distribution>**](Distribution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

