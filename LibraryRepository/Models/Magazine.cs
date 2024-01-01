using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class Magazine : Publication
    {
        public int IssueNumber { get; set; }
        public string Topic { get; set; }
    }
}
