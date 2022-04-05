/* 
 * IX-API
 *
 *  This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error. 
 *
 * The version of the OpenAPI document: 2.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing NetworkServicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NetworkServicesApiTests : IDisposable
    {
        private NetworkServicesApi instance;

        public NetworkServicesApiTests()
        {
            instance = new NetworkServicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NetworkServicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NetworkServicesApi
            //Assert.IsType(typeof(NetworkServicesApi), instance, "instance is a NetworkServicesApi");
        }

        
        /// <summary>
        /// Test NetworkServicesList
        /// </summary>
        [Fact]
        public void NetworkServicesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> id = null;
            //string state = null;
            //string stateIsNot = null;
            //string managingAccount = null;
            //string consumingAccount = null;
            //string externalRef = null;
            //string type = null;
            //string pop = null;
            //string productOffering = null;
            //var response = instance.NetworkServicesList(id, state, stateIsNot, managingAccount, consumingAccount, externalRef, type, pop, productOffering);
            //Assert.IsType<List<NetworkService>> (response, "response is List<NetworkService>");
        }
        
    }

}
