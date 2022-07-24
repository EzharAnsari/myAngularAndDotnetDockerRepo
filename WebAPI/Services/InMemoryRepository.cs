using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public class InMemoryRepository
    {
        private List<Genre> _genres;

        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id=1, Name="Comedy"},
                new Genre(){Id=2, Name="Action"},
                new Genre(){Id=3, Name="Mystry"}
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }
    }
}
