# coding: utf-8

"""
    IX-API

     This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error.   # noqa: E501

    The version of the OpenAPI document: 2.2.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import openapi_client
from openapi_client.api.network_services_api import NetworkServicesApi  # noqa: E501
from openapi_client.rest import ApiException


class TestNetworkServicesApi(unittest.TestCase):
    """NetworkServicesApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.network_services_api.NetworkServicesApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_network_services_list(self):
        """Test case for network_services_list

        """
        pass


if __name__ == '__main__':
    unittest.main()