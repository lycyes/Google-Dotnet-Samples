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
// Unoffical sample for the Iam v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages identity and access control for Google Cloud Platform resources, including the creation of service accounts, which you can use to authenticate to Google and make API calls.
// API Documentation Link https://cloud.google.com/iam/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Iam/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Iam.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Iam.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Iam.v1;
using Google.Apis.Iam.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Iamv1.Methods
{
  
    public static class RolesSample
    {


        /// <summary>
        /// Queries roles that can be granted on a particular resource.A role is grantable if it can be used as the role in a binding for a policyfor that resource. 
        /// Documentation https://developers.google.com/iam/v1/reference/roles/queryGrantableRoles
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Iam service.</param>  
        /// <param name="body">A valid Iam v1 body.</param>
        /// <returns>QueryGrantableRolesResponseResponse</returns>
        public static QueryGrantableRolesResponse QueryGrantableRoles(IamService service, QueryGrantableRolesRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Roles.QueryGrantableRoles(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Roles.QueryGrantableRoles failed.", ex);
            }
        }

        /// <summary>
        /// Gets a Role definition. 
        /// Documentation https://developers.google.com/iam/v1/reference/roles/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Iam service.</param>  
        /// <param name="name">The resource name of the role in one of the following formats:`roles/{ROLE_NAME}``organizations/{ORGANIZATION_ID}/roles/{ROLE_NAME}``projects/{PROJECT_ID}/roles/{ROLE_NAME}`</param>
        /// <returns>RoleResponse</returns>
        public static Role Get(IamService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Roles.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Roles.Get failed.", ex);
            }
        }
        public class RolesListOptionalParms
        {
            /// Optional view for the returned Role objects.
            public string View { get; set; }  
            /// The resource name of the parent resource in one of the following formats:`` (empty string) -- this refers to curated roles.`organizations/{ORGANIZATION_ID}``projects/{PROJECT_ID}`
            public string Parent { get; set; }  
            /// Include Roles that have been deleted.
            public bool? ShowDeleted { get; set; }  
            /// Optional pagination token returned in an earlier ListRolesResponse.
            public string PageToken { get; set; }  
            /// Optional limit on the number of roles to include in the response.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the Roles defined on a resource. 
        /// Documentation https://developers.google.com/iam/v1/reference/roles/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Iam service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListRolesResponseResponse</returns>
        public static ListRolesResponse List(IamService service, RolesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Roles.List();

                // Applying optional parameters to the request.                
                request = (RolesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Roles.List failed.", ex);
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