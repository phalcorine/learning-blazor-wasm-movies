using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Domain.Repositories
{
    public interface ICrudRepository<TEntity> where TEntity : class
    {
        IList<TEntity> FindAll();

        IList<TEntity> Find(string where);

        IList<TEntity> FindById();
    }
}
