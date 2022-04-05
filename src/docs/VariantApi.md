# Flagr.Api.Api.VariantApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVariant**](VariantApi.md#createvariant) | **POST** /flags/{flagID}/variants | 
[**DeleteVariant**](VariantApi.md#deletevariant) | **DELETE** /flags/{flagID}/variants/{variantID} | 
[**FindVariants**](VariantApi.md#findvariants) | **GET** /flags/{flagID}/variants | 
[**PutVariant**](VariantApi.md#putvariant) | **PUT** /flags/{flagID}/variants/{variantID} | 


<a name="createvariant"></a>
# **CreateVariant**
> Variant CreateVariant (long? flagID, CreateVariantRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class CreateVariantExample
    {
        public void main()
        {
            var apiInstance = new VariantApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var body = new CreateVariantRequest(); // CreateVariantRequest | create a variant

            try
            {
                Variant result = apiInstance.CreateVariant(flagID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariantApi.CreateVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **body** | [**CreateVariantRequest**](CreateVariantRequest.md)| create a variant | 

### Return type

[**Variant**](Variant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevariant"></a>
# **DeleteVariant**
> void DeleteVariant (long? flagID, long? variantID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class DeleteVariantExample
    {
        public void main()
        {
            var apiInstance = new VariantApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var variantID = 789;  // long? | numeric ID of the variant

            try
            {
                apiInstance.DeleteVariant(flagID, variantID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariantApi.DeleteVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **variantID** | **long?**| numeric ID of the variant | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findvariants"></a>
# **FindVariants**
> List<Variant> FindVariants (long? flagID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindVariantsExample
    {
        public void main()
        {
            var apiInstance = new VariantApi();
            var flagID = 789;  // long? | numeric ID of the flag

            try
            {
                List&lt;Variant&gt; result = apiInstance.FindVariants(flagID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariantApi.FindVariants: " + e.Message );
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

[**List<Variant>**](Variant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putvariant"></a>
# **PutVariant**
> Variant PutVariant (long? flagID, long? variantID, PutVariantRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PutVariantExample
    {
        public void main()
        {
            var apiInstance = new VariantApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var variantID = 789;  // long? | numeric ID of the variant
            var body = new PutVariantRequest(); // PutVariantRequest | update a variant

            try
            {
                Variant result = apiInstance.PutVariant(flagID, variantID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariantApi.PutVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagID** | **long?**| numeric ID of the flag | 
 **variantID** | **long?**| numeric ID of the variant | 
 **body** | [**PutVariantRequest**](PutVariantRequest.md)| update a variant | 

### Return type

[**Variant**](Variant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

