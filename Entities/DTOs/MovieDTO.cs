using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PosterImage { get; set; }
        public string BackgroundImage { get; set; }
        public string CategoryName { get; set; }
        public List<string> VideoUrl { get; set; }
        public List<string> VideoName { get; set; }
        public List<string> CastPhotos { get; set; }
        public List<string> CastNames { get; set; }

    }
}
