using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class Book : Publication
    {
        public string Genre { get; set; }
        public string Languare { get; set; }
    }
}
