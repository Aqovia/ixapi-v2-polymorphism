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
from openapi_client.models.v_lan_config_dot1_q_partial import VLanConfigDot1QPartial  # noqa: E501
from openapi_client.rest import ApiException

class TestVLanConfigDot1QPartial(unittest.TestCase):
    """VLanConfigDot1QPartial unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test VLanConfigDot1QPartial
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = openapi_client.models.v_lan_config_dot1_q_partial.VLanConfigDot1QPartial()  # noqa: E501
        if include_optional :
            return VLanConfigDot1QPartial(
                vlan = 23, 
                vlan_ethertype = '0x8100', 
                vlan_type = 'dot1q'
            )
        else :
            return VLanConfigDot1QPartial(
                vlan_type = 'dot1q',
        )

    def testVLanConfigDot1QPartial(self):
        """Test VLanConfigDot1QPartial"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
