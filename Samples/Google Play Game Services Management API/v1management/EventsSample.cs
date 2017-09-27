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
// Unoffical sample for the Gamesmanagement v1management API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Management API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Gamesmanagement/v1management/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Gamesmanagement.v1management/ 
// Install Command: PM>  Install-Package Google.Apis.Gamesmanagement.v1management
//
//------------------------------------------------------------------------------  
using Google.Apis.Gamesmanagement.v1management;
using Google.Apis.Gamesmanagement.v1management.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesmanagementv1management.Methods
{
  
    public static class EventsSample
    {


        /// <summary>
        /// Resets all player progress on the event with the given ID for the currently authenticated player. This method is only accessible to whitelisted tester accounts for your application. All quests for this player that use the event will also be reset. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/events/reset
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        /// <param name="eventId">The ID of the event.</param>
        public static void Reset(GamesmanagementService service, string eventId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (eventId == null)
                    throw new ArgumentNullException(eventId);

                // Make the request.
                 service.Events.Reset(eventId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Events.Reset failed.", ex);
            }
        }

        /// <summary>
        /// Resets all player progress on all events for the currently authenticated player. This method is only accessible to whitelisted tester accounts for your application. All quests for this player will also be reset. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/events/resetAll
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        public static void ResetAll(GamesmanagementService service)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Make the request.
                 service.Events.ResetAll().Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Events.ResetAll failed.", ex);
            }
        }

        /// <summary>
        /// Resets all draft events for all players. This method is only available to user accounts for your developer console. All quests that use any of these events will also be reset. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/events/resetAllForAllPlayers
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        public static void ResetAllForAllPlayers(GamesmanagementService service)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Make the request.
                 service.Events.ResetAllForAllPlayers().Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Events.ResetAllForAllPlayers failed.", ex);
            }
        }

        /// <summary>
        /// Resets the event with the given ID for all players. This method is only available to user accounts for your developer console. Only draft events can be reset. All quests that use the event will also be reset. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/events/resetForAllPlayers
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        /// <param name="eventId">The ID of the event.</param>
        public static void ResetForAllPlayers(GamesmanagementService service, string eventId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (eventId == null)
                    throw new ArgumentNullException(eventId);

                // Make the request.
                 service.Events.ResetForAllPlayers(eventId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Events.ResetForAllPlayers failed.", ex);
            }
        }

        /// <summary>
        /// Resets events with the given IDs for all players. This method is only available to user accounts for your developer console. Only draft events may be reset. All quests that use any of the events will also be reset. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/events/resetMultipleForAllPlayers
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        /// <param name="body">A valid Gamesmanagement v1management body.</param>
        public static void ResetMultipleForAllPlayers(GamesmanagementService service, EventsResetMultipleForAllRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                 service.Events.ResetMultipleForAllPlayers(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Events.ResetMultipleForAllPlayers failed.", ex);
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