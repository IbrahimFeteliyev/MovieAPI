using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovieDal : EfEntityRepositoryBase<Movie, MovieDbContext>, IMovieDal
    {
        public MovieDTO FindById(int id)
        {
            using (MovieDbContext context = new())
            {
                var movie = context.Movies.Include(x => x.Category).Include(x => x.MovieCast).FirstOrDefault(x => x.Id == id); 
                var movieVideos = context.MovieVideos.Where(x => x.MovieId == id).ToList();
                var movieCast = context.MovieCasts.Where(x => x.MovieId == id).ToList();

                List<string> videos = new();
                foreach (var item in movieVideos)
                {
                    videos.Add(item.VideoUrl);
                }

                List<string> movieNames = new();
                foreach (var item in movieVideos)
                {
                    movieNames.Add(item.VideoName);
                }
                List<string> casts = new();
                foreach (var item in movieCast)
                {
                    casts.Add(item.CastPhoto);
                }

                List<string> castNames = new();
                foreach (var item in movieCast)
                {
                    castNames.Add(item.CastName);
                }

                MovieDTO result = new()
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    Description = movie.Description,
                    PosterImage = movie.PosterImage,
                    BackgroundImage = movie.BackgroundImage,
                    CategoryName = movie.Category.Name,
                    VideoUrl = videos,
                    VideoName = movieNames,
                    CastPhotos = casts,
                    CastNames = castNames,

                };  

                return result;
            }
        }

        public List<MovieDTO> GetAllMovie()
        {
            using (MovieDbContext context = new())
            {
                var movie = context.Movies.Include(x => x.Category).Include(x=>x.MovieCast).Include(x => x.MovieVideo).ToList();

                var movieVideo = context.MovieVideos;
                var movieCast = context.MovieCasts;

                List<MovieDTO> result = new();

                for (int i = 0; i < movie.Count; i++)
                {
                    List<string> videos = new();
                    foreach (var item in movieVideo.Where(x => x.MovieId == movie[i].Id))
                    {
                        videos.Add(item.VideoUrl);
                    }

                    List<string> movieNames = new();
                    foreach (var item in movieVideo.Where(x => x.MovieId == movie[i].Id))
                    {
                        movieNames.Add(item.VideoName);
                    }

                    List<string> casts = new();
                    foreach (var item in movieCast.Where(x => x.MovieId == movie[i].Id))
                    {
                        casts.Add(item.CastPhoto); 
                    }

                    List<string> castNames = new();
                    foreach (var item in movieCast.Where(x => x.MovieId == movie[i].Id))
                    {
                        castNames.Add(item.CastName);
                    }


                    MovieDTO movieList = new()
                    {
                        Id = movie[i].Id,
                        Name = movie[i].Name,
                        Description = movie[i].Description,
                        PosterImage = movie[i].PosterImage,
                        BackgroundImage = movie[i].BackgroundImage,
                        CategoryName = movie[i].Category.Name,
                        VideoUrl = videos,
                        VideoName = movieNames,
                        CastPhotos = casts,
                        CastNames = castNames

                    };
                    result.Add(movieList);

                }

                


                return result;

            }
        }
    }
}
