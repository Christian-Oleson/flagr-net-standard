# Flagr.Api.Api.SegmentApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSegment**](SegmentApi.md#createsegment) | **POST** /flags/{flagID}/segments | 
[**DeleteSegment**](SegmentApi.md#deletesegment) | **DELETE** /flags/{flagID}/segments/{segmentID} | 
[**FindSegments**](SegmentApi.md#findsegments) | **GET** /flags/{flagID}/segments | 
[**PutSegment**](SegmentApi.md#putsegment) | **PUT** /flags/{flagID}/segments/{segmentID} | 
[**PutSegmentsReorder**](SegmentApi.md#putsegmentsreorder) | **PUT** /flags/{flagID}/segments/reorder | 


<a name="createsegment"></a>
# **CreateSegment**
> Segment CreateSegment (long? flagID, CreateSegmentRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class CreateSegmentExample
    {
        public void main()
        {
            var apiInstance = new SegmentApi();
            var flagID = 789;  // long? | numeric ID of the flag to get
            var body = new CreateSegmentRequest(); // CreateSegmentRequest | create a segment under a flag

            try
            {
                Segment result = apiInstance.CreateSegment(flagID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentApi.CreateSegment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag to get | 
 **body** | [**CreateSegmentRequest**](CreateSegmentRequest.md)| create a segment under a flag | 

### Return type

[**Segment**](Segment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesegment"></a>
# **DeleteSegment**
> void DeleteSegment (long? flagID, long? segmentID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class DeleteSegmentExample
    {
        public void main()
        {
            var apiInstance = new SegmentApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment

            try
            {
                apiInstance.DeleteSegment(flagID, segmentID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentApi.DeleteSegment: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsegments"></a>
# **FindSegments**
> List<Segment> FindSegments (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindSegmentsExample
    {
        public void main()
        {
            var apiInstance = new SegmentApi();
            var flagID = 789;  // long? | numeric ID of the flag to get

            try
            {
                List&lt;Segment&gt; result = apiInstance.FindSegments(flagID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentApi.FindSegments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag to get | 

### Return type

[**List<Segment>**](Segment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsegment"></a>
# **PutSegment**
> Segment PutSegment (long? flagID, long? segmentID, PutSegmentRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PutSegmentExample
    {
        public void main()
        {
            var apiInstance = new SegmentApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment
            var body = new PutSegmentRequest(); // PutSegmentRequest | update a segment

            try
            {
                Segment result = apiInstance.PutSegment(flagID, segmentID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentApi.PutSegment: " + e.Message );
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
 **body** | [**PutSegmentRequest**](PutSegmentRequest.md)| update a segment | 

### Return type

[**Segment**](Segment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsegmentsreorder"></a>
# **PutSegmentsReorder**
> void PutSegmentsReorder (long? flagID, PutSegmentReorderRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PutSegmentsReorderExample
    {
        public void main()
        {
            var apiInstance = new SegmentApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var body = new PutSegmentReorderRequest(); // PutSegmentReorderRequest | reorder segments

            try
            {
                apiInstance.PutSegmentsReorder(flagID, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SegmentApi.PutSegmentsReorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **body** | [**PutSegmentReorderRequest**](PutSegmentReorderRequest.md)| reorder segments | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

