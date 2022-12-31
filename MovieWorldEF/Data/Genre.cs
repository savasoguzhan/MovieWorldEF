using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldEF.Data
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Movie> Movies { get; set; } = new();
    }
}
