using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MovieCastDTO
    {
        public int MovieId { get; set; }
        public string CastName { get; set; }
        public string CastPhoto { get; set; }
    }
}
