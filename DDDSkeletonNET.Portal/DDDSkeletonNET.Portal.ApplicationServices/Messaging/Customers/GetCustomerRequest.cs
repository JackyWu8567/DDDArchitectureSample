using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers
{
    public class GetCustomerRequest : IntegerIdRequest
    {
        public GetCustomerRequest(int customerId) : base(customerId)
        { }
    }

}
