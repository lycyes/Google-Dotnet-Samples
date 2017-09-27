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
// Unoffical sample for the Directory directory_v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Admin SDK Directory API lets you view and manage enterprise resources such as users and groups, administrative notifications, security features, and more.
// API Documentation Link https://developers.google.com/admin-sdk/directory/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Directory/directory_v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Directory.directory_v1/ 
// Install Command: PM>  Install-Package Google.Apis.Directory.directory_v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Directory.directory_v1;
using Google.Apis.Directory.directory_v1.Data;
using System;

namespace GoogleSamplecSharpSample.Directorydirectory_v1.Methods
{
  
    public static class OrgunitsSample
    {


        /// <summary>
        /// Remove Organization Unit 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/orgunits/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of the organization unit or its Id</param>
        public static void Delete(DirectoryService service, string customerId, string orgUnitPath)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (orgUnitPath == null)
                    throw new ArgumentNullException(orgUnitPath);

                // Make the request.
                 service.Orgunits.Delete(customerId, orgUnitPath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orgunits.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieve Organization Unit 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/orgunits/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of the organization unit or its Id</param>
        /// <returns>OrgUnitResponse</returns>
        public static OrgUnit Get(DirectoryService service, string customerId, string orgUnitPath)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (orgUnitPath == null)
                    throw new ArgumentNullException(orgUnitPath);

                // Make the request.
                return service.Orgunits.Get(customerId, orgUnitPath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orgunits.Get failed.", ex);
            }
        }

        /// <summary>
        /// Add Organization Unit 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/orgunits/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>OrgUnitResponse</returns>
        public static OrgUnit Insert(DirectoryService service, string customerId, OrgUnit body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);

                // Make the request.
                return service.Orgunits.Insert(body, customerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orgunits.Insert failed.", ex);
            }
        }
        public class OrgunitsListOptionalParms
        {
            /// the URL-encoded organization unit's path or its Id
            public string OrgUnitPath { get; set; }  
            /// Whether to return all sub-organizations or just immediate children
            public string Type { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieve all Organization Units 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/orgunits/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OrgUnitsResponse</returns>
        public static OrgUnits List(DirectoryService service, string customerId, OrgunitsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);

                // Building the initial request.
                var request = service.Orgunits.List(customerId);

                // Applying optional parameters to the request.                
                request = (OrgunitsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orgunits.List failed.", ex);
            }
        }

        /// <summary>
        /// Update Organization Unit. This method supports patch semantics. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/orgunits/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of the organization unit or its Id</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>OrgUnitResponse</returns>
        public static OrgUnit Patch(DirectoryService service, string customerId, string orgUnitPath, OrgUnit body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (orgUnitPath == null)
                    throw new ArgumentNullException(orgUnitPath);

                // Make the request.
                return service.Orgunits.Patch(body, customerId, orgUnitPath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orgunits.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Update Organization Unit 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/orgunits/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of the organization unit or its Id</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>OrgUnitResponse</returns>
        public static OrgUnit Update(DirectoryService service, string customerId, string orgUnitPath, OrgUnit body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (orgUnitPath == null)
                    throw new ArgumentNullException(orgUnitPath);

                // Make the request.
                return service.Orgunits.Update(body, customerId, orgUnitPath).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orgunits.Update failed.", ex);
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