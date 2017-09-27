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
// Unoffical sample for the Androidenterprise v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages the deployment of apps to Android for Work users.
// API Documentation Link https://developers.google.com/android/work/play/emm-api
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Androidenterprise/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Androidenterprise.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Androidenterprise.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Androidenterprise.v1;
using Google.Apis.Androidenterprise.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Androidenterprisev1.Methods
{
  
    public static class EnterprisesSample
    {

        public class EnterprisesAcknowledgeNotificationSetOptionalParms
        {
            /// The notification set ID as returned by Enterprises.PullNotificationSet. This must be provided.
            public string NotificationSetId { get; set; }  
        
        }
 
        /// <summary>
        /// Acknowledges notifications that were received from Enterprises.PullNotificationSet to prevent subsequent calls from returning the same notifications. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/acknowledgeNotificationSet
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        public static void AcknowledgeNotificationSet(AndroidenterpriseService service, EnterprisesAcknowledgeNotificationSetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Enterprises.AcknowledgeNotificationSet();

                // Applying optional parameters to the request.                
                request = (EnterprisesResource.AcknowledgeNotificationSetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.AcknowledgeNotificationSet failed.", ex);
            }
        }
        public class EnterprisesCompleteSignupOptionalParms
        {
            /// The Completion token initially returned by GenerateSignupUrl.
            public string CompletionToken { get; set; }  
            /// The Enterprise token appended to the Callback URL.
            public string EnterpriseToken { get; set; }  
        
        }
 
        /// <summary>
        /// Completes the signup flow, by specifying the Completion token and Enterprise token. This request must not be called multiple times for a given Enterprise Token. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/completeSignup
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>EnterpriseResponse</returns>
        public static Enterprise CompleteSignup(AndroidenterpriseService service, EnterprisesCompleteSignupOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Enterprises.CompleteSignup();

                // Applying optional parameters to the request.                
                request = (EnterprisesResource.CompleteSignupRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.CompleteSignup failed.", ex);
            }
        }

        /// <summary>
        /// Returns a unique token to access an embeddable UI. To generate a web UI, pass the generated token into the managed Google Play javascript API. Each token may only be used to start one UI session. See the javascript API documentation for further information. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/createWebToken
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>AdministratorWebTokenResponse</returns>
        public static AdministratorWebToken CreateWebToken(AndroidenterpriseService service, string enterpriseId, AdministratorWebTokenSpec body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.CreateWebToken(body, enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.CreateWebToken failed.", ex);
            }
        }

        /// <summary>
        /// Deletes the binding between the EMM and enterprise. This is now deprecated. Use this method only to unenroll customers that were previously enrolled with the insert call, then enroll them again with the enroll call. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public static void Delete(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                 service.Enterprises.Delete(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Enrolls an enterprise with the calling EMM. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/enroll
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="token">The token provided by the enterprise to register the EMM.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>EnterpriseResponse</returns>
        public static Enterprise Enroll(AndroidenterpriseService service, string token, Enterprise body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (token == null)
                    throw new ArgumentNullException(token);

                // Make the request.
                return service.Enterprises.Enroll(body, token).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.Enroll failed.", ex);
            }
        }
        public class EnterprisesGenerateSignupUrlOptionalParms
        {
            /// The callback URL to which the Admin will be redirected after successfully creating an enterprise. Before redirecting there the system will add a single query parameter to this URL named "enterpriseToken" which will contain an opaque token to be used for the CompleteSignup request.Beware that this means that the URL will be parsed, the parameter added and then a new URL formatted, i.e. there may be some minor formatting changes and, more importantly, the URL must be well-formed so that it can be parsed.
            public string CallbackUrl { get; set; }  
        
        }
 
        /// <summary>
        /// Generates a sign-up URL. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/generateSignupUrl
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SignupInfoResponse</returns>
        public static SignupInfo GenerateSignupUrl(AndroidenterpriseService service, EnterprisesGenerateSignupUrlOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Enterprises.GenerateSignupUrl();

                // Applying optional parameters to the request.                
                request = (EnterprisesResource.GenerateSignupUrlRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.GenerateSignupUrl failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the name and domain of an enterprise. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <returns>EnterpriseResponse</returns>
        public static Enterprise Get(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.Get(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.Get failed.", ex);
            }
        }

        /// <summary>
        /// Returns the Android Device Policy config resource. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/getAndroidDevicePolicyConfig
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <returns>AndroidDevicePolicyConfigResponse</returns>
        public static AndroidDevicePolicyConfig GetAndroidDevicePolicyConfig(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.GetAndroidDevicePolicyConfig(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.GetAndroidDevicePolicyConfig failed.", ex);
            }
        }
        public class EnterprisesGetServiceAccountOptionalParms
        {
            /// The type of credential to return with the service account. Required.
            public string KeyType { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a service account and credentials. The service account can be bound to the enterprise by calling setAccount. The service account is unique to this enterprise and EMM, and will be deleted if the enterprise is unbound. The credentials contain private key data and are not stored server-side.This method can only be called after calling Enterprises.Enroll or Enterprises.CompleteSignup, and before Enterprises.SetAccount; at other times it will return an error.Subsequent calls after the first will generate a new, unique set of credentials, and invalidate the previously generated credentials.Once the service account is bound to the enterprise, it can be managed using the serviceAccountKeys resource. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/getServiceAccount
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ServiceAccountResponse</returns>
        public static ServiceAccount GetServiceAccount(AndroidenterpriseService service, string enterpriseId, EnterprisesGetServiceAccountOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Building the initial request.
                var request = service.Enterprises.GetServiceAccount(enterpriseId);

                // Applying optional parameters to the request.                
                request = (EnterprisesResource.GetServiceAccountRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.GetServiceAccount failed.", ex);
            }
        }

        /// <summary>
        /// Returns the store layout for the enterprise. If the store layout has not been set, returns "basic" as the store layout type and no homepage. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/getStoreLayout
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <returns>StoreLayoutResponse</returns>
        public static StoreLayout GetStoreLayout(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.GetStoreLayout(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.GetStoreLayout failed.", ex);
            }
        }

        /// <summary>
        /// Establishes the binding between the EMM and an enterprise. This is now deprecated; use enroll instead. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="token">The token provided by the enterprise to register the EMM.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>EnterpriseResponse</returns>
        public static Enterprise Insert(AndroidenterpriseService service, string token, Enterprise body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (token == null)
                    throw new ArgumentNullException(token);

                // Make the request.
                return service.Enterprises.Insert(body, token).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Looks up an enterprise by domain name. This is only supported for enterprises created via the Google-initiated creation flow. Lookup of the id is not needed for enterprises created via the EMM-initiated flow since the EMM learns the enterprise ID in the callback specified in the Enterprises.generateSignupUrl call. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="domain">The exact primary domain name of the enterprise to look up.</param>
        /// <returns>EnterprisesListResponseResponse</returns>
        public static EnterprisesListResponse List(AndroidenterpriseService service, string domain)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (domain == null)
                    throw new ArgumentNullException(domain);

                // Make the request.
                return service.Enterprises.List(domain).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.List failed.", ex);
            }
        }
        public class EnterprisesPullNotificationSetOptionalParms
        {
            /// The request mode for pulling notifications.Specifying waitForNotifications will cause the request to block and wait until one or more notifications are present, or return an empty notification list if no notifications are present after some time.Speciying returnImmediately will cause the request to immediately return the pending notifications, or an empty list if no notifications are present.If omitted, defaults to waitForNotifications.
            public string RequestMode { get; set; }  
        
        }
 
        /// <summary>
        /// Pulls and returns a notification set for the enterprises associated with the service account authenticated for the request. The notification set may be empty if no notification are pending.A notification set returned needs to be acknowledged within 20 seconds by calling Enterprises.AcknowledgeNotificationSet, unless the notification set is empty.Notifications that are not acknowledged within the 20 seconds will eventually be included again in the response to another PullNotificationSet request, and those that are never acknowledged will ultimately be deleted according to the Google Cloud Platform Pub/Sub system policy.Multiple requests might be performed concurrently to retrieve notifications, in which case the pending notifications (if any) will be split among each caller, if any are pending.If no notifications are present, an empty notification list is returned. Subsequent requests may return more notifications once they become available. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/pullNotificationSet
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>NotificationSetResponse</returns>
        public static NotificationSet PullNotificationSet(AndroidenterpriseService service, EnterprisesPullNotificationSetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Enterprises.PullNotificationSet();

                // Applying optional parameters to the request.                
                request = (EnterprisesResource.PullNotificationSetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.PullNotificationSet failed.", ex);
            }
        }

        /// <summary>
        /// Sends a test notification to validate the EMM integration with the Google Cloud Pub/Sub service for this enterprise. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/sendTestPushNotification
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <returns>EnterprisesSendTestPushNotificationResponseResponse</returns>
        public static EnterprisesSendTestPushNotificationResponse SendTestPushNotification(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.SendTestPushNotification(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.SendTestPushNotification failed.", ex);
            }
        }

        /// <summary>
        /// Sets the account that will be used to authenticate to the API as the enterprise. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/setAccount
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>EnterpriseAccountResponse</returns>
        public static EnterpriseAccount SetAccount(AndroidenterpriseService service, string enterpriseId, EnterpriseAccount body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.SetAccount(body, enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.SetAccount failed.", ex);
            }
        }

        /// <summary>
        /// Sets the Android Device Policy config resource. EMM may use this method to enable or disable Android Device Policy support for the specified enterprise. To learn more about managing devices and apps with Android Device Policy, see the Android Management API. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/setAndroidDevicePolicyConfig
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>AndroidDevicePolicyConfigResponse</returns>
        public static AndroidDevicePolicyConfig SetAndroidDevicePolicyConfig(AndroidenterpriseService service, string enterpriseId, AndroidDevicePolicyConfig body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.SetAndroidDevicePolicyConfig(body, enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.SetAndroidDevicePolicyConfig failed.", ex);
            }
        }

        /// <summary>
        /// Sets the store layout for the enterprise. By default, storeLayoutType is set to "basic" and the basic store layout is enabled. The basic layout only contains apps approved by the admin, and that have been added to the available product set for a user (using the  setAvailableProductSet call). Apps on the page are sorted in order of their product ID value. If you create a custom store layout (by setting storeLayoutType = "custom" and setting a homepage), the basic store layout is disabled. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/setStoreLayout
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>StoreLayoutResponse</returns>
        public static StoreLayout SetStoreLayout(AndroidenterpriseService service, string enterpriseId, StoreLayout body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Enterprises.SetStoreLayout(body, enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.SetStoreLayout failed.", ex);
            }
        }

        /// <summary>
        /// Unenrolls an enterprise from the calling EMM. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/enterprises/unenroll
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        public static void Unenroll(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                 service.Enterprises.Unenroll(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Enterprises.Unenroll failed.", ex);
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