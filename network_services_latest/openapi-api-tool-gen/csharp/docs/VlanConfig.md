
# Org.OpenAPITools.Model.VlanConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vlan** | **int?** | A VLAN tag. If &#x60;null&#x60;, the IXP will auto-select a valid vlan-id.  | [optional] 
**VlanEthertype** | **string** | The ethertype of the vlan in hexadecimal notation. | [optional] [default to VlanEthertypeEnum._0x8100]
**VlanType** | **string** |  | 
**InnerVlan** | **int** | The inner VLAN id.  | [optional] 
**OuterVlan** | **int?** | The outer VLAN id. If &#x60;null&#x60;, the IXP will auto-select a valid vlan-id.  | [optional] 
**OuterVlanEthertype** | **string** | The ethertype of the outer tag in hexadecimal notation. | [optional] [default to OuterVlanEthertypeEnum._0x8100]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

