# swagger_client.NetworkServicesApi

All URIs are relative to */api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**network_services_list**](NetworkServicesApi.md#network_services_list) | **GET** /network-services | 

# **network_services_list**
> list[NetworkService] network_services_list(id=id, state=state, state__is_not=state__is_not, managing_account=managing_account, consuming_account=consuming_account, external_ref=external_ref, type=type, pop=pop, product_offering=product_offering)



List available `NetworkService`s.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.NetworkServicesApi(swagger_client.ApiClient(configuration))
id = ['id_example'] # list[str] | Filter by id (optional)
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

