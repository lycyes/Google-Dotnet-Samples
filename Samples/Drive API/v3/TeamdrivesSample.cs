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
// Unoffical sample for the Drive v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev3.Methods
{
  
    public static class TeamdrivesSample
    {


        /// <summary>
        /// Creates a new Team Drive. 
        /// Documentation https://developers.google.com/drive/v3/reference/teamdrives/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="requestId">An ID, such as a random UUID, which uniquely identifies this user's request for idempotent creation of a Team Drive. A repeated request by the same user and with the same request ID will avoid creating duplicates by attempting to create the same Team Drive. If the Team Drive already exists a 409 error will be returned.</param>
        /// <param name="body">A valid Drive v3 body.</param>
        /// <returns>TeamDriveResponse</returns>
        public static TeamDrive Create(DriveService service, string requestId, TeamDrive body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (requestId == null)
                    throw new ArgumentNullException(requestId);

                // Make the request.
                return service.Teamdrives.Create(body, requestId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Teamdrives.Create failed.", ex);
            }
        }

        /// <summary>
        /// Permanently deletes a Team Drive for which the user is an organizer. The Team Drive cannot contain any untrashed items. 
        /// Documentation https://developers.google.com/drive/v3/reference/teamdrives/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="teamDriveId">The ID of the Team Drive</param>
        public static void Delete(DriveService service, string teamDriveId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (teamDriveId == null)
                    throw new ArgumentNullException(teamDriveId);

                // Make the request.
                 service.Teamdrives.Delete(teamDriveId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Teamdrives.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets a Team Drive's metadata by ID. 
        /// Documentation https://developers.google.com/drive/v3/reference/teamdrives/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="teamDriveId">The ID of the Team Drive</param>
        /// <returns>TeamDriveResponse</returns>
        public static TeamDrive Get(DriveService service, string teamDriveId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (teamDriveId == null)
                    throw new ArgumentNullException(teamDriveId);

                // Make the request.
                return service.Teamdrives.Get(teamDriveId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Teamdrives.Get failed.", ex);
            }
        }
        public class TeamdrivesListOptionalParms
        {
            /// Maximum number of Team Drives to return.
            public int? PageSize { get; set; }  
            /// Page token for Team Drives.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the user's Team Drives. 
        /// Documentation https://developers.google.com/drive/v3/reference/teamdrives/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TeamDriveListResponse</returns>
        public static TeamDriveList List(DriveService service, TeamdrivesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Teamdrives.List();

                // Applying optional parameters to the request.                
                request = (TeamdrivesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Teamdrives.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates a Team Drive's metadata 
        /// Documentation https://developers.google.com/drive/v3/reference/teamdrives/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="teamDriveId">The ID of the Team Drive</param>
        /// <param name="body">A valid Drive v3 body.</param>
        /// <returns>TeamDriveResponse</returns>
        public static TeamDrive Update(DriveService service, string teamDriveId, TeamDrive body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (teamDriveId == null)
                    throw new ArgumentNullException(teamDriveId);

                // Make the request.
                return service.Teamdrives.Update(body, teamDriveId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Teamdrives.Update failed.", ex);
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