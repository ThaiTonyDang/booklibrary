using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Models
{
    public class Publication
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string AuthorName { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime PublicateDate { get; set; }
        public int PointReview { get; set; }
        public int Quantity { get; set; }
    }
}
