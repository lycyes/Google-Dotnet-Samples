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
// Unoffical sample for the Civicinfo v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Provides polling places, early vote locations, contest data, election officials, and government representatives for U.S. residential addresses.
// API Documentation Link https://developers.google.com/civic-information
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Civicinfo/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Civicinfo.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Civicinfo.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Civicinfo.v2;
using Google.Apis.Civicinfo.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Civicinfov2.Methods
{
  
    public static class RepresentativesSample
    {

        public class RepresentativesRepresentativeInfoByAddressOptionalParms
        {
            /// The address to look up. May only be specified if the field ocdId is not given in the URL.
            public string Address { get; set; }  
            /// Whether to return information about offices and officials. If false, only the top-level district information will be returned.
            public bool? IncludeOffices { get; set; }  
            /// A list of office levels to filter by. Only offices that serve at least one of these levels will be returned. Divisions that don't contain a matching office will not be returned.
            public string Levels { get; set; }  
            /// A list of office roles to filter by. Only offices fulfilling one of these roles will be returned. Divisions that don't contain a matching office will not be returned.
            public string Roles { get; set; }  
        
        }
 
        /// <summary>
        /// Looks up political geography and representative information for a single address. 
        /// Documentation https://developers.google.com/civicinfo/v2/reference/representatives/representativeInfoByAddress
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Civicinfo service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>RepresentativeInfoResponseResponse</returns>
        public static RepresentativeInfoResponse RepresentativeInfoByAddress(CivicinfoService service, RepresentativesRepresentativeInfoByAddressOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Representatives.RepresentativeInfoByAddress();

                // Applying optional parameters to the request.                
                request = (RepresentativesResource.RepresentativeInfoByAddressRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Representatives.RepresentativeInfoByAddress failed.", ex);
            }
        }
        public class RepresentativesRepresentativeInfoByDivisionOptionalParms
        {
            /// A list of office levels to filter by. Only offices that serve at least one of these levels will be returned. Divisions that don't contain a matching office will not be returned.
            public string Levels { get; set; }  
            /// If true, information about all divisions contained in the division requested will be included as well. For example, if querying ocd-division/country:us/district:dc, this would also return all DC's wards and ANCs.
            public bool? Recursive { get; set; }  
            /// A list of office roles to filter by. Only offices fulfilling one of these roles will be returned. Divisions that don't contain a matching office will not be returned.
            public string Roles { get; set; }  
        
        }
 
        /// <summary>
        /// Looks up representative information for a single geographic division. 
        /// Documentation https://developers.google.com/civicinfo/v2/reference/representatives/representativeInfoByDivision
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Civicinfo service.</param>  
        /// <param name="ocdId">The Open Civic Data division identifier of the division to look up.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>RepresentativeInfoDataResponse</returns>
        public static RepresentativeInfoData RepresentativeInfoByDivision(CivicinfoService service, string ocdId, RepresentativesRepresentativeInfoByDivisionOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (ocdId == null)
                    throw new ArgumentNullException(ocdId);

                // Building the initial request.
                var request = service.Representatives.RepresentativeInfoByDivision(ocdId);

                // Applying optional parameters to the request.                
                request = (RepresentativesResource.RepresentativeInfoByDivisionRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Representatives.RepresentativeInfoByDivision failed.", ex);
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