using DDDSkeletonNET.Portal.ApplicationServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class UpdateCustomerRequest : IntegerIdRequest
    {
        public UpdateCustomerRequest(int customerId) : base(customerId)
        { }

        public CustomerPropertiesViewModel CustomerProperties { get; set; }
    }

}
