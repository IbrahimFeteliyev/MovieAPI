using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PosterImage { get; set; }
        public string BackgroundImage { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<MovieVideo> MovieVideo { get; set; }
        public List<MovieCast> MovieCast { get; set; }


    }
}
