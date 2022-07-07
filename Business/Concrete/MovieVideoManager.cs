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
    public class MovieVideoManager : IMovieVideoManager
    {
        private readonly IMovieVideoDal _movieVideoDal;
        private readonly IMovieCastDal _movieCastDal;
        public MovieVideoManager(IMovieVideoDal movieVideoDal, IMovieCastDal movieCastDal)
        {
            _movieVideoDal = movieVideoDal;
            _movieCastDal = movieCastDal;
        }

        public void AddMovieVideo(MovieVideoDTO movievideo)
        {
            MovieVideo video = new()
            {
                MovieId = movievideo.MovieId,
                VideoUrl = movievideo.VideoUrl,
                VideoName = movievideo.VideName,
            };
            _movieVideoDal.Add(video);
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
