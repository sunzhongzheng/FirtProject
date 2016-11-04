using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ThumanSon.EntityFramework.Repositories
{
    public abstract class ThumanSonRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ThumanSonDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ThumanSonRepositoryBase(IDbContextProvider<ThumanSonDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ThumanSonRepositoryBase<TEntity> : ThumanSonRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ThumanSonRepositoryBase(IDbContextProvider<ThumanSonDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
