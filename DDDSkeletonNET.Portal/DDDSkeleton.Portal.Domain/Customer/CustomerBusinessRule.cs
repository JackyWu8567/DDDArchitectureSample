using DDDSkeletonNET.Infrastructure.Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeleton.Portal.Domain.Customer
{
    public class CustomerBusinessRule
    {
        public static readonly BusinessRule CustomerNameRequired = new BusinessRule("A customer must have a name.");
    }
}
