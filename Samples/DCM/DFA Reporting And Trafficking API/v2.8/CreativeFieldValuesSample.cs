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
  
    public static class CreativeFieldValuesSample
    {


        /// <summary>
        /// Deletes an existing creative field value. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/creativeFieldValues/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="creativeFieldId">Creative field ID for this creative field value.</param>
        /// <param name="id">Creative Field Value ID</param>
        public static void Delete(DfareportingService service, string profileId, string creativeFieldId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (creativeFieldId == null)
                    throw new ArgumentNullException(creativeFieldId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                 service.CreativeFieldValues.Delete(profileId, creativeFieldId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeFieldValues.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets one creative field value by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/creativeFieldValues/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="creativeFieldId">Creative field ID for this creative field value.</param>
        /// <param name="id">Creative Field Value ID</param>
        /// <returns>CreativeFieldValueResponse</returns>
        public static CreativeFieldValue Get(DfareportingService service, string profileId, string creativeFieldId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (creativeFieldId == null)
                    throw new ArgumentNullException(creativeFieldId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.CreativeFieldValues.Get(profileId, creativeFieldId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeFieldValues.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a new creative field value. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/creativeFieldValues/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="creativeFieldId">Creative field ID for this creative field value.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>CreativeFieldValueResponse</returns>
        public static CreativeFieldValue Insert(DfareportingService service, string profileId, string creativeFieldId, CreativeFieldValue body)
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
                if (creativeFieldId == null)
                    throw new ArgumentNullException(creativeFieldId);

                // Make the request.
                return service.CreativeFieldValues.Insert(body, profileId, creativeFieldId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeFieldValues.Insert failed.", ex);
            }
        }
        public class CreativeFieldValuesListOptionalParms
        {
            /// Select only creative field values with these IDs.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int? MaxResults { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for creative field values by their values. Wildcards (e.g. *) are not allowed.
            public string SearchString { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of creative field values, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/creativeFieldValues/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="creativeFieldId">Creative field ID for this creative field value.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CreativeFieldValuesListResponseResponse</returns>
        public static CreativeFieldValuesListResponse List(DfareportingService service, string profileId, string creativeFieldId, CreativeFieldValuesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (creativeFieldId == null)
                    throw new ArgumentNullException(creativeFieldId);

                // Building the initial request.
                var request = service.CreativeFieldValues.List(profileId, creativeFieldId);

                // Applying optional parameters to the request.                
                request = (CreativeFieldValuesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeFieldValues.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing creative field value. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/creativeFieldValues/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="creativeFieldId">Creative field ID for this creative field value.</param>
        /// <param name="id">Creative Field Value ID</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>CreativeFieldValueResponse</returns>
        public static CreativeFieldValue Patch(DfareportingService service, string profileId, string creativeFieldId, string id, CreativeFieldValue body)
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
                if (creativeFieldId == null)
                    throw new ArgumentNullException(creativeFieldId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.CreativeFieldValues.Patch(body, profileId, creativeFieldId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeFieldValues.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing creative field value. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/creativeFieldValues/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="creativeFieldId">Creative field ID for this creative field value.</param>
        /// <param name="body">A valid Dfareporting v2.8 body.</param>
        /// <returns>CreativeFieldValueResponse</returns>
        public static CreativeFieldValue Update(DfareportingService service, string profileId, string creativeFieldId, CreativeFieldValue body)
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
                if (creativeFieldId == null)
                    throw new ArgumentNullException(creativeFieldId);

                // Make the request.
                return service.CreativeFieldValues.Update(body, profileId, creativeFieldId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeFieldValues.Update failed.", ex);
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