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

class VLanConfigQinQPartial(object):
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
        'inner_vlan': 'int',
        'outer_vlan': 'int',
        'outer_vlan_ethertype': 'str',
        'vlan_type': 'str'
    }

    attribute_map = {
        'inner_vlan': 'inner_vlan',
        'outer_vlan': 'outer_vlan',
        'outer_vlan_ethertype': 'outer_vlan_ethertype',
        'vlan_type': 'vlan_type'
    }

    def __init__(self, inner_vlan=None, outer_vlan=None, outer_vlan_ethertype='0x8100', vlan_type=None):  # noqa: E501
        """VLanConfigQinQPartial - a model defined in Swagger"""  # noqa: E501
        self._inner_vlan = None
        self._outer_vlan = None
        self._outer_vlan_ethertype = None
        self._vlan_type = None
        self.discriminator = None
        if inner_vlan is not None:
            self.inner_vlan = inner_vlan
        if outer_vlan is not None:
            self.outer_vlan = outer_vlan
        if outer_vlan_ethertype is not None:
            self.outer_vlan_ethertype = outer_vlan_ethertype
        self.vlan_type = vlan_type

    @property
    def inner_vlan(self):
        """Gets the inner_vlan of this VLanConfigQinQPartial.  # noqa: E501

        The inner VLAN id.   # noqa: E501

        :return: The inner_vlan of this VLanConfigQinQPartial.  # noqa: E501
        :rtype: int
        """
        return self._inner_vlan

    @inner_vlan.setter
    def inner_vlan(self, inner_vlan):
        """Sets the inner_vlan of this VLanConfigQinQPartial.

        The inner VLAN id.   # noqa: E501

        :param inner_vlan: The inner_vlan of this VLanConfigQinQPartial.  # noqa: E501
        :type: int
        """

        self._inner_vlan = inner_vlan

    @property
    def outer_vlan(self):
        """Gets the outer_vlan of this VLanConfigQinQPartial.  # noqa: E501

        The outer VLAN id. If `null`, the IXP will auto-select a valid vlan-id.   # noqa: E501

        :return: The outer_vlan of this VLanConfigQinQPartial.  # noqa: E501
        :rtype: int
        """
        return self._outer_vlan

    @outer_vlan.setter
    def outer_vlan(self, outer_vlan):
        """Sets the outer_vlan of this VLanConfigQinQPartial.

        The outer VLAN id. If `null`, the IXP will auto-select a valid vlan-id.   # noqa: E501

        :param outer_vlan: The outer_vlan of this VLanConfigQinQPartial.  # noqa: E501
        :type: int
        """

        self._outer_vlan = outer_vlan

    @property
    def outer_vlan_ethertype(self):
        """Gets the outer_vlan_ethertype of this VLanConfigQinQPartial.  # noqa: E501

        The ethertype of the outer tag in hexadecimal notation.  # noqa: E501

        :return: The outer_vlan_ethertype of this VLanConfigQinQPartial.  # noqa: E501
        :rtype: str
        """
        return self._outer_vlan_ethertype

    @outer_vlan_ethertype.setter
    def outer_vlan_ethertype(self, outer_vlan_ethertype):
        """Sets the outer_vlan_ethertype of this VLanConfigQinQPartial.

        The ethertype of the outer tag in hexadecimal notation.  # noqa: E501

        :param outer_vlan_ethertype: The outer_vlan_ethertype of this VLanConfigQinQPartial.  # noqa: E501
        :type: str
        """
        allowed_values = ["0x8100", "0x88a8", "0x9100"]  # noqa: E501
        if outer_vlan_ethertype not in allowed_values:
            raise ValueError(
                "Invalid value for `outer_vlan_ethertype` ({0}), must be one of {1}"  # noqa: E501
                .format(outer_vlan_ethertype, allowed_values)
            )

        self._outer_vlan_ethertype = outer_vlan_ethertype

    @property
    def vlan_type(self):
        """Gets the vlan_type of this VLanConfigQinQPartial.  # noqa: E501


        :return: The vlan_type of this VLanConfigQinQPartial.  # noqa: E501
        :rtype: str
        """
        return self._vlan_type

    @vlan_type.setter
    def vlan_type(self, vlan_type):
        """Sets the vlan_type of this VLanConfigQinQPartial.


        :param vlan_type: The vlan_type of this VLanConfigQinQPartial.  # noqa: E501
        :type: str
        """
        if vlan_type is None:
            raise ValueError("Invalid value for `vlan_type`, must not be `None`")  # noqa: E501

        self._vlan_type = vlan_type

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
        if issubclass(VLanConfigQinQPartial, dict):
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
        if not isinstance(other, VLanConfigQinQPartial):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other