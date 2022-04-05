# Flagr.Api.Api.ConstraintApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConstraint**](ConstraintApi.md#createconstraint) | **POST** /flags/{flagID}/segments/{segmentID}/constraints | 
[**DeleteConstraint**](ConstraintApi.md#deleteconstraint) | **DELETE** /flags/{flagID}/segments/{segmentID}/constraints/{constraintID} | 
[**FindConstraints**](ConstraintApi.md#findconstraints) | **GET** /flags/{flagID}/segments/{segmentID}/constraints | 
[**PutConstraint**](ConstraintApi.md#putconstraint) | **PUT** /flags/{flagID}/segments/{segmentID}/constraints/{constraintID} | 


<a name="createconstraint"></a>
# **CreateConstraint**
> Constraint CreateConstraint (long? flagID, long? segmentID, CreateConstraintRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class CreateConstraintExample
    {
        public void main()
        {
            var apiInstance = new ConstraintApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment
            var body = new CreateConstraintRequest(); // CreateConstraintRequest | create a constraint

            try
            {
                Constraint result = apiInstance.CreateConstraint(flagID, segmentID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConstraintApi.CreateConstraint: " + e.Message );
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
 **body** | [**CreateConstraintRequest**](CreateConstraintRequest.md)| create a constraint | 

### Return type

[**Constraint**](Constraint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconstraint"></a>
# **DeleteConstraint**
> void DeleteConstraint (long? flagID, long? segmentID, long? constraintID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class DeleteConstraintExample
    {
        public void main()
        {
            var apiInstance = new ConstraintApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment
            var constraintID = 789;  // long? | numeric ID of the constraint

            try
            {
                apiInstance.DeleteConstraint(flagID, segmentID, constraintID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConstraintApi.DeleteConstraint: " + e.Message );
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
 **constraintID** | **long?**| numeric ID of the constraint | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findconstraints"></a>
# **FindConstraints**
> List<Constraint> FindConstraints (long? flagID, long? segmentID)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class FindConstraintsExample
    {
        public void main()
        {
            var apiInstance = new ConstraintApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment

            try
            {
                List&lt;Constraint&gt; result = apiInstance.FindConstraints(flagID, segmentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConstraintApi.FindConstraints: " + e.Message );
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

[**List<Constraint>**](Constraint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putconstraint"></a>
# **PutConstraint**
> Constraint PutConstraint (long? flagID, long? segmentID, long? constraintID, CreateConstraintRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Flagr.Api.Api;
using Flagr.Api.Client;
using Flagr.Api.Model;

namespace Example
{
    public class PutConstraintExample
    {
        public void main()
        {
            var apiInstance = new ConstraintApi();
            var flagID = 789;  // long? | numeric ID of the flag
            var segmentID = 789;  // long? | numeric ID of the segment
            var constraintID = 789;  // long? | numeric ID of the constraint
            var body = new CreateConstraintRequest(); // CreateConstraintRequest | create a constraint

            try
            {
                Constraint result = apiInstance.PutConstraint(flagID, segmentID, constraintID, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConstraintApi.PutConstraint: " + e.Message );
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
 **constraintID** | **long?**| numeric ID of the constraint | 
 **body** | [**CreateConstraintRequest**](CreateConstraintRequest.md)| create a constraint | 

### Return type

[**Constraint**](Constraint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

