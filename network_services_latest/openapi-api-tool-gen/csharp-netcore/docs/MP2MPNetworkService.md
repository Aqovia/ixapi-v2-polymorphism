# Org.OpenAPITools.Model.MP2MPNetworkService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingAccount** | **string** | An account requires billing_information to be used as a &#x60;billing_account&#x60;. | [optional] 
**ChargedUntil** | **DateTime** | Your obligation to pay for the service will end on this date. Typically &#x60;≥ decommission_at&#x60;.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;. | [optional] 
**ConsumingAccount** | **string** | The &#x60;id&#x60; of the account consuming a service.  Used to be &#x60;owning_customer&#x60;.  | [optional] 
**ContractRef** | **string** | A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer.  | [optional] 
**DecommissionAt** | **DateTime** | The service will be decommissioned on this date.  This field is only used when the state is &#x60;DECOMMISSION_REQUESTED&#x60; or &#x60;DECOMMISSIONED&#x60;. | [optional] 
**ExternalRef** | **string** | Reference field, free to use for the API user. | [optional] 
**Id** | **string** |  | [optional] 
**ManagingAccount** | **string** | The &#x60;id&#x60; of the account responsible for managing the service via the API. A manager can read and update the state of entities.  | [optional] 
**MemberJoiningRules** | **List&lt;string&gt;** |  | [optional] 
**Name** | **string** | Name of the multi-point to multi-point virtual circuit. | [optional] 
**NetworkFeatures** | **List&lt;string&gt;** |  | [optional] 
**NscRequiredContactRoles** | **List&lt;string&gt;** | The configuration will require at least one of each of the specified roles assigned to contacts.  The &#x60;RoleAssignment&#x60; is associated through the &#x60;role_assignments&#x60; list property of the network service configuration. | [optional] [readonly] 
**ProductOffering** | **string** |  | [optional] 
**Public** | **bool** | A public mp2mp network service can be joined by everyone on the exchange unless denied by a member-joining-rule.  Public network services are visible to other members of the IXP, however only &#x60;name&#x60;, &#x60;type&#x60;, &#x60;product_offering&#x60;, &#x60;consuming_account&#x60; and &#x60;managing_account&#x60; are made available.  Other required fields are redacted. | [optional] [default to false]
**PurchaseOrder** | **string** | Purchase Order ID which will be displayed on the invoice.  | [optional] [default to ""]
**State** | **string** |  | [optional] 
**Status** | [**List&lt;Status&gt;**](Status.md) |  | [optional] 
**Type** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

