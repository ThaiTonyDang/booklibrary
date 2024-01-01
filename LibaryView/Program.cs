using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Reflection.Metadata;

namespace LibaryView
{
    internal class Program
    {
        static LibraryManagement libraryManagement = new LibraryManagement();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Loại TÀI LIỆU Bạn muốn nhập thông tin:");
                Console.WriteLine("1. Sách");
                Console.WriteLine("2. Tạp chí");
                Console.WriteLine("2. In ra thông tin tất cả tài liệu");
                Console.WriteLine("4. Thoát");

                Console.Write("Lựa chọn của bạn: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var book = new Book();
                        InputBookInfo(book);
                        var resultbook = AddBook(book);
                        if (resultbook.Item1)
                        {
                            Console.WriteLine(resultbook.Item2);
                        }
                        else
                        {
                            Console.WriteLine($"Thêm thất bại : {resultbook.Item2}");
                        }
                        
                        break;
                    case 2:
                        var magazine = new Magazine();
                        InputMagazineInfo(magazine);
                        var resultmagazine = AddBook(magazine);
                        if (resultmagazine.Item1)
                        {
                            Console.WriteLine(resultmagazine.Item2);
                        }
                        else
                        {
                            Console.WriteLine($"Thêm thất bại : {resultmagazine.Item2}");
                        }

                        break;
                    case 3:
                        PrintDocumentsInfo();
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }

        static void InputCommonPublicationInfo(Publication publication)
        {
            publication.Id = Guid.NewGuid();

            Console.Write("Title: ");
            publication.Heading = Console.ReadLine();
        }

        static void InputBookInfo(Book book)
        {
            InputCommonPublicationInfo(book);

            Console.Write("Genre: ");
            book.Genre = Console.ReadLine();

            Console.Write("Language: ");
            book.Language = Console.ReadLine();
        }

        static void InputMagazineInfo(Magazine magazine)
        {
            InputCommonPublicationInfo(magazine);

            Console.Write("Genre: ");
            magazine.IssueNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Language: ");
            magazine.Topic = Console.ReadLine();
        }



        static (bool, string) AddBook(Publication publication)
        {
            return libraryManagement.AddDocument(publication);
        }

        static void PrintDocumentsInfo()
        {
            var listDucuments = libraryManagement.GetListDocument();
            foreach (var document in listDucuments)
            {
             
                Console.WriteLine("---------------------");
                if (document is Book book)
                {
                    Console.WriteLine($"Book: {book.Heading}, Genre: {book.Genre}, Language: {book.Language}");
                }
                else if (document is Magazine magazine)
                {
                    Console.WriteLine($"Magazine: {magazine.Heading}, Issue Number: {magazine.IssueNumber}");
                }

            }
        }

    }
}
