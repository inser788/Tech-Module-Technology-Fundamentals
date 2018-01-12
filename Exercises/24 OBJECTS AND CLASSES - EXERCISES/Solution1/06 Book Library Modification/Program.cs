using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Book_Library_Modification
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books = new List<Book>();
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime RealeasDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            Library libraryOfBooks = GetLibraryOfbooks(booksCount);
            var dateFormat = "d.M.yyyy";
            string dateString = Console.ReadLine();
            DateTime targetDate = DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture);
            var sortedTitles = GetTitlesAndDatesAfterTargetDate(libraryOfBooks,targetDate);
            PrintSortedTitles(sortedTitles);

        }

        static void PrintSortedTitles(Dictionary<string, DateTime> sortedTitles)
        {
            foreach (var title in sortedTitles.OrderBy(d =>d.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{title.Key} -> {title.Value:dd.MM.yyyy}");
            }
        }

        static Dictionary<string,DateTime> GetTitlesAndDatesAfterTargetDate(Library libraryOfBooks,DateTime targetDate)
        {
            var sortedTitles = new Dictionary<string, DateTime>();
            foreach (var item in libraryOfBooks.Books)
            {
                if (targetDate<item.RealeasDate)
                {
                    sortedTitles.Add(item.Title, item.RealeasDate);
                }
            }
            return sortedTitles;
        }

        private static Library GetLibraryOfbooks(int booksCount)
        {
            Library libraryOfBooks = new Library();
            var listBook = new List<Book>();
            for (int i = 0; i < booksCount; i++)
            {
                libraryOfBooks.Books.Add(GetBook());
            }
            return libraryOfBooks;
        }

        private static Book GetBook()
        {
            var bookInfo = Console.ReadLine().Split().ToArray();
            var dateFormat = "d.M.yyyy";
            return new Book
            {

                Title = bookInfo.First(),
                Author = bookInfo.Skip(1).First(),
                Publisher = bookInfo.Skip(2).First(),
                RealeasDate = DateTime.ParseExact(bookInfo.Skip(3).First(), dateFormat, CultureInfo.InvariantCulture),
                ISBN = bookInfo.Skip(4).First(),
                Price = decimal.Parse(bookInfo.Last())
            };
        }
    }
}
