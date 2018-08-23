using DDDSkeletonNET.Infrastructure.Common.Domain;
using DDDSkeletonNET.Infrastructure.Common.UnitOfWork;
using DDDSkeletonNET.Portal.Repository.Memory.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Portal.Repository.Memory
{
    public abstract class Repository<DomainType,IdType,DatabaseType>:IUnitOfWorkRepository where DomainType:IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;

        public IObjectContextFactory ObjectContextFactory { get; }

        public Repository(IUnitOfWork unitOfWork, IObjectContextFactory objectContextFactory)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException("Unit of work");
            ObjectContextFactory = objectContextFactory ?? throw new ArgumentNullException("Object context factory");
        }

        public abstract DomainType FindBy(IdType id);

        public void PersistDeletion(IAggregateRoot aggregateRoot)
        {
            DatabaseType databaseType = RetrieveDatabaseTypeFrom(aggregateRoot);
            ObjectContextFactory.Create().DeleteEntity<DatabaseType>(databaseType);
        }

        public void PersistInsertion(IAggregateRoot aggregateRoot)
        {
            DatabaseType databaseType = RetrieveDatabaseTypeFrom(aggregateRoot);
            ObjectContextFactory.Create().AddEntity<DatabaseType>(databaseType);
        }

        public void PersistUpdate(IAggregateRoot aggregateRoot)
        {
            DatabaseType databaseType = RetrieveDatabaseTypeFrom(aggregateRoot);
            ObjectContextFactory.Create().UpdateEntity<DatabaseType>(databaseType);
        }

        public void Update(DomainType aggregate)
        {
            _unitOfWork.RegisterUpdate(aggregate, this);
        }

        public void Insert(DomainType aggregate)
        {
            _unitOfWork.RegisterInsertion(aggregate, this);
        }

        public void Delete(DomainType aggregate)
        {
            _unitOfWork.RegisterDeletion(aggregate, this);
        }

        public abstract DatabaseType ConvertToDatabaseType(DomainType domainType);

        private DatabaseType RetrieveDatabaseTypeFrom(IAggregateRoot aggregateRoot)
        {
            DomainType domainType = (DomainType)aggregateRoot;
            DatabaseType databaseType = ConvertToDatabaseType(domainType);
            return databaseType;
        }
    }
}
