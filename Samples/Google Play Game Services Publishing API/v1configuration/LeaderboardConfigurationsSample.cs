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
// Unoffical sample for the Gamesconfiguration v1configuration API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Publishing API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Gamesconfiguration/v1configuration/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Gamesconfiguration.v1configuration/ 
// Install Command: PM>  Install-Package Google.Apis.Gamesconfiguration.v1configuration
//
//------------------------------------------------------------------------------  
using Google.Apis.Gamesconfiguration.v1configuration;
using Google.Apis.Gamesconfiguration.v1configuration.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesconfigurationv1configuration.Methods
{
  
    public static class LeaderboardConfigurationsSample
    {


        /// <summary>
        /// Delete the leaderboard configuration with the given ID. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/leaderboardConfigurations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesconfiguration service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        public static void Delete(GamesconfigurationService service, string leaderboardId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);

                // Make the request.
                 service.LeaderboardConfigurations.Delete(leaderboardId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LeaderboardConfigurations.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the metadata of the leaderboard configuration with the given ID. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/leaderboardConfigurations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesconfiguration service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <returns>LeaderboardConfigurationResponse</returns>
        public static LeaderboardConfiguration Get(GamesconfigurationService service, string leaderboardId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);

                // Make the request.
                return service.LeaderboardConfigurations.Get(leaderboardId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LeaderboardConfigurations.Get failed.", ex);
            }
        }

        /// <summary>
        /// Insert a new leaderboard configuration in this application. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/leaderboardConfigurations/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesconfiguration service.</param>  
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        /// <param name="body">A valid Gamesconfiguration v1configuration body.</param>
        /// <returns>LeaderboardConfigurationResponse</returns>
        public static LeaderboardConfiguration Insert(GamesconfigurationService service, string applicationId, LeaderboardConfiguration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (applicationId == null)
                    throw new ArgumentNullException(applicationId);

                // Make the request.
                return service.LeaderboardConfigurations.Insert(body, applicationId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LeaderboardConfigurations.Insert failed.", ex);
            }
        }
        public class LeaderboardConfigurationsListOptionalParms
        {
            /// The maximum number of resource configurations to return in the response, used for paging. For any response, the actual number of resources returned may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of the leaderboard configurations in this application. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/leaderboardConfigurations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesconfiguration service.</param>  
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LeaderboardConfigurationListResponseResponse</returns>
        public static LeaderboardConfigurationListResponse List(GamesconfigurationService service, string applicationId, LeaderboardConfigurationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (applicationId == null)
                    throw new ArgumentNullException(applicationId);

                // Building the initial request.
                var request = service.LeaderboardConfigurations.List(applicationId);

                // Applying optional parameters to the request.                
                request = (LeaderboardConfigurationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LeaderboardConfigurations.List failed.", ex);
            }
        }

        /// <summary>
        /// Update the metadata of the leaderboard configuration with the given ID. This method supports patch semantics. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/leaderboardConfigurations/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesconfiguration service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="body">A valid Gamesconfiguration v1configuration body.</param>
        /// <returns>LeaderboardConfigurationResponse</returns>
        public static LeaderboardConfiguration Patch(GamesconfigurationService service, string leaderboardId, LeaderboardConfiguration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);

                // Make the request.
                return service.LeaderboardConfigurations.Patch(body, leaderboardId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LeaderboardConfigurations.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Update the metadata of the leaderboard configuration with the given ID. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/leaderboardConfigurations/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesconfiguration service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="body">A valid Gamesconfiguration v1configuration body.</param>
        /// <returns>LeaderboardConfigurationResponse</returns>
        public static LeaderboardConfiguration Update(GamesconfigurationService service, string leaderboardId, LeaderboardConfiguration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);

                // Make the request.
                return service.LeaderboardConfigurations.Update(body, leaderboardId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LeaderboardConfigurations.Update failed.", ex);
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