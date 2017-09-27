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
// Unoffical sample for the Youtube v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Supports core YouTube features, such as uploading videos, creating and managing playlists, searching for content, and much more.
// API Documentation Link https://developers.google.com/youtube/v3
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Youtube/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Youtube.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Youtube.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Youtube.v3;
using Google.Apis.Youtube.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Youtubev3.Methods
{
  
    public static class CommentThreadsSample
    {


        /// <summary>
        /// Creates a new top-level comment. To add a reply to an existing comment, use the comments.insert method instead. 
        /// Documentation https://developers.google.com/youtube/v3/reference/commentThreads/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter identifies the properties that the API response will include. Set the parameter value to snippet. The snippet part has a quota cost of 2 units.</param>
        /// <param name="body">A valid Youtube v3 body.</param>
        /// <returns>CommentThreadResponse</returns>
        public static CommentThread Insert(YoutubeService service, string part, CommentThread body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Make the request.
                return service.CommentThreads.Insert(body, part).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CommentThreads.Insert failed.", ex);
            }
        }
        public class CommentThreadsListOptionalParms
        {
            /// The allThreadsRelatedToChannelId parameter instructs the API to return all comment threads associated with the specified channel. The response can include comments about the channel or about the channel's videos.
            public string AllThreadsRelatedToChannelId { get; set; }  
            /// The channelId parameter instructs the API to return comment threads containing comments about the specified channel. (The response will not include comments left on videos that the channel uploaded.)
            public string ChannelId { get; set; }  
            /// The id parameter specifies a comma-separated list of comment thread IDs for the resources that should be retrieved.
            public string Id { get; set; }  
            /// The maxResults parameter specifies the maximum number of items that should be returned in the result set.Note: This parameter is not supported for use in conjunction with the id parameter.
            public int? MaxResults { get; set; }  
            /// Set this parameter to limit the returned comment threads to a particular moderation state.Note: This parameter is not supported for use in conjunction with the id parameter.
            public string ModerationStatus { get; set; }  
            /// The order parameter specifies the order in which the API response should list comment threads. Valid values are: - time - Comment threads are ordered by time. This is the default behavior.- relevance - Comment threads are ordered by relevance.Note: This parameter is not supported for use in conjunction with the id parameter.
            public string Order { get; set; }  
            /// The pageToken parameter identifies a specific page in the result set that should be returned. In an API response, the nextPageToken property identifies the next page of the result that can be retrieved.Note: This parameter is not supported for use in conjunction with the id parameter.
            public string PageToken { get; set; }  
            /// The searchTerms parameter instructs the API to limit the API response to only contain comments that contain the specified search terms.Note: This parameter is not supported for use in conjunction with the id parameter.
            public string SearchTerms { get; set; }  
            /// Set this parameter's value to html or plainText to instruct the API to return the comments left by users in html formatted or in plain text.
            public string TextFormat { get; set; }  
            /// The videoId parameter instructs the API to return comment threads associated with the specified video ID.
            public string VideoId { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of comment threads that match the API request parameters. 
        /// Documentation https://developers.google.com/youtube/v3/reference/commentThreads/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter specifies a comma-separated list of one or more commentThread resource properties that the API response will include.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentThreadListResponseResponse</returns>
        public static CommentThreadListResponse List(YoutubeService service, string part, CommentThreadsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Building the initial request.
                var request = service.CommentThreads.List(part);

                // Applying optional parameters to the request.                
                request = (CommentThreadsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CommentThreads.List failed.", ex);
            }
        }

        /// <summary>
        /// Modifies the top-level comment in a comment thread. 
        /// Documentation https://developers.google.com/youtube/v3/reference/commentThreads/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter specifies a comma-separated list of commentThread resource properties that the API response will include. You must at least include the snippet part in the parameter value since that part contains all of the properties that the API request can update.</param>
        /// <param name="body">A valid Youtube v3 body.</param>
        /// <returns>CommentThreadResponse</returns>
        public static CommentThread Update(YoutubeService service, string part, CommentThread body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Make the request.
                return service.CommentThreads.Update(body, part).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CommentThreads.Update failed.", ex);
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