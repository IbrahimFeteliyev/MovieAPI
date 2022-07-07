using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieManager
    {
        List<Movie> GetAllMovies();
        List<MovieDTO> GetAllMovieList();
        MovieDTO GetMovieById(int id);
        void AddMovie(AddMovieDTO movie);
    }
}
 