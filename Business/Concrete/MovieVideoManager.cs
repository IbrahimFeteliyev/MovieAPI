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
        public MovieVideoManager(IMovieVideoDal movieVideoDal)
        {
            _movieVideoDal = movieVideoDal;
        }

        public void AddMovieVideo(MovieVideoDTO movievideo)
        {
            MovieVideo video = new()
            {
                VideoUrl = movievideo.VideoUrl,
                VideoName = movievideo.VideName,
            };
            _movieVideoDal.Add(video);
        }
       
    }
}
