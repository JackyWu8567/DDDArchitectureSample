using DDDSkeletonNET.Portal.ApplicationServices.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DDDSkeletonNET.Portal
{
    public static class HttpResponseBuilder
    {
        public static HttpResponseMessage BuildResponse(this HttpRequestMessage requestMessage, ServiceResponseBase baseResponse)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            if (baseResponse.Exception != null)
            {
                statusCode = baseResponse.Exception.ConvertToHttpStatusCode();
                HttpResponseMessage message = new HttpResponseMessage(statusCode);
                message.Content = new StringContent(baseResponse.Exception.Message);
                throw new HttpResponseException(message);
            }
            return requestMessage.CreateResponse<ServiceResponseBase>(statusCode, baseResponse);
        }
    }

}