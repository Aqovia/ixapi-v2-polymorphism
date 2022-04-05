# Org.OpenAPITools.Api.NetworkServicesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NetworkServicesList**](NetworkServicesApi.md#networkserviceslist) | **GET** /network-services | 



## NetworkServicesList

> List&lt;NetworkService&gt; NetworkServicesList (List<string> id = null, string state = null, string stateIsNot = null, string managingAccount = null, string consumingAccount = null, string externalRef = null, string type = null, string pop = null, string productOffering = null)



List available `NetworkService`s.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NetworkServicesListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v2";
            // Configure HTTP bearer authorization: Bearer
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NetworkServicesApi(Configuration.Default);
            var id = new List<string>(); // List<string> | Filter by id (optional) 
            var state = state_example;  // string | Filter by state (optional) 
            var stateIsNot = stateIsNot_example;  // string | Filter by state__is_not (optional) 
            var managingAccount = managingAccount_example;  // string | Filter by managing_account (optional) 
            var consumingAccount = consumingAccount_example;  // string | Filter by consuming_account (optional) 
            var externalRef = externalRef_example;  // string | Filter by external_ref (optional) 
            var type = type_example;  // string | Filter by type (optional) 
            var pop = pop_example;  // string | Filter by pop (optional) 
            var productOffering = productOffering_example;  // string | Filter by product_offering (optional) 

            try
            {
                List<NetworkService> result = apiInstance.NetworkServicesList(id, state, stateIsNot, managingAccount, consumingAccount, externalRef, type, pop, productOffering);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NetworkServicesApi.NetworkServicesList: " + e.Message );
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
 **id** | [**List&lt;string&gt;**](string.md)| Filter by id | [optional] 
 **state** | **string**| Filter by state | [optional] 
 **stateIsNot** | **string**| Filter by state__is_not | [optional] 
 **managingAccount** | **string**| Filter by managing_account | [optional] 
 **consumingAccount** | **string**| Filter by consuming_account | [optional] 
 **externalRef** | **string**| Filter by external_ref | [optional] 
 **type** | **string**| Filter by type | [optional] 
 **pop** | **string**| Filter by pop | [optional] 
 **productOffering** | **string**| Filter by product_offering | [optional] 

### Return type

[**List&lt;NetworkService&gt;**](NetworkService.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of: Polymorphic Network Services |  -  |
| **400** | ValidationError |  -  |
| **401** | Authentication |  -  |
| **403** | PermissionDenied |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

