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
from swagger_client.models.problem_response import ProblemResponse  # noqa: F401,E501

class InlineResponse403(ProblemResponse):
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
        'status': 'object',
        'title': 'object',
        'type': 'str'
    }
    if hasattr(ProblemResponse, "swagger_types"):
        swagger_types.update(ProblemResponse.swagger_types)

    attribute_map = {
        'status': 'status',
        'title': 'title',
        'type': 'type'
    }
    if hasattr(ProblemResponse, "attribute_map"):
        attribute_map.update(ProblemResponse.attribute_map)

    def __init__(self, status=None, title=None, type=None, *args, **kwargs):  # noqa: E501
        """InlineResponse403 - a model defined in Swagger"""  # noqa: E501
        self._status = None
        self._title = None
        self._type = None
        self.discriminator = None
        if status is not None:
            self.status = status
        if title is not None:
            self.title = title
        if type is not None:
            self.type = type
        ProblemResponse.__init__(self, *args, **kwargs)

    @property
    def status(self):
        """Gets the status of this InlineResponse403.  # noqa: E501


        :return: The status of this InlineResponse403.  # noqa: E501
        :rtype: object
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this InlineResponse403.


        :param status: The status of this InlineResponse403.  # noqa: E501
        :type: object
        """

        self._status = status

    @property
    def title(self):
        """Gets the title of this InlineResponse403.  # noqa: E501


        :return: The title of this InlineResponse403.  # noqa: E501
        :rtype: object
        """
        return self._title

    @title.setter
    def title(self, title):
        """Sets the title of this InlineResponse403.


        :param title: The title of this InlineResponse403.  # noqa: E501
        :type: object
        """

        self._title = title

    @property
    def type(self):
        """Gets the type of this InlineResponse403.  # noqa: E501


        :return: The type of this InlineResponse403.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this InlineResponse403.


        :param type: The type of this InlineResponse403.  # noqa: E501
        :type: str
        """
        allowed_values = ["https://errors.ix-api.net/v2/permission-denied.html"]  # noqa: E501
        if type not in allowed_values:
            raise ValueError(
                "Invalid value for `type` ({0}), must be one of {1}"  # noqa: E501
                .format(type, allowed_values)
            )

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
        if issubclass(InlineResponse403, dict):
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
        if not isinstance(other, InlineResponse403):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
