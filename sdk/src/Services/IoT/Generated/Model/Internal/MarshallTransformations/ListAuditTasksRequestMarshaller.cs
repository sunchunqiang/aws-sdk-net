/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAuditTasks Request Marshaller
    /// </summary>       
    public class ListAuditTasksRequestMarshaller : IMarshaller<IRequest, ListAuditTasksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAuditTasksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAuditTasksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.HttpMethod = "GET";

            string uriResourcePath = "/audit/tasks";
            
            if (publicRequest.IsSetEndTimeUtc())
                request.Parameters.Add("endTime", StringUtils.FromDateTimeToISO8601(publicRequest.EndTimeUtc));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStartTimeUtc())
                request.Parameters.Add("startTime", StringUtils.FromDateTimeToISO8601(publicRequest.StartTimeUtc));
            
            if (publicRequest.IsSetTaskStatus())
                request.Parameters.Add("taskStatus", StringUtils.FromString(publicRequest.TaskStatus));
            
            if (publicRequest.IsSetTaskType())
                request.Parameters.Add("taskType", StringUtils.FromString(publicRequest.TaskType));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static ListAuditTasksRequestMarshaller _instance = new ListAuditTasksRequestMarshaller();        

        internal static ListAuditTasksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAuditTasksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}