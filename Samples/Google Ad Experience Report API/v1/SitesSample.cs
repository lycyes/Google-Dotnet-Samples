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
// Unoffical sample for the Adexperiencereport v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: View Ad Experience Report data, and get a list of sites that have a significant number of annoying ads.
// API Documentation Link https://developers.google.com/ad-experience-report/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Adexperiencereport/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Adexperiencereport.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Adexperiencereport.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Adexperiencereport.v1;
using Google.Apis.Adexperiencereport.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Adexperiencereportv1.Methods
{
  
    public static class SitesSample
    {


        /// <summary>
        /// Gets a summary of the ad experience rating of a site. 
        /// Documentation https://developers.google.com/adexperiencereport/v1/reference/sites/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexperiencereport service.</param>  
        /// <param name="name">The required site name. It should be the site property whose ad experiencesmay have been reviewed, and it should be URL-encoded. For example,sites/https%3A%2F%2Fwww.google.com. The server will return an error ofBAD_REQUEST if this field is not filled in. Note that if the site propertyis not yet verified in Search Console, the reportUrl field returned by theAPI will lead to the verification page, prompting the user to go throughthat process before they can gain access to the Ad Experience Report.</param>
        /// <returns>SiteSummaryResponseResponse</returns>
        public static SiteSummaryResponse Get(AdexperiencereportService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Sites.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sites.Get failed.", ex);
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