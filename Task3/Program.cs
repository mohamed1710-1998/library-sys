namespace Task3
{
    class Library
    {
        public List<Book> books  = new List<Book>{};

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool Search (string titleToSearch) {

            if ( books.Count > 0 ) 
            {

            }
            int getIt = 0;

            for (int i = 0; i < books.Count; i++) { 
                

                if (titleToSearch == books[i].Title)
                {
                    getIt++;
                }
            }

            if (getIt == 0)
            {

                return false;
            }
            else { 

                return true;
            }
        }



        public void PrintList()
        {
            if (books.Count > 0)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"[{books[i].Title}] \n");
                    Console.WriteLine($"[{books[i].Author}] \n");
                    Console.WriteLine($"[{books[i].Isbn}] \n");
                    Console.WriteLine($"[{books[i].Available}] \n");
                }
            }
            else
            {
                Console.WriteLine("Sorry your list is empty\n");
            }
            

        }

        public void BorrowBook()
        {
            if (books.Count > 0)
            {
                Console.WriteLine("there is our books \n");
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"[{books[i].Title}] \n");
                }

                Console.WriteLine("Enter the book you want \n");
                string bookToBorrow = Console.ReadLine();
                Console.WriteLine("");

                for (int i = 0; i < books.Count ; i++)
                {
                    if (bookToBorrow == books[i].Title)
                    {
                        books[i].Available = "not available";
                    }
                }
                Console.WriteLine("congratulations... dont forget to get it back ;) \n");
                
            }
            else
            {
                Console.WriteLine("Sorry there is no books right now \n");
            }
        }

        public void ReturnBook(string returnBookTitle)
        {
            if (books.Count > 0)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (returnBookTitle == books[i].Title)
                    {
                        books[i].Available = "available now";
                        Console.WriteLine("thanks the book is returned successfully :) \n");
                    }
                    else
                    {
                        Console.WriteLine("sorry this book is not our book");
                    }
                }
            }else
            {
                Console.WriteLine("there is no books in library yet \n ");
            }
            
        }

    }
    class Book
    {

        public long Isbn { get; set;}
        public string Title { get; set;}  
        public string Author { get; set;}
        public string Available { get; set;}
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================== Welcome to our library ======================== \n");
            Console.WriteLine("========================== Please choose any option you want ======================== \n");
            Library library = new Library();

            do
            {
                Console.WriteLine("A - Add book to our library");
                Console.WriteLine("P - Print list");
                Console.WriteLine("S - Search about the book you want");
                Console.WriteLine("B - Borrow any book you want");
                Console.WriteLine("R - Return our book");
                Console.WriteLine("Q - Quit \n");

                char option = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.WriteLine("");

                // add book
                if (option == 'A')
                {
                    Book book = new Book();
                    Console.WriteLine("Please enter the book title: ");
                    book.Title = Console.ReadLine();
                    Console.WriteLine("Please enter the book author: ");
                    book.Author = Console.ReadLine();
                    Console.WriteLine("Please enter the book ISBN: ");
                    book.Isbn = long.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the book availability (yes / no): ");
                    book.Available = Console.ReadLine();
                    library.AddBook(book);
                    Console.WriteLine("You add your book successfully \n");
                    library.PrintList();

                }
                // search
                else if (option == 'S')
                {
                    Console.WriteLine("Please enter the title of book you want to find !!");
                    string nameOfBook = Console.ReadLine();
                    Console.WriteLine("");
                    bool result = library.Search(nameOfBook);
                    if (result == true)
                    {
                        Console.WriteLine("we found your book \n");
                    }
                    else
                    {
                        Console.WriteLine("Sorry your book dosnt exist \n");
                    }
                }
                // print list
                else if (option == 'P')
                {
                    library.PrintList();
                }
                // Borrow book 
                else if (option == 'B')
                {
                    library.BorrowBook();
                }
                // Return book 
                else if (option == 'R')
                {
                    Console.WriteLine("Enter the title of the book you want to return \n");
                    string returnBookTitle = Console.ReadLine();
                    Console.WriteLine("");
                    library.ReturnBook(returnBookTitle);

                }
                // Exit 
                else if (option == 'Q')
                {
                    break;
                }


            } while (true);







            



            

        }
    }
}
