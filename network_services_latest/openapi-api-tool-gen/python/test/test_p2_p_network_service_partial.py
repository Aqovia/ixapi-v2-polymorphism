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
from openapi_client.models.p2_p_network_service_partial import P2PNetworkServicePartial  # noqa: E501
from openapi_client.rest import ApiException

class TestP2PNetworkServicePartial(unittest.TestCase):
    """P2PNetworkServicePartial unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test P2PNetworkServicePartial
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.p2_p_network_service_partial.P2PNetworkServicePartial()  # noqa: E501
        if include_optional :
            return P2PNetworkServicePartial(
                billing_account = '0', 
                capacity = 1, 
                charged_until = datetime.datetime.strptime('1975-12-30', '%Y-%m-%d').date(), 
                consuming_account = '2381982', 
                contract_ref = 'contract:31824', 
                decommission_at = datetime.datetime.strptime('1975-12-30', '%Y-%m-%d').date(), 
                external_ref = 'IX:Service:23042', 
                id = '0', 
                joining_member_account = '231829', 
                managing_account = '238189294', 
                nsc_required_contact_roles = [
                    '0'
                    ], 
                product_offering = '0', 
                purchase_order = '0', 
                state = 'requested', 
                status = [
                    null
                    ], 
                type = 'p2p_vc'
            )
        else :
            return P2PNetworkServicePartial(
                type = 'p2p_vc',
        )

    def testP2PNetworkServicePartial(self):
        """Test P2PNetworkServicePartial"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
