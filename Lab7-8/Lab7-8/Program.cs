using System;

namespace Lab7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            BookTest Book = new BookTest();
            book.title = "Goosebumps: Welcome to Camp Nightmare";
            book.author = "R.L Stein";
            book.year = "1993";
            

            book.Display();  
        }
    }
    class BookTest : Book
    {

    }
   

    }
    class Book
    {
        public string title;
        public string author;
        public string year;

        public Book()
        {

        }
        public Book(string title, string author, string year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Title: {this.title}\n" +
                $"Author: {this.author}\n" +
                $"Year: {this.year}\n\n");
        }


        // Before adding a constructor method it is called instantiation or construction when we creat an instance type of Book.

        // If we added two more constructor methods we would be practicing a method that would be used to initialize newly created objects and pull them out of memory. We would also be practicing initializing objects to desired values from the time when the object was created.

        // It is important to use exception handling, because it can be used as a type of fail safe. So when an unexpected event occurs, that exception handling can run a special process so the program does not crash.

        // Public makes it possible for the object to be called from anywhere in the code, or that it can be accessed from anywhere within or outside of the class. In private, the object can only be called within the class. This is a good way to hide information, because it defines what might be private information, as well as making it impossible to pull private information elsewhere in the program.

        // Composition is a type of aggregation, which means objects have direct relation to one another. If one thing is deleted, the other will lose importance in the code, in other words it would break the program. We could use composition in the Book class by creating the name "Goosebumps" as an object of book. If book was deleted "Goosebumps" would have no meaning.

        // Data abstraction would be the process of hiding details in code and only showing the essential information. 

    }

