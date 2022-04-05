# Flagr.Api.Api.TagApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTag**](TagApi.md#createtag) | **POST** /flags/{flagID}/tags | 
[**DeleteTag**](TagApi.md#deletetag) | **DELETE** /flags/{flagID}/tags/{tagID} | 
[**FindAllTags**](TagApi.md#findalltags) | **GET** /tags | 
[**FindTags**](TagApi.md#findtags) | **GET** /flags/{flagID}/tags | 


<a name="createtag"></a>
# **CreateTag**
> Tag CreateTag (long? flagID, CreateTagRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class CreateTagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var body = new CreateTagRequest(); // CreateTagRequest | create a tag

            try
            {
                Tag result = apiInstance.CreateTag(flagID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.CreateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **body** | [**CreateTagRequest**](CreateTagRequest.md)| create a tag | 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetag"></a>
# **DeleteTag**
> void DeleteTag (long? flagID, long? tagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var tagID = 789;  // long? | numeric ID of the tag

            try
            {
                apiInstance.DeleteTag(flagID, tagID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.DeleteTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **tagID** | **long?**| numeric ID of the tag | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findalltags"></a>
# **FindAllTags**
> List<Tag> FindAllTags (long? limit = null, long? offset = null, string valueLike = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindAllTagsExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var limit = 789;  // long? | the numbers of tags to return (optional) 
            var offset = 789;  // long? | return tags given the offset, it should usually set together with limit (optional) 
            var valueLike = valueLike_example;  // string | return tags partially matching given value (optional) 

            try
            {
                List&lt;Tag&gt; result = apiInstance.FindAllTags(limit, offset, valueLike);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.FindAllTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| the numbers of tags to return | [optional] 
 **offset** | **long?**| return tags given the offset, it should usually set together with limit | [optional] 
 **valueLike** | **string**| return tags partially matching given value | [optional] 

### Return type

[**List<Tag>**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtags"></a>
# **FindTags**
> List<Tag> FindTags (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindTagsExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var flagID = 789;  // long? | numeric ID of the flag

            try
            {
                List&lt;Tag&gt; result = apiInstance.FindTags(flagID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.FindTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 

### Return type

[**List<Tag>**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

