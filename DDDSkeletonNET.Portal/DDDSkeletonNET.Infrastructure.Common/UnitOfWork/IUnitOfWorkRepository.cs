using DDDSkeletonNET.Infrastructure.Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Infrastructure.Common.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        void PersistInsertion(IAggregateRoot aggregateRoot);
        void PersistUpdate(IAggregateRoot aggregateRoot);
        void PersistDeletion(IAggregateRoot aggregateRoot);
    }
}
