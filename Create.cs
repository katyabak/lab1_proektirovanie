using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1;

class Create
{
    static void Main()
    {
        string[] bookTitles = {
            "Преступление и наказание",
            "Мастер и Маргарита",
            "1984",
            "Унесённые ветром",
            "Война и мир",
            "Маленький принц",
            "Три товарища",
            "Анна Каренина",
            "Тень ветра",
            "Гарри Поттер и философский камень"
        };
        // массив книг с использованием метода CreateBooks
        Book[] books = CreateBooks(bookTitles);

        // создание экземпляра класса
        LibraryManager manager = new LibraryManager();

        // вызов метода
        Book bookWithMaxPages = manager.GetMaxPagesArray(books);
        Console.WriteLine($"Книга с максимальным кол-вом страниц: {bookWithMaxPages.Name} ({bookWithMaxPages.Pages} страниц)");


        DateTime[] maxCreationDateArray = manager.GetMaxCreationDateArray(books);
        Console.WriteLine($"Максимальная дата создания: {maxCreationDateArray[0].ToString("d")}");

        // преобразование массива книг в список книг
        List<Book> bookList = books.ToList();

        string searchString = "М";
        string filteredBookNamesString = manager.GetBookNamesString(bookList, searchString);
        Console.WriteLine($"Названия книг, содержащих подстроку '{searchString}': {filteredBookNamesString}");
    }
    static Book[] CreateBooks(string[] bookTitles)
    {
        Book[] books = new Book[bookTitles.Length]; // массив 10 экземпляров тип бук
        for (int i = 0; i < bookTitles.Length; i++)
        {
            Book book = new Book()
            // проходит по элементам массива, создает новый экземпляр класса Book для каждого элемента
            {
                Name = bookTitles[i],
                Pages = 200 + i * 10,
                CreationDate = DateTime.Now.AddDays(-i)
                // для каждой книги задаются значения свойств
            };
            books[i] = book; // массив заполняется
        }
        return books; // возвращает массив с 10 книгами
    }
}
