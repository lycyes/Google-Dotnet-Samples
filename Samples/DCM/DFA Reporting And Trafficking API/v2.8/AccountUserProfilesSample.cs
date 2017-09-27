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
// Unoffical sample for the Dfareporting v2.8 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dfareporting/v2_8/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dfareporting.v2_8/ 
// Install Command: PM>  Install-Package Google.Apis.Dfareporting.v2_8
//
//------------------------------------------------------------------------------  
using Google.Apis.Dfareporting.v2_8;
using Google.Apis.Dfareporting.v2_8.Data;
using System;

namespace GoogleSamplecSharpSample.Dfareportingv2_8.Methods
{
  
    public static class AccountUserProfilesSample
    {


        /// <summary>
        /// Gets one account user profile by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/accountUserProfiles/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">User profile ID.</param>
        /// <returns>AccountUserProfileResponse</returns>
        public static AccountUserProfile Get(DfareportingService service, string profileId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.AccountUserProfiles.Get(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AccountUserProfiles.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a new account user profile. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/accountUserProfiles/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>AccountUserProfileResponse</returns>
        public static AccountUserProfile Insert(DfareportingService service, string profileId, AccountUserProfile body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.AccountUserProfiles.Insert(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AccountUserProfiles.Insert failed.", ex);
            }
        }
        public class AccountUserProfilesListOptionalParms
        {
            /// Select only active user profiles.
            public bool? Active { get; set; }  
            /// Select only user profiles with these IDs.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int? MaxResults { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for objects by name, ID or email. Wildcards (*) are allowed. For example, "user profile*2015" will return objects with names like "user profile June 2015", "user profile April 2015", or simply "user profile 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "user profile" will match objects with name "my user profile", "user profile 2015", or simply "user profile".
            public string SearchString { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results.
            public string SortOrder { get; set; }  
            /// Select only user profiles with the specified subaccount ID.
            public string SubaccountId { get; set; }  
            /// Select only user profiles with the specified user role ID.
            public string UserRoleId { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of account user profiles, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/accountUserProfiles/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AccountUserProfilesListResponseResponse</returns>
        public static AccountUserProfilesListResponse List(DfareportingService service, string profileId, AccountUserProfilesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.AccountUserProfiles.List(profileId);

                // Applying optional parameters to the request.                
                request = (AccountUserProfilesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AccountUserProfiles.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing account user profile. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/accountUserProfiles/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">User profile ID.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>AccountUserProfileResponse</returns>
        public static AccountUserProfile Patch(DfareportingService service, string profileId, string id, AccountUserProfile body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.AccountUserProfiles.Patch(body, profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AccountUserProfiles.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing account user profile. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/accountUserProfiles/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>AccountUserProfileResponse</returns>
        public static AccountUserProfile Update(DfareportingService service, string profileId, AccountUserProfile body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.AccountUserProfiles.Update(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AccountUserProfiles.Update failed.", ex);
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