using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieGenreManager : IMovieGenreManager
    {
        private readonly IMovieGenreDal _movieGenreDal;

        public MovieGenreManager(IMovieGenreDal movieGenreDal)
        {
            _movieGenreDal = movieGenreDal;
        }

        public void AddMovieGenre(MovieGenreDTO moviegenre)
        {
            MovieGenre genre = new()
            {
                GenreName = moviegenre.GenreName,
            };
            _movieGenreDal.Add(genre);
        }
    }
}
