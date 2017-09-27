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
// Unoffical sample for the Discovery v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Provides information about other Google APIs, such as what APIs are available, the resource, and method details for each API.
// API Documentation Link https://developers.google.com/discovery/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Discovery/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Discovery.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Discovery.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Discoveryv1.Methods
{
  
    public static class ApisSample
    {


        /// <summary>
        /// Retrieve the description of a particular version of an api. 
        /// Documentation https://developers.google.com/discovery/v1/reference/apis/getRest
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Discovery service.</param>  
        /// <param name="api">The name of the API.</param>
        /// <param name="version">The version of the API.</param>
        /// <returns>RestDescriptionResponse</returns>
        public static RestDescription GetRest(DiscoveryService service, string api, string version)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (api == null)
                    throw new ArgumentNullException(api);
                if (version == null)
                    throw new ArgumentNullException(version);

                // Make the request.
                return service.Apis.GetRest(api, version).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Apis.GetRest failed.", ex);
            }
        }
        public class ApisListOptionalParms
        {
            /// Only include APIs with the given name.
            public string Name { get; set; }  
            /// Return only the preferred version of an API.
            public bool? Preferred { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieve the list of APIs supported at this endpoint. 
        /// Documentation https://developers.google.com/discovery/v1/reference/apis/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Discovery service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DirectoryListResponse</returns>
        public static DirectoryList List(DiscoveryService service, ApisListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Apis.List();

                // Applying optional parameters to the request.                
                request = (ApisResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Apis.List failed.", ex);
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