using System;
using System.Reflection;
using System.Threading.Tasks;
using AdvancedLibrarySystem.Models;
using AdvancedLibrarySystem.Core;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("= SYSTEM BIBLIOTEKI =\n");

        var library = new LibraryService();

        
        library.ItemAdded += item =>
            Console.WriteLine($"[EVENT] Dodano do biblioteki: {item.Title}");

        library.ItemBorrowed += (item, user) =>
            Console.WriteLine($"[EVENT] {user.Name} wypożyczył: {item.Title}");


        var user1 = new User("Anna");
        var user2 = new User("Tomasz");


        var book = new Book("C# Advanced", "Kowalski", 2022);

        var ebook = new EBook(
            "Design Patterns",
            "Gamma",
            1995,
            5.4
        );

        var audiobook = new AudioBook(
            "Clean Code",
            "Martin",
            2008,
            600
        );

        var book2 = new Book("OOP Mastery", "Nowak", 2023);
        var combinedBook = book + book2;

        Console.WriteLine("Dodawanie książek do biblioteki...\n");

        await library.AddItemAsync(book);
        await library.AddItemAsync(book2);
        await library.AddItemAsync(ebook);
        await library.AddItemAsync(audiobook);
        await library.AddItemAsync(combinedBook);

        Console.WriteLine("\n= WSZYSTKIE ELEMENTY =");
        library.ShowAllItems();

        
        Console.WriteLine("\n= WYPOŻYCZANIE =");

        library.BorrowItem("C# Advanced", user1);
        library.BorrowItem("OOP Mastery", user2);

        Console.WriteLine($"\nCzy książka 'C# Advanced' jest wypożyczona? {book.IsBorrowed}");

        
        Console.WriteLine("\n= ZWROT =");

        library.ReturnItem("C# Advanced");

        Console.WriteLine($"Czy książka 'C# Advanced' jest wypożyczona? {book.IsBorrowed}");

        
        Console.WriteLine("\n= POLIMORFIZM =");

        LibraryItem[] items =
        {
            book,
            ebook,
            audiobook
        };

        foreach (var item in items)
        {
            Console.WriteLine(item.GetDescription());
        }

        
        Console.WriteLine("\n= REFLEKSJA =");

        Type type = typeof(Book);

        Console.WriteLine($"Metody klasy {type.Name}:");

        foreach (var method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine($"\nLiczba utworzonych elementów biblioteki: {LibraryItem.ItemCount}");
        Console.ReadLine();
    }
}