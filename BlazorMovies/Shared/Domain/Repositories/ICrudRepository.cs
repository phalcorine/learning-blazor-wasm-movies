using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Domain.Repositories
{
    interface ICrudRepository<TEntity>
    {
        IList<TEntity> GetMovies();
    }
}
