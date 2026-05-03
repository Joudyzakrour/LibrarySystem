using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibrarySystem.LibraryNothifier;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            LibraryNotifier notifier = new LibraryNotifier();

            notifier.OnItemAdded += msg => Console.WriteLine(msg);


            while (true)
            {
                Console.WriteLine("\n===== Library Menu =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("3. Add DVD");
                Console.WriteLine("4. Show All Items");
                Console.WriteLine("5. Search by Title");
                Console.WriteLine("6. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    if (!Validator.IsValidTitle(title))
                    {
                        Console.WriteLine("Invalid title!");
                        continue;
                    }

                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    Book book = new Book(Counter.TotalItems + 1, title, author);
                    library.AddItem(book);

                    Counter.TotalItems++;
                    notifier.AddItem(title);
                }

                else if (choice == 2)
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Issue Number: ");
                    int issue = int.Parse(Console.ReadLine());

                    Magazine mag = new Magazine(Counter.TotalItems + 1, title, issue);
                    library.AddItem(mag);

                    Counter.TotalItems++;
                    notifier.AddItem(title);
                }

                else if (choice == 3)
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Duration: ");
                    int duration = int.Parse(Console.ReadLine());

                    DVD dvd = new DVD(Counter.TotalItems + 1, title, duration);
                    library.AddItem(dvd);

                    Counter.TotalItems++;
                    notifier.AddItem(title);
                }

                else if (choice == 4)
                {
                    library.ShowAllItems();
                }

                else if (choice == 5)
                {
                    Console.Write("Enter title to search: ");
                    string search = Console.ReadLine();
                    library.Search(search);
                }

                else if (choice == 6)
                {
                    break;
                }
            }
        }
    }
}