# Flagr.Api.Api.FlagApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFlag**](FlagApi.md#createflag) | **POST** /flags | 
[**DeleteFlag**](FlagApi.md#deleteflag) | **DELETE** /flags/{flagID} | 
[**FindFlags**](FlagApi.md#findflags) | **GET** /flags | 
[**GetFlag**](FlagApi.md#getflag) | **GET** /flags/{flagID} | 
[**GetFlagEntityTypes**](FlagApi.md#getflagentitytypes) | **GET** /flags/entity_types | 
[**GetFlagSnapshots**](FlagApi.md#getflagsnapshots) | **GET** /flags/{flagID}/snapshots | 
[**PutFlag**](FlagApi.md#putflag) | **PUT** /flags/{flagID} | 
[**RestoreFlag**](FlagApi.md#restoreflag) | **PUT** /flags/{flagID}/restore | 
[**SetFlagEnabled**](FlagApi.md#setflagenabled) | **PUT** /flags/{flagID}/enabled | 


<a name="createflag"></a>
# **CreateFlag**
> Flag CreateFlag (CreateFlagRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class CreateFlagExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var body = new CreateFlagRequest(); // CreateFlagRequest | create a flag

            try
            {
                Flag result = apiInstance.CreateFlag(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.CreateFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateFlagRequest**](CreateFlagRequest.md)| create a flag | 

### Return type

[**Flag**](Flag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteflag"></a>
# **DeleteFlag**
> void DeleteFlag (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class DeleteFlagExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var flagID = 789;  // long? | numeric ID of the flag

            try
            {
                apiInstance.DeleteFlag(flagID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.DeleteFlag: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findflags"></a>
# **FindFlags**
> List<Flag> FindFlags (long? limit = null, bool? enabled = null, string description = null, string tags = null, string descriptionLike = null, string key = null, long? offset = null, bool? preload = null, bool? deleted = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindFlagsExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var limit = 789;  // long? | the numbers of flags to return (optional) 
            var enabled = true;  // bool? | return flags having given enabled status (optional) 
            var description = description_example;  // string | return flags exactly matching given description (optional) 
            var tags = tags_example;  // string | return flags with the given tags (comma separated) (optional) 
            var descriptionLike = descriptionLike_example;  // string | return flags partially matching given description (optional) 
            var key = key_example;  // string | return flags matching given key (optional) 
            var offset = 789;  // long? | return flags given the offset, it should usually set together with limit (optional) 
            var preload = true;  // bool? | return flags with preloaded segments and variants (optional) 
            var deleted = true;  // bool? | return all deleted flags (optional) 

            try
            {
                List&lt;Flag&gt; result = apiInstance.FindFlags(limit, enabled, description, tags, descriptionLike, key, offset, preload, deleted);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.FindFlags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| the numbers of flags to return | [optional] 
 **enabled** | **bool?**| return flags having given enabled status | [optional] 
 **description** | **string**| return flags exactly matching given description | [optional] 
 **tags** | **string**| return flags with the given tags (comma separated) | [optional] 
 **descriptionLike** | **string**| return flags partially matching given description | [optional] 
 **key** | **string**| return flags matching given key | [optional] 
 **offset** | **long?**| return flags given the offset, it should usually set together with limit | [optional] 
 **preload** | **bool?**| return flags with preloaded segments and variants | [optional] 
 **deleted** | **bool?**| return all deleted flags | [optional] 

### Return type

[**List<Flag>**](Flag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflag"></a>
# **GetFlag**
> Flag GetFlag (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class GetFlagExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var flagID = 789;  // long? | numeric ID of the flag to get

            try
            {
                Flag result = apiInstance.GetFlag(flagID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.GetFlag: " + e.Message );
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

[**Flag**](Flag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflagentitytypes"></a>
# **GetFlagEntityTypes**
> List<string> GetFlagEntityTypes ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class GetFlagEntityTypesExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetFlagEntityTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.GetFlagEntityTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflagsnapshots"></a>
# **GetFlagSnapshots**
> List<FlagSnapshot> GetFlagSnapshots (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class GetFlagSnapshotsExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var flagID = 789;  // long? | numeric ID of the flag to get

            try
            {
                List&lt;FlagSnapshot&gt; result = apiInstance.GetFlagSnapshots(flagID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.GetFlagSnapshots: " + e.Message );
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

[**List<FlagSnapshot>**](FlagSnapshot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putflag"></a>
# **PutFlag**
> Flag PutFlag (long? flagID, PutFlagRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PutFlagExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var flagID = 789;  // long? | numeric ID of the flag to get
            var body = new PutFlagRequest(); // PutFlagRequest | update a flag

            try
            {
                Flag result = apiInstance.PutFlag(flagID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.PutFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag to get | 
 **body** | [**PutFlagRequest**](PutFlagRequest.md)| update a flag | 

### Return type

[**Flag**](Flag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restoreflag"></a>
# **RestoreFlag**
> Flag RestoreFlag (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class RestoreFlagExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var flagID = 789;  // long? | numeric ID of the flag to get

            try
            {
                Flag result = apiInstance.RestoreFlag(flagID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.RestoreFlag: " + e.Message );
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

[**Flag**](Flag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setflagenabled"></a>
# **SetFlagEnabled**
> Flag SetFlagEnabled (long? flagID, SetFlagEnabledRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class SetFlagEnabledExample
    {
        public void main()
        {
            var apiInstance = new FlagApi();
            var flagID = 789;  // long? | numeric ID of the flag to get
            var body = new SetFlagEnabledRequest(); // SetFlagEnabledRequest | set flag enabled state

            try
            {
                Flag result = apiInstance.SetFlagEnabled(flagID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlagApi.SetFlagEnabled: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag to get | 
 **body** | [**SetFlagEnabledRequest**](SetFlagEnabledRequest.md)| set flag enabled state | 

### Return type

[**Flag**](Flag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

