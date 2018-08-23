using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Portal.ApplicationServices.Messaging
{
    public abstract class IntegerIdRequest : ServiceRequestBase
    {
        public IntegerIdRequest(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("ID must be positive.");
            }
            Id = id;
        }

        public int Id { get; }
    }
}
