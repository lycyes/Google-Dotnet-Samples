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
// Unoffical sample for the Compute v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and runs virtual machines on Google Cloud Platform.
// API Documentation Link https://developers.google.com/compute/docs/reference/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Compute/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Compute.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Compute.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Compute.v1;
using Google.Apis.Compute.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Computev1.Methods
{
  
    public static class TargetPoolsSample
    {

        public class TargetPoolsAddHealthCheckOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Adds health check URLs to a target pool. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/addHealthCheck
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the target pool to add a health check to.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation AddHealthCheck(ComputeService service, string project, string region, string targetPool, TargetPoolsAddHealthCheckRequest body, TargetPoolsAddHealthCheckOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Building the initial request.
                var request = service.TargetPools.AddHealthCheck(body, project, region, targetPool);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.AddHealthCheckRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.AddHealthCheck failed.", ex);
            }
        }
        public class TargetPoolsAddInstanceOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Adds an instance to a target pool. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/addInstance
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the TargetPool resource to add instances to.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation AddInstance(ComputeService service, string project, string region, string targetPool, TargetPoolsAddInstanceRequest body, TargetPoolsAddInstanceOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Building the initial request.
                var request = service.TargetPools.AddInstance(body, project, region, targetPool);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.AddInstanceRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.AddInstance failed.", ex);
            }
        }
        public class TargetPoolsAggregatedListOptionalParms
        {
            /// Sets a filter {expression} for filtering listed resources. Your {expression} must be in the format: field_name comparison_string literal_string.The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.For example, to filter for instances that do not have a name of example-instance, you would use name ne example-instance.You can filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. Use filtering on nested fields to take advantage of labels to organize and search for results based on label values.To filter on multiple expressions, provide each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests. Acceptable values are 0 to 500, inclusive. (Default: 500)
            public int? MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves an aggregated list of target pools. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/aggregatedList
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TargetPoolAggregatedListResponse</returns>
        public static TargetPoolAggregatedList AggregatedList(ComputeService service, string project, TargetPoolsAggregatedListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.TargetPools.AggregatedList(project);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.AggregatedListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.AggregatedList failed.", ex);
            }
        }
        public class TargetPoolsDeleteOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes the specified target pool. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the TargetPool resource to delete.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(ComputeService service, string project, string region, string targetPool, TargetPoolsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Building the initial request.
                var request = service.TargetPools.Delete(project, region, targetPool);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns the specified target pool. Get a list of available target pools by making a list() request. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the TargetPool resource to return.</param>
        /// <returns>TargetPoolResponse</returns>
        public static TargetPool Get(ComputeService service, string project, string region, string targetPool)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Make the request.
                return service.TargetPools.Get(project, region, targetPool).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.Get failed.", ex);
            }
        }

        /// <summary>
        /// Gets the most recent health check results for each IP for the instance that is referenced by the given target pool. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/getHealth
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the TargetPool resource to which the queried instance belongs.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>TargetPoolInstanceHealthResponse</returns>
        public static TargetPoolInstanceHealth GetHealth(ComputeService service, string project, string region, string targetPool, InstanceReference body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Make the request.
                return service.TargetPools.GetHealth(body, project, region, targetPool).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.GetHealth failed.", ex);
            }
        }
        public class TargetPoolsInsertOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a target pool in the specified project and region using the data included in the request. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(ComputeService service, string project, string region, TargetPool body, TargetPoolsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.TargetPools.Insert(body, project, region);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.Insert failed.", ex);
            }
        }
        public class TargetPoolsListOptionalParms
        {
            /// Sets a filter {expression} for filtering listed resources. Your {expression} must be in the format: field_name comparison_string literal_string.The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.For example, to filter for instances that do not have a name of example-instance, you would use name ne example-instance.You can filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. Use filtering on nested fields to take advantage of labels to organize and search for results based on label values.To filter on multiple expressions, provide each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests. Acceptable values are 0 to 500, inclusive. (Default: 500)
            public int? MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of target pools available to the specified project and region. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TargetPoolListResponse</returns>
        public static TargetPoolList List(ComputeService service, string project, string region, TargetPoolsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.TargetPools.List(project, region);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.List failed.", ex);
            }
        }
        public class TargetPoolsRemoveHealthCheckOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Removes health check URL from a target pool. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/removeHealthCheck
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="targetPool">Name of the target pool to remove health checks from.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation RemoveHealthCheck(ComputeService service, string project, string region, string targetPool, TargetPoolsRemoveHealthCheckRequest body, TargetPoolsRemoveHealthCheckOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Building the initial request.
                var request = service.TargetPools.RemoveHealthCheck(body, project, region, targetPool);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.RemoveHealthCheckRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.RemoveHealthCheck failed.", ex);
            }
        }
        public class TargetPoolsRemoveInstanceOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Removes instance URL from a target pool. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/removeInstance
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the TargetPool resource to remove instances from.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation RemoveInstance(ComputeService service, string project, string region, string targetPool, TargetPoolsRemoveInstanceRequest body, TargetPoolsRemoveInstanceOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Building the initial request.
                var request = service.TargetPools.RemoveInstance(body, project, region, targetPool);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.RemoveInstanceRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.RemoveInstance failed.", ex);
            }
        }
        public class TargetPoolsSetBackupOptionalParms
        {
            /// New failoverRatio value for the target pool.
            public number FailoverRatio { get; set; }  
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Changes a backup target pool's configurations. 
        /// Documentation https://developers.google.com/compute/v1/reference/targetPools/setBackup
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="targetPool">Name of the TargetPool resource to set a backup pool for.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetBackup(ComputeService service, string project, string region, string targetPool, TargetReference body, TargetPoolsSetBackupOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (targetPool == null)
                    throw new ArgumentNullException(targetPool);

                // Building the initial request.
                var request = service.TargetPools.SetBackup(body, project, region, targetPool);

                // Applying optional parameters to the request.                
                request = (TargetPoolsResource.SetBackupRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TargetPools.SetBackup failed.", ex);
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