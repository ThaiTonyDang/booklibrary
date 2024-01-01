using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    public class LibraryManagement
    {
        // thực hiện các chức năng thêm sửa xóa tại đây
        private List<Publication> publications = new List<Publication>();

        public (bool, string) AddDocument<T>(T publication) where T : Publication
        {
            try
            {
                publications.Add(publication);
                return(true, "Đã thêm tài liệu thành công !");
            }
            catch (Exception ex)
            {
                return (false, $"Đã có lỗi xảy ra : {ex.Message}");
            }
        }    

        public List<Publication> GetListDocument()
        {
            return publications.OrderBy(x => x.Heading).ToList();
        }
    }
}
