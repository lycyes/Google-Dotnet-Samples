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
// Unoffical sample for the Shoppingcontent v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages product items, inventory, and Merchant Center accounts for Google Shopping.
// API Documentation Link https://developers.google.com/shopping-content
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Shoppingcontent/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Shoppingcontent.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Shoppingcontent.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Shoppingcontent.v2;
using Google.Apis.Shoppingcontent.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Shoppingcontentv2.Methods
{
  
    public static class ProductstatusesSample
    {

        public class ProductstatusesCustombatchOptionalParms
        {
            /// Flag to include full product data in the results of this request. The default value is false.
            public bool? IncludeAttributes { get; set; }  
        
        }
 
        /// <summary>
        /// Gets the statuses of multiple products in a single request. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/productstatuses/custombatch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ProductstatusesCustomBatchResponseResponse</returns>
        public static ProductstatusesCustomBatchResponse Custombatch(ShoppingcontentService service, ProductstatusesCustomBatchRequest body, ProductstatusesCustombatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Productstatuses.Custombatch(body);

                // Applying optional parameters to the request.                
                request = (ProductstatusesResource.CustombatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Productstatuses.Custombatch failed.", ex);
            }
        }
        public class ProductstatusesGetOptionalParms
        {
            /// Flag to include full product data in the result of this get request. The default value is false.
            public bool? IncludeAttributes { get; set; }  
        
        }
 
        /// <summary>
        /// Gets the status of a product from your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/productstatuses/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="productId">The ID of the product.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ProductStatusResponse</returns>
        public static ProductStatus Get(ShoppingcontentService service, string merchantId, string productId, ProductstatusesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Building the initial request.
                var request = service.Productstatuses.Get(merchantId, productId);

                // Applying optional parameters to the request.                
                request = (ProductstatusesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Productstatuses.Get failed.", ex);
            }
        }
        public class ProductstatusesListOptionalParms
        {
            /// Flag to include full product data in the results of the list request. The default value is false.
            public bool? IncludeAttributes { get; set; }  
            /// Flag to include the invalid inserted items in the result of the list request. By default the invalid items are not shown (the default value is false).
            public bool? IncludeInvalidInsertedItems { get; set; }  
            /// The maximum number of product statuses to return in the response, used for paging.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the statuses of the products in your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/productstatuses/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ProductstatusesListResponseResponse</returns>
        public static ProductstatusesListResponse List(ShoppingcontentService service, string merchantId, ProductstatusesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Building the initial request.
                var request = service.Productstatuses.List(merchantId);

                // Applying optional parameters to the request.                
                request = (ProductstatusesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Productstatuses.List failed.", ex);
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