using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MovieCast : IEntity
    {
        public int Id { get; set; }
        public string CastName { get; set; }
        public string CastPhoto { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
