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
    public class MovieManager : IMovieManager
    {
        private readonly IMovieDal _movieDal;
        private readonly IMovieVideoManager _movieVideoManager;
        private readonly IMovieCastManager _movieCastManager;
        public MovieManager(IMovieDal movieDal, IMovieVideoManager movieVideoManager, IMovieCastManager movieCastManager)
        {
            _movieDal = movieDal;
            _movieVideoManager = movieVideoManager;
            _movieCastManager = movieCastManager;
        }

        public void AddMovie(AddMovieDTO movieDTO)
        {

            Movie movie = new()
            {
                Name = movieDTO.Name,
                Description = movieDTO.Description,
                PosterImage = movieDTO.PosterImage,
                BackgroundImage = movieDTO.BackgroundImage,
                CategoryId = movieDTO.CategoryId,       

            };
            _movieDal.Add(movie);

            for (int i = 0; i < movieDTO.MovieVideo.Count; i++)
            {
                movieDTO.MovieVideo[i].MovieId = movie.Id;
                _movieVideoManager.AddMovieVideo(movieDTO.MovieVideo[i]);
            }

            for (int i = 0; i < movieDTO.MovieCast.Count; i++)
            {
                movieDTO.MovieCast[i].MovieId = movie.Id;
                _movieCastManager.AddMovieCast(movieDTO.MovieCast[i]);
            }



        }

        public List<MovieDTO> GetAllMovieList()
        {
            return _movieDal.GetAllMovie();
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDal.GetAll();
        }


        public MovieDTO GetMovieById(int id)
        {
            return _movieDal.FindById(id);
        }


    }
}
