# coding: utf-8

"""
    IX-API

     This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error.   # noqa: E501

    The version of the OpenAPI document: 2.2.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class CloudNetworkServicePartial(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'billing_account': 'str',
        'capacity': 'int',
        'charged_until': 'date',
        'cloud_key': 'str',
        'consuming_account': 'str',
        'contract_ref': 'str',
        'decommission_at': 'date',
        'diversity': 'int',
        'external_ref': 'str',
        'id': 'str',
        'managing_account': 'str',
        'nsc_required_contact_roles': 'list[str]',
        'product_offering': 'str',
        'provider_ref': 'str',
        'purchase_order': 'str',
        'state': 'str',
        'status': 'list[Status]',
        'type': 'str'
    }

    attribute_map = {
        'billing_account': 'billing_account',
        'capacity': 'capacity',
        'charged_until': 'charged_until',
        'cloud_key': 'cloud_key',
        'consuming_account': 'consuming_account',
        'contract_ref': 'contract_ref',
        'decommission_at': 'decommission_at',
        'diversity': 'diversity',
        'external_ref': 'external_ref',
        'id': 'id',
        'managing_account': 'managing_account',
        'nsc_required_contact_roles': 'nsc_required_contact_roles',
        'product_offering': 'product_offering',
        'provider_ref': 'provider_ref',
        'purchase_order': 'purchase_order',
        'state': 'state',
        'status': 'status',
        'type': 'type'
    }

    def __init__(self, billing_account=None, capacity=None, charged_until=None, cloud_key=None, consuming_account=None, contract_ref=None, decommission_at=None, diversity=None, external_ref=None, id=None, managing_account=None, nsc_required_contact_roles=None, product_offering=None, provider_ref=None, purchase_order='', state=None, status=None, type=None, local_vars_configuration=None):  # noqa: E501
        """CloudNetworkServicePartial - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._billing_account = None
        self._capacity = None
        self._charged_until = None
        self._cloud_key = None
        self._consuming_account = None
        self._contract_ref = None
        self._decommission_at = None
        self._diversity = None
        self._external_ref = None
        self._id = None
        self._managing_account = None
        self._nsc_required_contact_roles = None
        self._product_offering = None
        self._provider_ref = None
        self._purchase_order = None
        self._state = None
        self._status = None
        self._type = None
        self.discriminator = None

        if billing_account is not None:
            self.billing_account = billing_account
        self.capacity = capacity
        if charged_until is not None:
            self.charged_until = charged_until
        if cloud_key is not None:
            self.cloud_key = cloud_key
        if consuming_account is not None:
            self.consuming_account = consuming_account
        self.contract_ref = contract_ref
        if decommission_at is not None:
            self.decommission_at = decommission_at
        if diversity is not None:
            self.diversity = diversity
        self.external_ref = external_ref
        if id is not None:
            self.id = id
        if managing_account is not None:
            self.managing_account = managing_account
        if nsc_required_contact_roles is not None:
            self.nsc_required_contact_roles = nsc_required_contact_roles
        if product_offering is not None:
            self.product_offering = product_offering
        self.provider_ref = provider_ref
        if purchase_order is not None:
            self.purchase_order = purchase_order
        if state is not None:
            self.state = state
        if status is not None:
            self.status = status
        self.type = type

    @property
    def billing_account(self):
        """Gets the billing_account of this CloudNetworkServicePartial.  # noqa: E501

        An account requires billing_information to be used as a `billing_account`.  # noqa: E501

        :return: The billing_account of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._billing_account

    @billing_account.setter
    def billing_account(self, billing_account):
        """Sets the billing_account of this CloudNetworkServicePartial.

        An account requires billing_information to be used as a `billing_account`.  # noqa: E501

        :param billing_account: The billing_account of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._billing_account = billing_account

    @property
    def capacity(self):
        """Gets the capacity of this CloudNetworkServicePartial.  # noqa: E501

        The capacity of the service in Mbps. When null, the maximum capacity will be used.  # noqa: E501

        :return: The capacity of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: int
        """
        return self._capacity

    @capacity.setter
    def capacity(self, capacity):
        """Sets the capacity of this CloudNetworkServicePartial.

        The capacity of the service in Mbps. When null, the maximum capacity will be used.  # noqa: E501

        :param capacity: The capacity of this CloudNetworkServicePartial.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                capacity is not None and capacity < 1):  # noqa: E501
            raise ValueError("Invalid value for `capacity`, must be a value greater than or equal to `1`")  # noqa: E501

        self._capacity = capacity

    @property
    def charged_until(self):
        """Gets the charged_until of this CloudNetworkServicePartial.  # noqa: E501

        Your obligation to pay for the service will end on this date. Typically `≥ decommission_at`.  This field is only used when the state is `DECOMMISSION_REQUESTED` or `DECOMMISSIONED`.  # noqa: E501

        :return: The charged_until of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: date
        """
        return self._charged_until

    @charged_until.setter
    def charged_until(self, charged_until):
        """Sets the charged_until of this CloudNetworkServicePartial.

        Your obligation to pay for the service will end on this date. Typically `≥ decommission_at`.  This field is only used when the state is `DECOMMISSION_REQUESTED` or `DECOMMISSIONED`.  # noqa: E501

        :param charged_until: The charged_until of this CloudNetworkServicePartial.  # noqa: E501
        :type: date
        """

        self._charged_until = charged_until

    @property
    def cloud_key(self):
        """Gets the cloud_key of this CloudNetworkServicePartial.  # noqa: E501


        :return: The cloud_key of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._cloud_key

    @cloud_key.setter
    def cloud_key(self, cloud_key):
        """Sets the cloud_key of this CloudNetworkServicePartial.


        :param cloud_key: The cloud_key of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._cloud_key = cloud_key

    @property
    def consuming_account(self):
        """Gets the consuming_account of this CloudNetworkServicePartial.  # noqa: E501

        The `id` of the account consuming a service.  Used to be `owning_customer`.   # noqa: E501

        :return: The consuming_account of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._consuming_account

    @consuming_account.setter
    def consuming_account(self, consuming_account):
        """Sets the consuming_account of this CloudNetworkServicePartial.

        The `id` of the account consuming a service.  Used to be `owning_customer`.   # noqa: E501

        :param consuming_account: The consuming_account of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._consuming_account = consuming_account

    @property
    def contract_ref(self):
        """Gets the contract_ref of this CloudNetworkServicePartial.  # noqa: E501

        A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer.   # noqa: E501

        :return: The contract_ref of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._contract_ref

    @contract_ref.setter
    def contract_ref(self, contract_ref):
        """Sets the contract_ref of this CloudNetworkServicePartial.

        A reference to a contract. If no specific contract is used, a default MAY be chosen by the implementer.   # noqa: E501

        :param contract_ref: The contract_ref of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """
        if (self.local_vars_configuration.client_side_validation and
                contract_ref is not None and len(contract_ref) > 128):
            raise ValueError("Invalid value for `contract_ref`, length must be less than or equal to `128`")  # noqa: E501

        self._contract_ref = contract_ref

    @property
    def decommission_at(self):
        """Gets the decommission_at of this CloudNetworkServicePartial.  # noqa: E501

        The service will be decommissioned on this date.  This field is only used when the state is `DECOMMISSION_REQUESTED` or `DECOMMISSIONED`.  # noqa: E501

        :return: The decommission_at of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: date
        """
        return self._decommission_at

    @decommission_at.setter
    def decommission_at(self, decommission_at):
        """Sets the decommission_at of this CloudNetworkServicePartial.

        The service will be decommissioned on this date.  This field is only used when the state is `DECOMMISSION_REQUESTED` or `DECOMMISSIONED`.  # noqa: E501

        :param decommission_at: The decommission_at of this CloudNetworkServicePartial.  # noqa: E501
        :type: date
        """

        self._decommission_at = decommission_at

    @property
    def diversity(self):
        """Gets the diversity of this CloudNetworkServicePartial.  # noqa: E501

        Same value as the corresponding `ProductOffering`.  The service can be delivered over multiple handovers from the exchange to the `service_provider`.  The `diversity` denotes the number of handovers between the exchange and the service provider. A value of two signals a redundant service.  Only one network service configuration for each `handover` and `cloud_vlan` can be created.  # noqa: E501

        :return: The diversity of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: int
        """
        return self._diversity

    @diversity.setter
    def diversity(self, diversity):
        """Sets the diversity of this CloudNetworkServicePartial.

        Same value as the corresponding `ProductOffering`.  The service can be delivered over multiple handovers from the exchange to the `service_provider`.  The `diversity` denotes the number of handovers between the exchange and the service provider. A value of two signals a redundant service.  Only one network service configuration for each `handover` and `cloud_vlan` can be created.  # noqa: E501

        :param diversity: The diversity of this CloudNetworkServicePartial.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                diversity is not None and diversity < 1):  # noqa: E501
            raise ValueError("Invalid value for `diversity`, must be a value greater than or equal to `1`")  # noqa: E501

        self._diversity = diversity

    @property
    def external_ref(self):
        """Gets the external_ref of this CloudNetworkServicePartial.  # noqa: E501

        Reference field, free to use for the API user.  # noqa: E501

        :return: The external_ref of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._external_ref

    @external_ref.setter
    def external_ref(self, external_ref):
        """Sets the external_ref of this CloudNetworkServicePartial.

        Reference field, free to use for the API user.  # noqa: E501

        :param external_ref: The external_ref of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """
        if (self.local_vars_configuration.client_side_validation and
                external_ref is not None and len(external_ref) > 128):
            raise ValueError("Invalid value for `external_ref`, length must be less than or equal to `128`")  # noqa: E501

        self._external_ref = external_ref

    @property
    def id(self):
        """Gets the id of this CloudNetworkServicePartial.  # noqa: E501


        :return: The id of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this CloudNetworkServicePartial.


        :param id: The id of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._id = id

    @property
    def managing_account(self):
        """Gets the managing_account of this CloudNetworkServicePartial.  # noqa: E501

        The `id` of the account responsible for managing the service via the API. A manager can read and update the state of entities.   # noqa: E501

        :return: The managing_account of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._managing_account

    @managing_account.setter
    def managing_account(self, managing_account):
        """Sets the managing_account of this CloudNetworkServicePartial.

        The `id` of the account responsible for managing the service via the API. A manager can read and update the state of entities.   # noqa: E501

        :param managing_account: The managing_account of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._managing_account = managing_account

    @property
    def nsc_required_contact_roles(self):
        """Gets the nsc_required_contact_roles of this CloudNetworkServicePartial.  # noqa: E501

        The configuration will require at least one of each of the specified roles assigned to contacts.  The `RoleAssignment` is associated through the `role_assignments` list property of the network service configuration.  # noqa: E501

        :return: The nsc_required_contact_roles of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: list[str]
        """
        return self._nsc_required_contact_roles

    @nsc_required_contact_roles.setter
    def nsc_required_contact_roles(self, nsc_required_contact_roles):
        """Sets the nsc_required_contact_roles of this CloudNetworkServicePartial.

        The configuration will require at least one of each of the specified roles assigned to contacts.  The `RoleAssignment` is associated through the `role_assignments` list property of the network service configuration.  # noqa: E501

        :param nsc_required_contact_roles: The nsc_required_contact_roles of this CloudNetworkServicePartial.  # noqa: E501
        :type: list[str]
        """

        self._nsc_required_contact_roles = nsc_required_contact_roles

    @property
    def product_offering(self):
        """Gets the product_offering of this CloudNetworkServicePartial.  # noqa: E501


        :return: The product_offering of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._product_offering

    @product_offering.setter
    def product_offering(self, product_offering):
        """Sets the product_offering of this CloudNetworkServicePartial.


        :param product_offering: The product_offering of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._product_offering = product_offering

    @property
    def provider_ref(self):
        """Gets the provider_ref of this CloudNetworkServicePartial.  # noqa: E501

        For a cloud network service with the exchange first workflow, the `provider_ref` will be a reference to a resource of the cloud provider. (E.g. the UUID of a virtual circuit.)  The `provider_ref` is managed by the exchange and its meaning may vary between different cloud services.   # noqa: E501

        :return: The provider_ref of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._provider_ref

    @provider_ref.setter
    def provider_ref(self, provider_ref):
        """Sets the provider_ref of this CloudNetworkServicePartial.

        For a cloud network service with the exchange first workflow, the `provider_ref` will be a reference to a resource of the cloud provider. (E.g. the UUID of a virtual circuit.)  The `provider_ref` is managed by the exchange and its meaning may vary between different cloud services.   # noqa: E501

        :param provider_ref: The provider_ref of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._provider_ref = provider_ref

    @property
    def purchase_order(self):
        """Gets the purchase_order of this CloudNetworkServicePartial.  # noqa: E501

        Purchase Order ID which will be displayed on the invoice.   # noqa: E501

        :return: The purchase_order of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._purchase_order

    @purchase_order.setter
    def purchase_order(self, purchase_order):
        """Sets the purchase_order of this CloudNetworkServicePartial.

        Purchase Order ID which will be displayed on the invoice.   # noqa: E501

        :param purchase_order: The purchase_order of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """
        if (self.local_vars_configuration.client_side_validation and
                purchase_order is not None and len(purchase_order) > 80):
            raise ValueError("Invalid value for `purchase_order`, length must be less than or equal to `80`")  # noqa: E501

        self._purchase_order = purchase_order

    @property
    def state(self):
        """Gets the state of this CloudNetworkServicePartial.  # noqa: E501


        :return: The state of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._state

    @state.setter
    def state(self, state):
        """Sets the state of this CloudNetworkServicePartial.


        :param state: The state of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """
        allowed_values = ["requested", "allocated", "testing", "production", "production_change_pending", "decommission_requested", "decommissioned", "archived", "error", "operator", "scheduled", "cancelled"]  # noqa: E501
        if self.local_vars_configuration.client_side_validation and state not in allowed_values:  # noqa: E501
            raise ValueError(
                "Invalid value for `state` ({0}), must be one of {1}"  # noqa: E501
                .format(state, allowed_values)
            )

        self._state = state

    @property
    def status(self):
        """Gets the status of this CloudNetworkServicePartial.  # noqa: E501


        :return: The status of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: list[Status]
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this CloudNetworkServicePartial.


        :param status: The status of this CloudNetworkServicePartial.  # noqa: E501
        :type: list[Status]
        """

        self._status = status

    @property
    def type(self):
        """Gets the type of this CloudNetworkServicePartial.  # noqa: E501


        :return: The type of this CloudNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this CloudNetworkServicePartial.


        :param type: The type of this CloudNetworkServicePartial.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and type is None:  # noqa: E501
            raise ValueError("Invalid value for `type`, must not be `None`")  # noqa: E501

        self._type = type

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, CloudNetworkServicePartial):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, CloudNetworkServicePartial):
            return True

        return self.to_dict() != other.to_dict()
