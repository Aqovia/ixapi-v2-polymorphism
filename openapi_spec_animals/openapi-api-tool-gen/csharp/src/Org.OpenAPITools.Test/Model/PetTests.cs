/* 
 * IX-API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3.0
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
    ///  Class for testing Pet
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PetTests
    {
        // TODO uncomment below to declare an instance variable for Pet
        //private Pet instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Pet
            //instance = new Pet();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Pet
        /// </summary>
        [Test]
        public void PetInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Pet
            //Assert.IsInstanceOf(typeof(Pet), instance);
        }

        /// <summary>
        /// Test deserialize a Lizard from type Pet
        /// </summary>
        [Test]
        public void LizardDeserializeFromPetTest()
        {
            // TODO uncomment below to test deserialize a Lizard from type Pet
            //Assert.IsInstanceOf(typeof(Pet), JsonConvert.DeserializeObject<Pet>(new Lizard().ToJson()));
        }
        /// <summary>
        /// Test deserialize a Cat from type Pet
        /// </summary>
        [Test]
        public void CatDeserializeFromPetTest()
        {
            // TODO uncomment below to test deserialize a Cat from type Pet
            //Assert.IsInstanceOf(typeof(Pet), JsonConvert.DeserializeObject<Pet>(new Cat().ToJson()));
        }
        /// <summary>
        /// Test deserialize a Dog from type Pet
        /// </summary>
        [Test]
        public void DogDeserializeFromPetTest()
        {
            // TODO uncomment below to test deserialize a Dog from type Pet
            //Assert.IsInstanceOf(typeof(Pet), JsonConvert.DeserializeObject<Pet>(new Dog().ToJson()));
        }

        /// <summary>
        /// Test the property 'PetType'
        /// </summary>
        [Test]
        public void PetTypeTest()
        {
            // TODO unit test for the property 'PetType'
        }

    }

}