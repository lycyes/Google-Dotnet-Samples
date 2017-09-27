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
// Unoffical sample for the Clouduseraccounts vm_alpha API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and manages users and groups for accessing Google Compute Engine virtual machines.
// API Documentation Link https://cloud.google.com/compute/docs/access/user-accounts/api/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Clouduseraccounts/vm_alpha/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Clouduseraccounts.vm_alpha/ 
// Install Command: PM>  Install-Package Google.Apis.Clouduseraccounts.vm_alpha
//
//------------------------------------------------------------------------------  
using Google.Apis.Clouduseraccounts.vm_alpha;
using Google.Apis.Clouduseraccounts.vm_alpha.Data;
using System;

namespace GoogleSamplecSharpSample.Clouduseraccountsvm_alpha.Methods
{
  
    public static class LinuxSample
    {

        public class LinuxGetAuthorizedKeysViewOptionalParms
        {
            /// Whether the view was requested as part of a user-initiated login.
            public bool? Login { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of authorized public keys for a specific user account. 
        /// Documentation https://developers.google.com/clouduseraccounts/vm_alpha/reference/linux/getAuthorizedKeysView
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Clouduseraccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="zone">Name of the zone for this request.</param>
        /// <param name="user">The user account for which you want to get a list of authorized public keys.</param>
        /// <param name="instance">The fully-qualified URL of the virtual machine requesting the view.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LinuxGetAuthorizedKeysViewResponseResponse</returns>
        public static LinuxGetAuthorizedKeysViewResponse GetAuthorizedKeysView(ClouduseraccountsService service, string project, string zone, string user, string instance, LinuxGetAuthorizedKeysViewOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (user == null)
                    throw new ArgumentNullException(user);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Building the initial request.
                var request = service.Linux.GetAuthorizedKeysView(project, zone, user, instance);

                // Applying optional parameters to the request.                
                request = (LinuxResource.GetAuthorizedKeysViewRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Linux.GetAuthorizedKeysView failed.", ex);
            }
        }
        public class LinuxGetLinuxAccountViewsOptionalParms
        {
            /// Sets a filter expression for filtering listed resources, in the form filter={expression}. Your {expression} must be in the format: field_name comparison_string literal_string.The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.For example, to filter for instances that do not have a name of example-instance, you would use filter=name ne example-instance.Compute Engine Beta API Only: If you use filtering in the Beta API, you can also filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. In particular, use filtering on nested fields to take advantage of instance labels to organize and filter results based on label values.The Beta API also supports filtering on multiple expressions by providing each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests.
            public int? MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of user accounts for an instance within a specific project. 
        /// Documentation https://developers.google.com/clouduseraccounts/vm_alpha/reference/linux/getLinuxAccountViews
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Clouduseraccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="zone">Name of the zone for this request.</param>
        /// <param name="instance">The fully-qualified URL of the virtual machine requesting the views.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LinuxGetLinuxAccountViewsResponseResponse</returns>
        public static LinuxGetLinuxAccountViewsResponse GetLinuxAccountViews(ClouduseraccountsService service, string project, string zone, string instance, LinuxGetLinuxAccountViewsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Building the initial request.
                var request = service.Linux.GetLinuxAccountViews(project, zone, instance);

                // Applying optional parameters to the request.                
                request = (LinuxResource.GetLinuxAccountViewsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Linux.GetLinuxAccountViews failed.", ex);
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