# Org.OpenAPITools.Model.ExchangeLanNetworkServicePartial
Exchange Lan Network Service
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsumingAccount** | **string** | The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;.  | [optional] 
**ExternalRef** | **string** | Reference field, free to use for the API user. | [optional] 
**Id** | **string** |  | [optional] 
**IxfdbIxid** | **int?** | id of ixfdb | [optional] 
**ManagingAccount** | **string** | The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities.  | [optional] 
**MetroAreaNetwork** | **string** | Id of the &#x60;MetroAreaNetwork&#x60; where the exchange lan network service is directly provided.  Same as &#x60;service_metro_area_network&#x60; on the related &#x60;ProductOffering&#x60;.  | [optional] 
**Name** | **string** | Exchange-dependent service name, will be shown on the invoice. | [optional] 
**NetworkFeatures** | **List&lt;string&gt;** |  | [optional] 
**NscRequiredContactRoles** | **List&lt;string&gt;** | The configuration will require at least one of each of the specified roles assigned to contacts.  The &#x60;RoleAssignment&#x60; is associated through the &#x60;role_assignments&#x60; list property of the network service configuration. | [optional] [readonly] 
**PeeringdbIxid** | **int?** | PeeringDB ixid | [optional] 
**ProductOffering** | **string** |  | [optional] 
**State** | **string** |  | [optional] 
**Status** | [**List&lt;Status&gt;**](Status.md) |  | [optional] 
**SubnetV4** | **string** | IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation.  | [optional] 
**SubnetV6** | **string** | IPv6 subnet in hexadecimal colon separated CIDR notation.  | [optional] 
**Type** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

