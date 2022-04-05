# ExchangeLanNetworkServicePartial

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**consuming_account** | **str** | The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;.  | [optional] 
**external_ref** | **str** | Reference field, free to use for the API user. | [optional] 
**id** | **str** |  | [optional] 
**ixfdb_ixid** | **int** | id of ixfdb | [optional] 
**managing_account** | **str** | The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities.  | [optional] 
**metro_area_network** | **str** | Id of the &#x60;MetroAreaNetwork&#x60; where the exchange lan network service is directly provided.  Same as &#x60;service_metro_area_network&#x60; on the related &#x60;ProductOffering&#x60;.  | [optional] 
**name** | **str** | Exchange-dependent service name, will be shown on the invoice. | [optional] 
**network_features** | **list[str]** |  | [optional] 
**nsc_required_contact_roles** | **list[str]** | The configuration will require at least one of each of the specified roles assigned to contacts.  The &#x60;RoleAssignment&#x60; is associated through the &#x60;role_assignments&#x60; list property of the network service configuration. | [optional] 
**peeringdb_ixid** | **int** | PeeringDB ixid | [optional] 
**product_offering** | **str** |  | [optional] 
**state** | **str** |  | [optional] 
**status** | [**list[Status]**](Status.md) |  | [optional] 
**subnet_v4** | **str** | IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation.  | [optional] 
**subnet_v6** | **str** | IPv6 subnet in hexadecimal colon separated CIDR notation.  | [optional] 
**type** | **str** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

