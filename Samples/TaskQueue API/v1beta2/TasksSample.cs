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
// Unoffical sample for the Taskqueue v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses a Google App Engine Pull Task Queue over REST.
// API Documentation Link https://developers.google.com/appengine/docs/python/taskqueue/rest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Taskqueue/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Taskqueue.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Taskqueue.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Taskqueue.v1beta2;
using Google.Apis.Taskqueue.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Taskqueuev1beta2.Methods
{
  
    public static class TasksSample
    {


        /// <summary>
        /// Delete a task from a TaskQueue. 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The taskqueue to delete a task from.</param>
        /// <param name="task">The id of the task to delete.</param>
        public static void Delete(TaskqueueService service, string project, string taskqueue, string task)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);
                if (task == null)
                    throw new ArgumentNullException(task);

                // Make the request.
                 service.Tasks.Delete(project, taskqueue, task).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Get a particular task from a TaskQueue. 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The taskqueue in which the task belongs.</param>
        /// <param name="task">The task to get properties of.</param>
        /// <returns>TaskResponse</returns>
        public static Task Get(TaskqueueService service, string project, string taskqueue, string task)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);
                if (task == null)
                    throw new ArgumentNullException(task);

                // Make the request.
                return service.Tasks.Get(project, taskqueue, task).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.Get failed.", ex);
            }
        }

        /// <summary>
        /// Insert a new task in a TaskQueue 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies</param>
        /// <param name="taskqueue">The taskqueue to insert the task into</param>
        /// <param name="body">A valid Taskqueue v1beta2 body.</param>
        /// <returns>TaskResponse</returns>
        public static Task Insert(TaskqueueService service, string project, string taskqueue, Task body)
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
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);

                // Make the request.
                return service.Tasks.Insert(body, project, taskqueue).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.Insert failed.", ex);
            }
        }
        public class TasksLeaseOptionalParms
        {
            /// When true, all returned tasks will have the same tag
            public bool? GroupByTag { get; set; }  
            /// The tag allowed for tasks in the response. Must only be specified if group_by_tag is true. If group_by_tag is true and tag is not specified the tag will be that of the oldest task by eta, i.e. the first available tag
            public string Tag { get; set; }  
        
        }
 
        /// <summary>
        /// Lease 1 or more tasks from a TaskQueue. 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/lease
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The taskqueue to lease a task from.</param>
        /// <param name="numTasks">The number of tasks to lease.</param>
        /// <param name="leaseSecs">The lease in seconds.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TasksResponse</returns>
        public static Tasks Lease(TaskqueueService service, string project, string taskqueue, int? numTasks, int? leaseSecs, TasksLeaseOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);
                if (numTasks == null)
                    throw new ArgumentNullException(numTasks);
                if (leaseSecs == null)
                    throw new ArgumentNullException(leaseSecs);

                // Building the initial request.
                var request = service.Tasks.Lease(project, taskqueue, numTasks, leaseSecs);

                // Applying optional parameters to the request.                
                request = (TasksResource.LeaseRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.Lease failed.", ex);
            }
        }

        /// <summary>
        /// List Tasks in a TaskQueue 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">The id of the taskqueue to list tasks from.</param>
        /// <returns>Tasks2Response</returns>
        public static Tasks2 List(TaskqueueService service, string project, string taskqueue)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);

                // Make the request.
                return service.Tasks.List(project, taskqueue).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.List failed.", ex);
            }
        }

        /// <summary>
        /// Update tasks that are leased out of a TaskQueue. This method supports patch semantics. 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">NA</param>
        /// <param name="task">NA</param>
        /// <param name="newLeaseSeconds">The new lease in seconds.</param>
        /// <param name="body">A valid Taskqueue v1beta2 body.</param>
        /// <returns>TaskResponse</returns>
        public static Task Patch(TaskqueueService service, string project, string taskqueue, string task, int? newLeaseSeconds, Task body)
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
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);
                if (task == null)
                    throw new ArgumentNullException(task);
                if (newLeaseSeconds == null)
                    throw new ArgumentNullException(newLeaseSeconds);

                // Make the request.
                return service.Tasks.Patch(body, project, taskqueue, task, newLeaseSeconds).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Update tasks that are leased out of a TaskQueue. 
        /// Documentation https://developers.google.com/taskqueue/v1beta2/reference/tasks/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Taskqueue service.</param>  
        /// <param name="project">The project under which the queue lies.</param>
        /// <param name="taskqueue">NA</param>
        /// <param name="task">NA</param>
        /// <param name="newLeaseSeconds">The new lease in seconds.</param>
        /// <param name="body">A valid Taskqueue v1beta2 body.</param>
        /// <returns>TaskResponse</returns>
        public static Task Update(TaskqueueService service, string project, string taskqueue, string task, int? newLeaseSeconds, Task body)
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
                if (taskqueue == null)
                    throw new ArgumentNullException(taskqueue);
                if (task == null)
                    throw new ArgumentNullException(task);
                if (newLeaseSeconds == null)
                    throw new ArgumentNullException(newLeaseSeconds);

                // Make the request.
                return service.Tasks.Update(body, project, taskqueue, task, newLeaseSeconds).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Tasks.Update failed.", ex);
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