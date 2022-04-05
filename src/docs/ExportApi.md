# Flagr.Api.Api.ExportApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExportEvalCacheJSON**](ExportApi.md#getexportevalcachejson) | **GET** /export/eval_cache/json | 
[**GetExportSqlite**](ExportApi.md#getexportsqlite) | **GET** /export/sqlite | 


<a name="getexportevalcachejson"></a>
# **GetExportEvalCacheJSON**
> Object GetExportEvalCacheJSON ()



Export JSON format of the eval cache dump

### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class GetExportEvalCacheJSONExample
    {
        public void main()
        {
            var apiInstance = new ExportApi();

            try
            {
                Object result = apiInstance.GetExportEvalCacheJSON();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.GetExportEvalCacheJSON: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexportsqlite"></a>
# **GetExportSqlite**
> System.IO.Stream GetExportSqlite (bool? excludeSnapshots = null)



Export sqlite3 format of the db dump, which is converted from the main database.

### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class GetExportSqliteExample
    {
        public void main()
        {
            var apiInstance = new ExportApi();
            var excludeSnapshots = true;  // bool? | export without snapshots data - useful for smaller db without snapshots  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.GetExportSqlite(excludeSnapshots);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.GetExportSqlite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSnapshots** | **bool?**| export without snapshots data - useful for smaller db without snapshots  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

