using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorldEF.Data
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public int Year { get; set; }

        [Precision(3,1)]
        public decimal Rating { get; set; }


        public List<Genre> Genres { get; set; } = new();
    }
}
