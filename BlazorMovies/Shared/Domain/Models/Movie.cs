using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Domain.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedDate { get; set; }

        public Movie()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
