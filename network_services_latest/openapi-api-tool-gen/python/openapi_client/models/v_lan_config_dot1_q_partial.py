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


class VLanConfigDot1QPartial(object):
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
        'vlan': 'int',
        'vlan_ethertype': 'str',
        'vlan_type': 'str'
    }

    attribute_map = {
        'vlan': 'vlan',
        'vlan_ethertype': 'vlan_ethertype',
        'vlan_type': 'vlan_type'
    }

    def __init__(self, vlan=None, vlan_ethertype='0x8100', vlan_type=None, local_vars_configuration=None):  # noqa: E501
        """VLanConfigDot1QPartial - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._vlan = None
        self._vlan_ethertype = None
        self._vlan_type = None
        self.discriminator = None

        self.vlan = vlan
        if vlan_ethertype is not None:
            self.vlan_ethertype = vlan_ethertype
        self.vlan_type = vlan_type

    @property
    def vlan(self):
        """Gets the vlan of this VLanConfigDot1QPartial.  # noqa: E501

        A VLAN tag. If `null`, the IXP will auto-select a valid vlan-id.   # noqa: E501

        :return: The vlan of this VLanConfigDot1QPartial.  # noqa: E501
        :rtype: int
        """
        return self._vlan

    @vlan.setter
    def vlan(self, vlan):
        """Sets the vlan of this VLanConfigDot1QPartial.

        A VLAN tag. If `null`, the IXP will auto-select a valid vlan-id.   # noqa: E501

        :param vlan: The vlan of this VLanConfigDot1QPartial.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                vlan is not None and vlan > 4094):  # noqa: E501
            raise ValueError("Invalid value for `vlan`, must be a value less than or equal to `4094`")  # noqa: E501
        if (self.local_vars_configuration.client_side_validation and
                vlan is not None and vlan < 1):  # noqa: E501
            raise ValueError("Invalid value for `vlan`, must be a value greater than or equal to `1`")  # noqa: E501

        self._vlan = vlan

    @property
    def vlan_ethertype(self):
        """Gets the vlan_ethertype of this VLanConfigDot1QPartial.  # noqa: E501

        The ethertype of the vlan in hexadecimal notation.  # noqa: E501

        :return: The vlan_ethertype of this VLanConfigDot1QPartial.  # noqa: E501
        :rtype: str
        """
        return self._vlan_ethertype

    @vlan_ethertype.setter
    def vlan_ethertype(self, vlan_ethertype):
        """Sets the vlan_ethertype of this VLanConfigDot1QPartial.

        The ethertype of the vlan in hexadecimal notation.  # noqa: E501

        :param vlan_ethertype: The vlan_ethertype of this VLanConfigDot1QPartial.  # noqa: E501
        :type: str
        """
        allowed_values = ["0x8100", "0x88a8", "0x9100"]  # noqa: E501
        if self.local_vars_configuration.client_side_validation and vlan_ethertype not in allowed_values:  # noqa: E501
            raise ValueError(
                "Invalid value for `vlan_ethertype` ({0}), must be one of {1}"  # noqa: E501
                .format(vlan_ethertype, allowed_values)
            )

        self._vlan_ethertype = vlan_ethertype

    @property
    def vlan_type(self):
        """Gets the vlan_type of this VLanConfigDot1QPartial.  # noqa: E501


        :return: The vlan_type of this VLanConfigDot1QPartial.  # noqa: E501
        :rtype: str
        """
        return self._vlan_type

    @vlan_type.setter
    def vlan_type(self, vlan_type):
        """Sets the vlan_type of this VLanConfigDot1QPartial.


        :param vlan_type: The vlan_type of this VLanConfigDot1QPartial.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and vlan_type is None:  # noqa: E501
            raise ValueError("Invalid value for `vlan_type`, must not be `None`")  # noqa: E501

        self._vlan_type = vlan_type

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
        if not isinstance(other, VLanConfigDot1QPartial):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, VLanConfigDot1QPartial):
            return True

        return self.to_dict() != other.to_dict()
