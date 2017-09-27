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
// Unoffical sample for the Cloudbilling v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Allows developers to manage billing for their Google Cloud Platform projects    programmatically.
// API Documentation Link https://cloud.google.com/billing/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudbilling/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudbilling.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudbilling.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudbilling.v1;
using Google.Apis.Cloudbilling.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudbillingv1.Methods
{
  
    public static class ProjectsSample
    {


        /// <summary>
        /// Sets or updates the billing account associated with a project. You specifythe new billing account by setting the `billing_account_name` in the`ProjectBillingInfo` resource to the resource name of a billing account.Associating a project with an open billing account enables billing on theproject and allows charges for resource usage. If the project already had abilling account, this method changes the billing account used for resourceusage charges.*Note:* Incurred charges that have not yet been reported in the transactionhistory of the Google Cloud Console may be billed to the new billingaccount, even if the charge occurred before the new billing account wasassigned to the project.The current authenticated user must have ownership privileges for both the[project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo) and the [billingaccount](https://support.google.com/cloud/answer/4430947).You can disable billing on the project by setting the`billing_account_name` field to empty. This action disassociates thecurrent billing account from the project. Any billable activity of yourin-use services will stop, and your application could stop functioning asexpected. Any unbilled charges to date will be billed to the previouslyassociated account. The current authenticated user must be either an ownerof the project or an owner of the billing account for the project.Note that associating a project with a *closed* billing account will havemuch the same effect as disabling billing on the project: any paidresources used by the project will be shut down. Thus, unless you wish todisable billing, you should always call this method with the name of an*open* billing account. 
        /// Documentation https://developers.google.com/cloudbilling/v1/reference/projects/updateBillingInfo
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbilling service.</param>  
        /// <param name="name">The resource name of the project associated with the billing informationthat you want to update. For example, `projects/tokyo-rain-123`.</param>
        /// <param name="body">A valid Cloudbilling v1 body.</param>
        /// <returns>ProjectBillingInfoResponse</returns>
        public static ProjectBillingInfo UpdateBillingInfo(CloudbillingService service, string name, ProjectBillingInfo body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Projects.UpdateBillingInfo(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.UpdateBillingInfo failed.", ex);
            }
        }

        /// <summary>
        /// Gets the billing information for a project. The current authenticated usermust have [permission to view theproject](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo). 
        /// Documentation https://developers.google.com/cloudbilling/v1/reference/projects/getBillingInfo
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbilling service.</param>  
        /// <param name="name">The resource name of the project for which billing information isretrieved. For example, `projects/tokyo-rain-123`.</param>
        /// <returns>ProjectBillingInfoResponse</returns>
        public static ProjectBillingInfo GetBillingInfo(CloudbillingService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Projects.GetBillingInfo(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetBillingInfo failed.", ex);
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