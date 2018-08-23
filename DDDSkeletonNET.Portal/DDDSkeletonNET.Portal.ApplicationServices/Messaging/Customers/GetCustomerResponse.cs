using DDDSkeletonNET.Portal.ApplicationServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class GetCustomerResponse : ServiceResponseBase
    {
        public CustomerViewModel Customer { get; set; }
    }

}
