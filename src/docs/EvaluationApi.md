# Flagr.Api.Api.EvaluationApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostEvaluation**](EvaluationApi.md#postevaluation) | **POST** /evaluation | 
[**PostEvaluationBatch**](EvaluationApi.md#postevaluationbatch) | **POST** /evaluation/batch | 


<a name="postevaluation"></a>
# **PostEvaluation**
> EvalResult PostEvaluation (EvalContext body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PostEvaluationExample
    {
        public void main()
        {
            var apiInstance = new EvaluationApi();
            var body = new EvalContext(); // EvalContext | evalution context

            try
            {
                EvalResult result = apiInstance.PostEvaluation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvaluationApi.PostEvaluation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvalContext**](EvalContext.md)| evalution context | 

### Return type

[**EvalResult**](EvalResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postevaluationbatch"></a>
# **PostEvaluationBatch**
> EvaluationBatchResponse PostEvaluationBatch (EvaluationBatchRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PostEvaluationBatchExample
    {
        public void main()
        {
            var apiInstance = new EvaluationApi();
            var body = new EvaluationBatchRequest(); // EvaluationBatchRequest | evalution batch request

            try
            {
                EvaluationBatchResponse result = apiInstance.PostEvaluationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvaluationApi.PostEvaluationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvaluationBatchRequest**](EvaluationBatchRequest.md)| evalution batch request | 

### Return type

[**EvaluationBatchResponse**](EvaluationBatchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

