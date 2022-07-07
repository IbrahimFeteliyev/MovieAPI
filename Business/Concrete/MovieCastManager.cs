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
    public class MovieCastManager : IMovieCastManager
    {
        private readonly IMovieCastDal _movieCastDal;

        public MovieCastManager(IMovieCastDal movieCastDal)
        {
            _movieCastDal = movieCastDal;
        }

        public void AddMovieCast(MovieCastDTO moviecast)
        {
            MovieCast cast = new()
            {
                MovieId = moviecast.MovieId,
                CastName = moviecast.CastName,
                CastPhoto = moviecast.CastPhoto,
            };
            _movieCastDal.Add(cast);
        }
    }
}
