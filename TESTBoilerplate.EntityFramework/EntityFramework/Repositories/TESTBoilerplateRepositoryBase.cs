using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TESTBoilerplate.EntityFramework.Repositories
{
    public abstract class TESTBoilerplateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TESTBoilerplateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TESTBoilerplateRepositoryBase(IDbContextProvider<TESTBoilerplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TESTBoilerplateRepositoryBase<TEntity> : TESTBoilerplateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TESTBoilerplateRepositoryBase(IDbContextProvider<TESTBoilerplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
