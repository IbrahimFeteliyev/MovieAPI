using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AddMovieDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PosterImage { get; set; } 
        public string BackgroundImage { get; set; }
        public int CategoryId { get; set; }
        public List<MovieGenreDTO> MovieGenre { get; set; }
        public List<MovieVideoDTO> MovieVideo { get; set; }
        public List<MovieCastDTO> MovieCast { get; set; }
    }
}
