# coding: utf-8

"""
    IX-API

     This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error.   # noqa: E501

    The version of the OpenAPI document: 2.2.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import openapi_client
from openapi_client.models.exchange_lan_network_service_partial import ExchangeLanNetworkServicePartial  # noqa: E501
from openapi_client.rest import ApiException

class TestExchangeLanNetworkServicePartial(unittest.TestCase):
    """ExchangeLanNetworkServicePartial unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test ExchangeLanNetworkServicePartial
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.exchange_lan_network_service_partial.ExchangeLanNetworkServicePartial()  # noqa: E501
        if include_optional :
            return ExchangeLanNetworkServicePartial(
                consuming_account = '2381982', 
                external_ref = 'IX:Service:23042', 
                id = '0', 
                ixfdb_ixid = 56, 
                managing_account = '238189294', 
                metro_area_network = 'man:293225:LON2', 
                name = '0', 
                network_features = [
                    '0'
                    ], 
                nsc_required_contact_roles = [
                    '0'
                    ], 
                peeringdb_ixid = 56, 
                product_offering = '0', 
                state = 'requested', 
                status = [
                    null
                    ], 
                subnet_v4 = '23.142.52.0/21', 
                subnet_v6 = '2001:23:42::/48', 
                type = 'exchange_lan'
            )
        else :
            return ExchangeLanNetworkServicePartial(
                type = 'exchange_lan',
        )

    def testExchangeLanNetworkServicePartial(self):
        """Test ExchangeLanNetworkServicePartial"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
