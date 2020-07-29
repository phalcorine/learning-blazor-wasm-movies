using BlazorMovies.Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Domain.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private IList<Movie> _movies;

        public MovieRepository()
        {
            _movies = GetMovies();
        }

        public IList<Movie> Find(string where)
        {
            throw new NotImplementedException();
        }

        public IList<Movie> FindById()
        {
            throw new NotImplementedException();
        }

        public IList<Movie> FindAll()
        {
            return _movies;
        }

        private IList<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Title = "Mad O!!!",
                    Description = "A mad movie... ",
                    ReleasedDate = new DateTime(2020, 6, 5)
                },
                new Movie()
                {
                    Title = "Attack on Titan: Chronicles",
                    Description = "This is the best movie ever",
                    ReleasedDate = new DateTime(2020, 6, 5)
                },
                new Movie()
                {
                    Title = "Sonic the Hedgehog",
                    Description = "This movie has the greatest comeback",
                    ReleasedDate = new DateTime(2020, 6, 5)
                },
            };
        }
    }
}
