/* 
 * IX-API
 *
 *  This API allows to config/change/delete Internet Exchange services.  # Filters  When querying collections, the provided query parameters are validated. Unknown query parameters are ignored. Providing invalid filter values should yield a validation error. 
 *
 * The version of the OpenAPI document: 2.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing VLanConfigQinQPartial
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VLanConfigQinQPartialTests
    {
        // TODO uncomment below to declare an instance variable for VLanConfigQinQPartial
        //private VLanConfigQinQPartial instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of VLanConfigQinQPartial
            //instance = new VLanConfigQinQPartial();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VLanConfigQinQPartial
        /// </summary>
        [Test]
        public void VLanConfigQinQPartialInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" VLanConfigQinQPartial
            //Assert.IsInstanceOf(typeof(VLanConfigQinQPartial), instance);
        }


        /// <summary>
        /// Test the property 'InnerVlan'
        /// </summary>
        [Test]
        public void InnerVlanTest()
        {
            // TODO unit test for the property 'InnerVlan'
        }
        /// <summary>
        /// Test the property 'OuterVlan'
        /// </summary>
        [Test]
        public void OuterVlanTest()
        {
            // TODO unit test for the property 'OuterVlan'
        }
        /// <summary>
        /// Test the property 'OuterVlanEthertype'
        /// </summary>
        [Test]
        public void OuterVlanEthertypeTest()
        {
            // TODO unit test for the property 'OuterVlanEthertype'
        }
        /// <summary>
        /// Test the property 'VlanType'
        /// </summary>
        [Test]
        public void VlanTypeTest()
        {
            // TODO unit test for the property 'VlanType'
        }

    }

}