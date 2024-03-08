namespace _1
{
    class LibraryManager
    {
        public Book GetMaxPagesArray(Book[] books)
        {
            int maxPages = books.Max(book => book.Pages);
            var bookWithMaxPages = books.First(x => x.Pages == maxPages);
            return bookWithMaxPages;
        }
        public DateTime[] GetMaxCreationDateArray(Book[] books)
        {
            DateTime maxDate = books.Max(book => book.CreationDate);
            return new DateTime[] { maxDate };
        }
        public string GetBookNamesString(List<Book> books, string foundedString)
        {
            // фильтрация книг по наличию подстроки в названии
            var filteredBooks = books.Where(book => book.Name.Contains(foundedString)).ToList();

            // из отфильтрованного списка книг создается новый список строк с именами
            List<string> bookNames = filteredBooks.Select(book => book.Name).ToList();
            return string.Join(", ", bookNames);
        }
    }
}
