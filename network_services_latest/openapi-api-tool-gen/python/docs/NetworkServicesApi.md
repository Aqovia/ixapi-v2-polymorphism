# openapi_client.NetworkServicesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**network_services_list**](NetworkServicesApi.md#network_services_list) | **GET** /network-services | 


# **network_services_list**
> list[NetworkService] network_services_list(id=id, state=state, state__is_not=state__is_not, managing_account=managing_account, consuming_account=consuming_account, external_ref=external_ref, type=type, pop=pop, product_offering=product_offering)



List available `NetworkService`s.

### Example

* Bearer (JWT) Authentication (Bearer):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to http://localhost/api/v2
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "http://localhost/api/v2"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (JWT): Bearer
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.NetworkServicesApi(api_client)
    id = ['id1,id2,id3'] # list[str] | Filter by id (optional)
state = 'state_example' # str | Filter by state (optional)
state__is_not = 'state__is_not_example' # str | Filter by state__is_not (optional)
managing_account = 'managing_account_example' # str | Filter by managing_account (optional)
consuming_account = 'consuming_account_example' # str | Filter by consuming_account (optional)
external_ref = 'external_ref_example' # str | Filter by external_ref (optional)
type = 'type_example' # str | Filter by type (optional)
pop = 'pop_example' # str | Filter by pop (optional)
product_offering = 'product_offering_example' # str | Filter by product_offering (optional)

    try:
        api_response = api_instance.network_services_list(id=id, state=state, state__is_not=state__is_not, managing_account=managing_account, consuming_account=consuming_account, external_ref=external_ref, type=type, pop=pop, product_offering=product_offering)
        pprint(api_response)
    except ApiException as e:
        print("Exception when calling NetworkServicesApi->network_services_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**list[str]**](str.md)| Filter by id | [optional] 
 **state** | **str**| Filter by state | [optional] 
 **state__is_not** | **str**| Filter by state__is_not | [optional] 
 **managing_account** | **str**| Filter by managing_account | [optional] 
 **consuming_account** | **str**| Filter by consuming_account | [optional] 
 **external_ref** | **str**| Filter by external_ref | [optional] 
 **type** | **str**| Filter by type | [optional] 
 **pop** | **str**| Filter by pop | [optional] 
 **product_offering** | **str**| Filter by product_offering | [optional] 

### Return type

[**list[NetworkService]**](NetworkService.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | List of: Polymorphic Network Services |  -  |
**400** | ValidationError |  -  |
**401** | Authentication |  -  |
**403** | PermissionDenied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

