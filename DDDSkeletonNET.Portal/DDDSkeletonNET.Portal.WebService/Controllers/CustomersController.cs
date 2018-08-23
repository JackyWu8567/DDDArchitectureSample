using DDDSkeletonNET.Portal.ApplicationServices.Interfaces;
using DDDSkeletonNET.Portal.ApplicationServices.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DDDSkeletonNET.Portal.WebService.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException("CustomerService in CustomersController");
        }

        public HttpResponseMessage Get()
        {
            ServiceResponseBase resp = _customerService.GetAllCustomers();
            return Request.BuildResponse(resp);
        }
    }
}
