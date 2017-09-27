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
// Unoffical sample for the Fusiontables v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for working with Fusion Tables data.
// API Documentation Link https://developers.google.com/fusiontables
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Fusiontables/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Fusiontables.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Fusiontables.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Fusiontables.v2;
using Google.Apis.Fusiontables.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Fusiontablesv2.Methods
{
  
    public static class TemplateSample
    {


        /// <summary>
        /// Deletes a template 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/template/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Table from which the template is being deleted</param>
        /// <param name="templateId">Identifier for the template which is being deleted</param>
        public static void Delete(FusiontablesService service, string tableId, int? templateId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);
                if (templateId == null)
                    throw new ArgumentNullException(templateId);

                // Make the request.
                 service.Template.Delete(tableId, templateId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Template.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a specific template by its id 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/template/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Table to which the template belongs</param>
        /// <param name="templateId">Identifier for the template that is being requested</param>
        /// <returns>TemplateResponse</returns>
        public static Template Get(FusiontablesService service, string tableId, int? templateId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);
                if (templateId == null)
                    throw new ArgumentNullException(templateId);

                // Make the request.
                return service.Template.Get(tableId, templateId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Template.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new template for the table. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/template/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Table for which a new template is being created</param>
        /// <param name="body">A valid Fusiontables v2 body.</param>
        /// <returns>TemplateResponse</returns>
        public static Template Insert(FusiontablesService service, string tableId, Template body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Make the request.
                return service.Template.Insert(body, tableId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Template.Insert failed.", ex);
            }
        }
        public class TemplateListOptionalParms
        {
            /// Maximum number of templates to return. Optional. Default is 5.
            public int? MaxResults { get; set; }  
            /// Continuation token specifying which results page to return. Optional.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of templates. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/template/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Identifier for the table whose templates are being requested</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TemplateListResponse</returns>
        public static TemplateList List(FusiontablesService service, string tableId, TemplateListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Template.List(tableId);

                // Applying optional parameters to the request.                
                request = (TemplateResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Template.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing template. This method supports patch semantics. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/template/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Table to which the updated template belongs</param>
        /// <param name="templateId">Identifier for the template that is being updated</param>
        /// <param name="body">A valid Fusiontables v2 body.</param>
        /// <returns>TemplateResponse</returns>
        public static Template Patch(FusiontablesService service, string tableId, int? templateId, Template body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);
                if (templateId == null)
                    throw new ArgumentNullException(templateId);

                // Make the request.
                return service.Template.Patch(body, tableId, templateId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Template.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing template 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/template/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Table to which the updated template belongs</param>
        /// <param name="templateId">Identifier for the template that is being updated</param>
        /// <param name="body">A valid Fusiontables v2 body.</param>
        /// <returns>TemplateResponse</returns>
        public static Template Update(FusiontablesService service, string tableId, int? templateId, Template body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);
                if (templateId == null)
                    throw new ArgumentNullException(templateId);

                // Make the request.
                return service.Template.Update(body, tableId, templateId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Template.Update failed.", ex);
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