# coding: utf-8

"""
    IX-API

     This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error.   # noqa: E501

    The version of the OpenAPI document: 2.2.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from openapi_client.api_client import ApiClient
from openapi_client.exceptions import (  # noqa: F401
    ApiTypeError,
    ApiValueError
)


class NetworkServicesApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def network_services_list(self, **kwargs):  # noqa: E501
        """network_services_list  # noqa: E501

        List available `NetworkService`s.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.network_services_list(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param list[str] id: Filter by id
        :param str state: Filter by state
        :param str state__is_not: Filter by state__is_not
        :param str managing_account: Filter by managing_account
        :param str consuming_account: Filter by consuming_account
        :param str external_ref: Filter by external_ref
        :param str type: Filter by type
        :param str pop: Filter by pop
        :param str product_offering: Filter by product_offering
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: list[NetworkService]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.network_services_list_with_http_info(**kwargs)  # noqa: E501

    def network_services_list_with_http_info(self, **kwargs):  # noqa: E501
        """network_services_list  # noqa: E501

        List available `NetworkService`s.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.network_services_list_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param list[str] id: Filter by id
        :param str state: Filter by state
        :param str state__is_not: Filter by state__is_not
        :param str managing_account: Filter by managing_account
        :param str consuming_account: Filter by consuming_account
        :param str external_ref: Filter by external_ref
        :param str type: Filter by type
        :param str pop: Filter by pop
        :param str product_offering: Filter by product_offering
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: tuple(list[NetworkService], status_code(int), headers(HTTPHeaderDict))
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'id',
            'state',
            'state__is_not',
            'managing_account',
            'consuming_account',
            'external_ref',
            'type',
            'pop',
            'product_offering'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method network_services_list" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'id' in local_var_params and local_var_params['id'] is not None:  # noqa: E501
            query_params.append(('id', local_var_params['id']))  # noqa: E501
            collection_formats['id'] = 'csv'  # noqa: E501
        if 'state' in local_var_params and local_var_params['state'] is not None:  # noqa: E501
            query_params.append(('state', local_var_params['state']))  # noqa: E501
        if 'state__is_not' in local_var_params and local_var_params['state__is_not'] is not None:  # noqa: E501
            query_params.append(('state__is_not', local_var_params['state__is_not']))  # noqa: E501
        if 'managing_account' in local_var_params and local_var_params['managing_account'] is not None:  # noqa: E501
            query_params.append(('managing_account', local_var_params['managing_account']))  # noqa: E501
        if 'consuming_account' in local_var_params and local_var_params['consuming_account'] is not None:  # noqa: E501
            query_params.append(('consuming_account', local_var_params['consuming_account']))  # noqa: E501
        if 'external_ref' in local_var_params and local_var_params['external_ref'] is not None:  # noqa: E501
            query_params.append(('external_ref', local_var_params['external_ref']))  # noqa: E501
        if 'type' in local_var_params and local_var_params['type'] is not None:  # noqa: E501
            query_params.append(('type', local_var_params['type']))  # noqa: E501
        if 'pop' in local_var_params and local_var_params['pop'] is not None:  # noqa: E501
            query_params.append(('pop', local_var_params['pop']))  # noqa: E501
        if 'product_offering' in local_var_params and local_var_params['product_offering'] is not None:  # noqa: E501
            query_params.append(('product_offering', local_var_params['product_offering']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['Bearer']  # noqa: E501

        return self.api_client.call_api(
            '/network-services', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='list[NetworkService]',  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)