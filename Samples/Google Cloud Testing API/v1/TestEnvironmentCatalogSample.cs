﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-27
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Testing v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Allows developers to run automated tests for their mobile applications on Google infrastructure.
// API Documentation Link https://developers.google.com/cloud-test-lab/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Testing/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Testing.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Testing.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Testing.v1;
using Google.Apis.Testing.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Testingv1.Methods
{
  
    public static class TestEnvironmentCatalogSample
    {

        public class TestEnvironmentCatalogGetOptionalParms
        {
            /// For authorization, the cloud project requesting the TestEnvironmentCatalog.Optional
            public string ProjectId { get; set; }  
        
        }
 
        /// <summary>
        /// Get the catalog of supported test environments.May return any of the following canonical error codes:- INVALID_ARGUMENT - if the request is malformed- NOT_FOUND - if the environment type does not exist- INTERNAL - if an internal error occurred 
        /// Documentation https://developers.google.com/testing/v1/reference/testEnvironmentCatalog/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Testing service.</param>  
        /// <param name="environmentType">The type of environment that should be listed.Required</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TestEnvironmentCatalogResponse</returns>
        public static TestEnvironmentCatalog Get(TestingService service, string environmentType, TestEnvironmentCatalogGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (environmentType == null)
                    throw new ArgumentNullException(environmentType);

                // Building the initial request.
                var request = service.TestEnvironmentCatalog.Get(environmentType);

                // Applying optional parameters to the request.                
                request = (TestEnvironmentCatalogResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TestEnvironmentCatalog.Get failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}