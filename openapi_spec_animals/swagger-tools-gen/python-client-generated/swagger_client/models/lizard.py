# coding: utf-8

"""
    IX-API

    No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)  # noqa: E501

    OpenAPI spec version: 0.0.1
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six
from swagger_client.models.pet import Pet  # noqa: F401,E501

class Lizard(Pet):
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
        'loves_rocks': 'bool'
    }
    if hasattr(Pet, "swagger_types"):
        swagger_types.update(Pet.swagger_types)

    attribute_map = {
        'loves_rocks': 'lovesRocks'
    }
    if hasattr(Pet, "attribute_map"):
        attribute_map.update(Pet.attribute_map)

    def __init__(self, loves_rocks=None, *args, **kwargs):  # noqa: E501
        """Lizard - a model defined in Swagger"""  # noqa: E501
        self._loves_rocks = None
        self.discriminator = None
        if loves_rocks is not None:
            self.loves_rocks = loves_rocks
        Pet.__init__(self, *args, **kwargs)

    @property
    def loves_rocks(self):
        """Gets the loves_rocks of this Lizard.  # noqa: E501


        :return: The loves_rocks of this Lizard.  # noqa: E501
        :rtype: bool
        """
        return self._loves_rocks

    @loves_rocks.setter
    def loves_rocks(self, loves_rocks):
        """Sets the loves_rocks of this Lizard.


        :param loves_rocks: The loves_rocks of this Lizard.  # noqa: E501
        :type: bool
        """

        self._loves_rocks = loves_rocks

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
        if issubclass(Lizard, dict):
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
        if not isinstance(other, Lizard):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
