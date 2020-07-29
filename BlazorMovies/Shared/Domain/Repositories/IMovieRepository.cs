using BlazorMovies.Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Domain.Repositories
{
    public interface IMovieRepository : ICrudRepository<Movie>
    {

    }
}
