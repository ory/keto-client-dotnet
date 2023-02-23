/*
 * Ory Keto API
 *
 * Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. 
 *
 * The version of the OpenAPI document: v0.11.0-alpha.0
 * Contact: hi@ory.sh
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

using Ory.Keto.Client.Client;
using Ory.Keto.Client.Api;
// uncomment below to import models
//using Ory.Keto.Client.Model;

namespace Ory.Keto.Client.Test.Api
{
    /// <summary>
    ///  Class for testing PermissionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PermissionApiTests : IDisposable
    {
        private PermissionApi instance;

        public PermissionApiTests()
        {
            instance = new PermissionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PermissionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PermissionApi
            //Assert.IsType<PermissionApi>(instance);
        }

        /// <summary>
        /// Test CheckPermission
        /// </summary>
        [Fact]
        public void CheckPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //long? maxDepth = null;
            //var response = instance.CheckPermission(_namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation, maxDepth);
            //Assert.IsType<KetoCheckPermissionResult>(response);
        }

        /// <summary>
        /// Test CheckPermissionOrError
        /// </summary>
        [Fact]
        public void CheckPermissionOrErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //long? maxDepth = null;
            //var response = instance.CheckPermissionOrError(_namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation, maxDepth);
            //Assert.IsType<KetoCheckPermissionResult>(response);
        }

        /// <summary>
        /// Test ExpandPermissions
        /// </summary>
        [Fact]
        public void ExpandPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //long? maxDepth = null;
            //var response = instance.ExpandPermissions(_namespace, _object, relation, maxDepth);
            //Assert.IsType<KetoExpandedPermissionTree>(response);
        }

        /// <summary>
        /// Test PostCheckPermission
        /// </summary>
        [Fact]
        public void PostCheckPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? maxDepth = null;
            //KetoPostCheckPermissionBody ketoPostCheckPermissionBody = null;
            //var response = instance.PostCheckPermission(maxDepth, ketoPostCheckPermissionBody);
            //Assert.IsType<KetoCheckPermissionResult>(response);
        }

        /// <summary>
        /// Test PostCheckPermissionOrError
        /// </summary>
        [Fact]
        public void PostCheckPermissionOrErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? maxDepth = null;
            //KetoPostCheckPermissionOrErrorBody ketoPostCheckPermissionOrErrorBody = null;
            //var response = instance.PostCheckPermissionOrError(maxDepth, ketoPostCheckPermissionOrErrorBody);
            //Assert.IsType<KetoCheckPermissionResult>(response);
        }
    }
}
