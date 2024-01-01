using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class TextBook : Publication
    {
        public string EducationLevel { get; set; }
        public string Subject { get; set; }
    }
}
