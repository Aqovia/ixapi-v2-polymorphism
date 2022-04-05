# coding: utf-8

"""
    IX-API

     This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error.   # noqa: E501

    OpenAPI spec version: 2.2.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ExchangeLanNetworkServicePartial(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'consuming_account': 'str',
        'external_ref': 'str',
        'id': 'str',
        'ixfdb_ixid': 'int',
        'managing_account': 'str',
        'metro_area_network': 'str',
        'name': 'str',
        'network_features': 'list[str]',
        'nsc_required_contact_roles': 'list[str]',
        'peeringdb_ixid': 'int',
        'product_offering': 'str',
        'state': 'str',
        'status': 'list[Status]',
        'subnet_v4': 'str',
        'subnet_v6': 'str',
        'type': 'str'
    }

    attribute_map = {
        'consuming_account': 'consuming_account',
        'external_ref': 'external_ref',
        'id': 'id',
        'ixfdb_ixid': 'ixfdb_ixid',
        'managing_account': 'managing_account',
        'metro_area_network': 'metro_area_network',
        'name': 'name',
        'network_features': 'network_features',
        'nsc_required_contact_roles': 'nsc_required_contact_roles',
        'peeringdb_ixid': 'peeringdb_ixid',
        'product_offering': 'product_offering',
        'state': 'state',
        'status': 'status',
        'subnet_v4': 'subnet_v4',
        'subnet_v6': 'subnet_v6',
        'type': 'type'
    }

    def __init__(self, consuming_account=None, external_ref=None, id=None, ixfdb_ixid=None, managing_account=None, metro_area_network=None, name=None, network_features=None, nsc_required_contact_roles=None, peeringdb_ixid=None, product_offering=None, state=None, status=None, subnet_v4=None, subnet_v6=None, type=None):  # noqa: E501
        """ExchangeLanNetworkServicePartial - a model defined in Swagger"""  # noqa: E501
        self._consuming_account = None
        self._external_ref = None
        self._id = None
        self._ixfdb_ixid = None
        self._managing_account = None
        self._metro_area_network = None
        self._name = None
        self._network_features = None
        self._nsc_required_contact_roles = None
        self._peeringdb_ixid = None
        self._product_offering = None
        self._state = None
        self._status = None
        self._subnet_v4 = None
        self._subnet_v6 = None
        self._type = None
        self.discriminator = None
        if consuming_account is not None:
            self.consuming_account = consuming_account
        if external_ref is not None:
            self.external_ref = external_ref
        if id is not None:
            self.id = id
        if ixfdb_ixid is not None:
            self.ixfdb_ixid = ixfdb_ixid
        if managing_account is not None:
            self.managing_account = managing_account
        if metro_area_network is not None:
            self.metro_area_network = metro_area_network
        if name is not None:
            self.name = name
        if network_features is not None:
            self.network_features = network_features
        if nsc_required_contact_roles is not None:
            self.nsc_required_contact_roles = nsc_required_contact_roles
        if peeringdb_ixid is not None:
            self.peeringdb_ixid = peeringdb_ixid
        if product_offering is not None:
            self.product_offering = product_offering
        if state is not None:
            self.state = state
        if status is not None:
            self.status = status
        if subnet_v4 is not None:
            self.subnet_v4 = subnet_v4
        if subnet_v6 is not None:
            self.subnet_v6 = subnet_v6
        self.type = type

    @property
    def consuming_account(self):
        """Gets the consuming_account of this ExchangeLanNetworkServicePartial.  # noqa: E501

        The `id` of the account consuming a service.  Used to be `owning_customer`.   # noqa: E501

        :return: The consuming_account of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._consuming_account

    @consuming_account.setter
    def consuming_account(self, consuming_account):
        """Sets the consuming_account of this ExchangeLanNetworkServicePartial.

        The `id` of the account consuming a service.  Used to be `owning_customer`.   # noqa: E501

        :param consuming_account: The consuming_account of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._consuming_account = consuming_account

    @property
    def external_ref(self):
        """Gets the external_ref of this ExchangeLanNetworkServicePartial.  # noqa: E501

        Reference field, free to use for the API user.  # noqa: E501

        :return: The external_ref of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._external_ref

    @external_ref.setter
    def external_ref(self, external_ref):
        """Sets the external_ref of this ExchangeLanNetworkServicePartial.

        Reference field, free to use for the API user.  # noqa: E501

        :param external_ref: The external_ref of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._external_ref = external_ref

    @property
    def id(self):
        """Gets the id of this ExchangeLanNetworkServicePartial.  # noqa: E501


        :return: The id of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this ExchangeLanNetworkServicePartial.


        :param id: The id of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._id = id

    @property
    def ixfdb_ixid(self):
        """Gets the ixfdb_ixid of this ExchangeLanNetworkServicePartial.  # noqa: E501

        id of ixfdb  # noqa: E501

        :return: The ixfdb_ixid of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: int
        """
        return self._ixfdb_ixid

    @ixfdb_ixid.setter
    def ixfdb_ixid(self, ixfdb_ixid):
        """Sets the ixfdb_ixid of this ExchangeLanNetworkServicePartial.

        id of ixfdb  # noqa: E501

        :param ixfdb_ixid: The ixfdb_ixid of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: int
        """

        self._ixfdb_ixid = ixfdb_ixid

    @property
    def managing_account(self):
        """Gets the managing_account of this ExchangeLanNetworkServicePartial.  # noqa: E501

        The `id` of the account responsible for managing the service via the API. A manager can read and update the state of entities.   # noqa: E501

        :return: The managing_account of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._managing_account

    @managing_account.setter
    def managing_account(self, managing_account):
        """Sets the managing_account of this ExchangeLanNetworkServicePartial.

        The `id` of the account responsible for managing the service via the API. A manager can read and update the state of entities.   # noqa: E501

        :param managing_account: The managing_account of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._managing_account = managing_account

    @property
    def metro_area_network(self):
        """Gets the metro_area_network of this ExchangeLanNetworkServicePartial.  # noqa: E501

        Id of the `MetroAreaNetwork` where the exchange lan network service is directly provided.  Same as `service_metro_area_network` on the related `ProductOffering`.   # noqa: E501

        :return: The metro_area_network of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._metro_area_network

    @metro_area_network.setter
    def metro_area_network(self, metro_area_network):
        """Sets the metro_area_network of this ExchangeLanNetworkServicePartial.

        Id of the `MetroAreaNetwork` where the exchange lan network service is directly provided.  Same as `service_metro_area_network` on the related `ProductOffering`.   # noqa: E501

        :param metro_area_network: The metro_area_network of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._metro_area_network = metro_area_network

    @property
    def name(self):
        """Gets the name of this ExchangeLanNetworkServicePartial.  # noqa: E501

        Exchange-dependent service name, will be shown on the invoice.  # noqa: E501

        :return: The name of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this ExchangeLanNetworkServicePartial.

        Exchange-dependent service name, will be shown on the invoice.  # noqa: E501

        :param name: The name of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def network_features(self):
        """Gets the network_features of this ExchangeLanNetworkServicePartial.  # noqa: E501


        :return: The network_features of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: list[str]
        """
        return self._network_features

    @network_features.setter
    def network_features(self, network_features):
        """Sets the network_features of this ExchangeLanNetworkServicePartial.


        :param network_features: The network_features of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: list[str]
        """

        self._network_features = network_features

    @property
    def nsc_required_contact_roles(self):
        """Gets the nsc_required_contact_roles of this ExchangeLanNetworkServicePartial.  # noqa: E501

        The configuration will require at least one of each of the specified roles assigned to contacts.  The `RoleAssignment` is associated through the `role_assignments` list property of the network service configuration.  # noqa: E501

        :return: The nsc_required_contact_roles of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: list[str]
        """
        return self._nsc_required_contact_roles

    @nsc_required_contact_roles.setter
    def nsc_required_contact_roles(self, nsc_required_contact_roles):
        """Sets the nsc_required_contact_roles of this ExchangeLanNetworkServicePartial.

        The configuration will require at least one of each of the specified roles assigned to contacts.  The `RoleAssignment` is associated through the `role_assignments` list property of the network service configuration.  # noqa: E501

        :param nsc_required_contact_roles: The nsc_required_contact_roles of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: list[str]
        """

        self._nsc_required_contact_roles = nsc_required_contact_roles

    @property
    def peeringdb_ixid(self):
        """Gets the peeringdb_ixid of this ExchangeLanNetworkServicePartial.  # noqa: E501

        PeeringDB ixid  # noqa: E501

        :return: The peeringdb_ixid of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: int
        """
        return self._peeringdb_ixid

    @peeringdb_ixid.setter
    def peeringdb_ixid(self, peeringdb_ixid):
        """Sets the peeringdb_ixid of this ExchangeLanNetworkServicePartial.

        PeeringDB ixid  # noqa: E501

        :param peeringdb_ixid: The peeringdb_ixid of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: int
        """

        self._peeringdb_ixid = peeringdb_ixid

    @property
    def product_offering(self):
        """Gets the product_offering of this ExchangeLanNetworkServicePartial.  # noqa: E501


        :return: The product_offering of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._product_offering

    @product_offering.setter
    def product_offering(self, product_offering):
        """Sets the product_offering of this ExchangeLanNetworkServicePartial.


        :param product_offering: The product_offering of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._product_offering = product_offering

    @property
    def state(self):
        """Gets the state of this ExchangeLanNetworkServicePartial.  # noqa: E501


        :return: The state of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._state

    @state.setter
    def state(self, state):
        """Sets the state of this ExchangeLanNetworkServicePartial.


        :param state: The state of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """
        allowed_values = ["requested", "allocated", "testing", "production", "production_change_pending", "decommission_requested", "decommissioned", "archived", "error", "operator", "scheduled", "cancelled"]  # noqa: E501
        if state not in allowed_values:
            raise ValueError(
                "Invalid value for `state` ({0}), must be one of {1}"  # noqa: E501
                .format(state, allowed_values)
            )

        self._state = state

    @property
    def status(self):
        """Gets the status of this ExchangeLanNetworkServicePartial.  # noqa: E501


        :return: The status of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: list[Status]
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this ExchangeLanNetworkServicePartial.


        :param status: The status of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: list[Status]
        """

        self._status = status

    @property
    def subnet_v4(self):
        """Gets the subnet_v4 of this ExchangeLanNetworkServicePartial.  # noqa: E501

        IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation.   # noqa: E501

        :return: The subnet_v4 of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._subnet_v4

    @subnet_v4.setter
    def subnet_v4(self, subnet_v4):
        """Sets the subnet_v4 of this ExchangeLanNetworkServicePartial.

        IPv4 subnet in [dot-decimal notation](https://en.wikipedia.org/wiki/Dot-decimal_notation) CIDR notation.   # noqa: E501

        :param subnet_v4: The subnet_v4 of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._subnet_v4 = subnet_v4

    @property
    def subnet_v6(self):
        """Gets the subnet_v6 of this ExchangeLanNetworkServicePartial.  # noqa: E501

        IPv6 subnet in hexadecimal colon separated CIDR notation.   # noqa: E501

        :return: The subnet_v6 of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._subnet_v6

    @subnet_v6.setter
    def subnet_v6(self, subnet_v6):
        """Sets the subnet_v6 of this ExchangeLanNetworkServicePartial.

        IPv6 subnet in hexadecimal colon separated CIDR notation.   # noqa: E501

        :param subnet_v6: The subnet_v6 of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """

        self._subnet_v6 = subnet_v6

    @property
    def type(self):
        """Gets the type of this ExchangeLanNetworkServicePartial.  # noqa: E501


        :return: The type of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this ExchangeLanNetworkServicePartial.


        :param type: The type of this ExchangeLanNetworkServicePartial.  # noqa: E501
        :type: str
        """
        if type is None:
            raise ValueError("Invalid value for `type`, must not be `None`")  # noqa: E501

        self._type = type

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
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
        if issubclass(ExchangeLanNetworkServicePartial, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ExchangeLanNetworkServicePartial):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other