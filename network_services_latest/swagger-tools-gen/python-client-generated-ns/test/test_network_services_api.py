# coding: utf-8

"""
    IX-API

     This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error.   # noqa: E501

    OpenAPI spec version: 2.2.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.network_services_api import NetworkServicesApi  # noqa: E501
from swagger_client.rest import ApiException


class TestNetworkServicesApi(unittest.TestCase):
    """NetworkServicesApi unit test stubs"""

    def setUp(self):
        self.api = NetworkServicesApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_network_services_list(self):
        """Test case for network_services_list

        """
        pass


if __name__ == '__main__':
    unittest.main()