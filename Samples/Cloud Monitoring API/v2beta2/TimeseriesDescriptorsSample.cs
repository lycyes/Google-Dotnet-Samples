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
// Unoffical sample for the Cloudmonitoring v2beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses Google Cloud Monitoring data.
// API Documentation Link https://cloud.google.com/monitoring/v2beta2/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudmonitoring/v2beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudmonitoring.v2beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudmonitoring.v2beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudmonitoring.v2beta2;
using Google.Apis.Cloudmonitoring.v2beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudmonitoringv2beta2.Methods
{
  
    public static class TimeseriesDescriptorsSample
    {

        public class TimeseriesDescriptorsListOptionalParms
        {
            /// The aggregation function that will reduce the data points in each window to a single point. This parameter is only valid for non-cumulative metrics with a value type of INT64 or DOUBLE.
            public string Aggregator { get; set; }  
            /// Maximum number of time series descriptors per page. Used for pagination. If not specified, count = 100.
            public int? Count { get; set; }  
            /// A collection of labels for the matching time series, which are represented as:  - key==value: key equals the value - key=~value: key regex matches the value - key!=value: key does not equal the value - key!~value: key regex does not match the value  For example, to list all of the time series descriptors for the region us-central1, you could specify:label=cloud.googleapis.com%2Flocation=~us-central1.*
            public string Labels { get; set; }  
            /// Start of the time interval (exclusive), which is expressed as an RFC 3339 timestamp. If neither oldest nor timespan is specified, the default time interval will be (youngest - 4 hours, youngest]
            public string Oldest { get; set; }  
            /// The pagination token, which is used to page through large result sets. Set this value to the value of the nextPageToken to retrieve the next page of results.
            public string PageToken { get; set; }  
            /// Length of the time interval to query, which is an alternative way to declare the interval: (youngest - timespan, youngest]. The timespan and oldest parameters should not be used together. Units:  - s: second - m: minute - h: hour - d: day - w: week  Examples: 2s, 3m, 4w. Only one unit is allowed, for example: 2w3d is not allowed; you should use 17d instead.If neither oldest nor timespan is specified, the default time interval will be (youngest - 4 hours, youngest].
            public string Timespan { get; set; }  
            /// The sampling window. At most one data point will be returned for each window in the requested time interval. This parameter is only valid for non-cumulative metric types. Units:  - m: minute - h: hour - d: day - w: week  Examples: 3m, 4w. Only one unit is allowed, for example: 2w3d is not allowed; you should use 17d instead.
            public string Window { get; set; }  
        
        }
 
        /// <summary>
        /// List the descriptors of the time series that match the metric and labels values and that have data points in the interval. Large responses are paginated; use the nextPageToken returned in the response to request subsequent pages of results by setting the pageToken query parameter to the value of the nextPageToken. 
        /// Documentation https://developers.google.com/cloudmonitoring/v2beta2/reference/timeseriesDescriptors/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudmonitoring service.</param>  
        /// <param name="project">The project ID to which this time series belongs. The value can be the numeric project ID or string-based project name.</param>
        /// <param name="metric">Metric names are protocol-free URLs as listed in the Supported Metrics page. For example, compute.googleapis.com/instance/disk/read_ops_count.</param>
        /// <param name="youngest">End of the time interval (inclusive), which is expressed as an RFC 3339 timestamp.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListTimeseriesDescriptorsResponseResponse</returns>
        public static ListTimeseriesDescriptorsResponse List(CloudmonitoringService service, string project, string metric, string youngest, TimeseriesDescriptorsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (metric == null)
                    throw new ArgumentNullException(metric);
                if (youngest == null)
                    throw new ArgumentNullException(youngest);

                // Building the initial request.
                var request = service.TimeseriesDescriptors.List(project, metric, youngest);

                // Applying optional parameters to the request.                
                request = (TimeseriesDescriptorsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TimeseriesDescriptors.List failed.", ex);
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