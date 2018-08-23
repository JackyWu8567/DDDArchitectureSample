using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Infrastructure.Common.Domain
{
    public class ValueObjectIsInvalidException : Exception
    {
        public ValueObjectIsInvalidException(string message)
               : base(message)
        { }
    }
}
