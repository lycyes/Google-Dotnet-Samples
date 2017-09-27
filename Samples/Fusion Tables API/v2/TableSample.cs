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
  
    public static class TableSample
    {

        public class TableCopyOptionalParms
        {
            /// Whether to also copy tabs, styles, and templates. Default is false.
            public bool? CopyPresentation { get; set; }  
        
        }
 
        /// <summary>
        /// Copies a table. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/copy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being copied.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TableResponse</returns>
        public static Table Copy(FusiontablesService service, string tableId, TableCopyOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.Copy(tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.CopyRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Copy failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a table. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">ID of the table to be deleted.</param>
        public static void Delete(FusiontablesService service, string tableId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Make the request.
                 service.Table.Delete(tableId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a specific table by its ID. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Identifier for the table being requested.</param>
        /// <returns>TableResponse</returns>
        public static Table Get(FusiontablesService service, string tableId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Make the request.
                return service.Table.Get(tableId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Get failed.", ex);
            }
        }
        public class TableImportRowsOptionalParms
        {
            /// The delimiter used to separate cell values. This can only consist of a single character. Default is ,.
            public string Delimiter { get; set; }  
            /// The encoding of the content. Default is UTF-8. Use auto-detect if you are unsure of the encoding.
            public string Encoding { get; set; }  
            /// The index of the line up to which data will be imported. Default is to import the entire file. If endLine is negative, it is an offset from the end of the file; the imported content will exclude the last endLine lines.
            public int? EndLine { get; set; }  
            /// Whether the imported CSV must have the same number of values for each row. If false, rows with fewer values will be padded with empty values. Default is true.
            public bool? IsStrict { get; set; }  
            /// The index of the first line from which to start importing, inclusive. Default is 0.
            public int? StartLine { get; set; }  
        
        }
 
        /// <summary>
        /// Imports more rows into a table. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/importRows
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">The table into which new rows are being imported.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ImportResponse</returns>
        public static Import ImportRows(FusiontablesService service, string tableId, TableImportRowsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.ImportRows(tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.ImportRowsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.ImportRows failed.", ex);
            }
        }
        public class TableImportTableOptionalParms
        {
            /// The delimiter used to separate cell values. This can only consist of a single character. Default is ,.
            public string Delimiter { get; set; }  
            /// The encoding of the content. Default is UTF-8. Use auto-detect if you are unsure of the encoding.
            public string Encoding { get; set; }  
        
        }
 
        /// <summary>
        /// Imports a new table. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/importTable
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="name">The name to be assigned to the new table.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TableResponse</returns>
        public static Table ImportTable(FusiontablesService service, string name, TableImportTableOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Table.ImportTable(name);

                // Applying optional parameters to the request.                
                request = (TableResource.ImportTableRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.ImportTable failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new table. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="body">A valid Fusiontables v2 body.</param>
        /// <returns>TableResponse</returns>
        public static Table Insert(FusiontablesService service, Table body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Table.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Insert failed.", ex);
            }
        }
        public class TableListOptionalParms
        {
            /// Maximum number of tables to return. Default is 5.
            public int? MaxResults { get; set; }  
            /// Continuation token specifying which result page to return.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of tables a user owns. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TableListResponse</returns>
        public static TableList List(FusiontablesService service, TableListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Table.List();

                // Applying optional parameters to the request.                
                request = (TableResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.List failed.", ex);
            }
        }
        public class TablePatchOptionalParms
        {
            /// Whether the view definition is also updated. The specified view definition replaces the existing one. Only a view can be updated with a new definition.
            public bool? ReplaceViewDefinition { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an existing table. Unless explicitly requested, only the name, description, and attribution will be updated. This method supports patch semantics. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being updated.</param>
        /// <param name="body">A valid Fusiontables v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TableResponse</returns>
        public static Table Patch(FusiontablesService service, string tableId, Table body, TablePatchOptionalParms optional = null)
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

                // Building the initial request.
                var request = service.Table.Patch(body, tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Patch failed.", ex);
            }
        }
        public class TableReplaceRowsOptionalParms
        {
            /// The delimiter used to separate cell values. This can only consist of a single character. Default is ,.
            public string Delimiter { get; set; }  
            /// The encoding of the content. Default is UTF-8. Use 'auto-detect' if you are unsure of the encoding.
            public string Encoding { get; set; }  
            /// The index of the line up to which data will be imported. Default is to import the entire file. If endLine is negative, it is an offset from the end of the file; the imported content will exclude the last endLine lines.
            public int? EndLine { get; set; }  
            /// Whether the imported CSV must have the same number of column values for each row. If true, throws an exception if the CSV does not have the same number of columns. If false, rows with fewer column values will be padded with empty values. Default is true.
            public bool? IsStrict { get; set; }  
            /// The index of the first line from which to start importing, inclusive. Default is 0.
            public int? StartLine { get; set; }  
        
        }
 
        /// <summary>
        /// Replaces rows of an existing table. Current rows remain visible until all replacement rows are ready. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/replaceRows
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">Table whose rows will be replaced.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TaskResponse</returns>
        public static Task ReplaceRows(FusiontablesService service, string tableId, TableReplaceRowsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (tableId == null)
                    throw new ArgumentNullException(tableId);

                // Building the initial request.
                var request = service.Table.ReplaceRows(tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.ReplaceRowsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.ReplaceRows failed.", ex);
            }
        }
        public class TableUpdateOptionalParms
        {
            /// Whether the view definition is also updated. The specified view definition replaces the existing one. Only a view can be updated with a new definition.
            public bool? ReplaceViewDefinition { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an existing table. Unless explicitly requested, only the name, description, and attribution will be updated. 
        /// Documentation https://developers.google.com/fusiontables/v2/reference/table/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Fusiontables service.</param>  
        /// <param name="tableId">ID of the table that is being updated.</param>
        /// <param name="body">A valid Fusiontables v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TableResponse</returns>
        public static Table Update(FusiontablesService service, string tableId, Table body, TableUpdateOptionalParms optional = null)
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

                // Building the initial request.
                var request = service.Table.Update(body, tableId);

                // Applying optional parameters to the request.                
                request = (TableResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Table.Update failed.", ex);
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