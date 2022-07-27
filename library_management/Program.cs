using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    //Defining a class Book
    class Book
    {
        public int bookId;
        public string bookName;
        public int bookPrice;
        public int bookCount;
        public int x;
    }
    //Defining a class Borrow
    class Newspaper
    {
        public int paperID;
        public string paperName;
        public int paperPrice;
        public int paperCount;
        public int a;
    }
    class BorrowDetails

    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();
        static List<Newspaper> paperList = new List<Newspaper>();
        static Newspaper newspaper = new Newspaper();

        //Password verfication and Menu
        static void Main(string[] args)
        {
            Console.WriteLine("=====Welcome to  Library=====");
            


            if (true)
            {
                while (true)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Welcome to the library\n Hope you have a good time here!!!!");
                    Console.WriteLine("\nSelect from the below option to continue.....\n" +
                    "1)press 1 to access books\n" +
                    "2)Press 2 to access newspapers\n");
                    Console.Write("Enter the Option you want to go with :");

                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        forBook();
                    }
                    else if (option == 2)
                    {
                        forNewspaper();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }


            }
            
            Console.ReadLine();
        }
        public static void forBook()
        {
            bool close = true;
            while (close)
            {

                Console.WriteLine("\nOption To Select\n" +
                "1)Press 1 to  Add book\n" +
                "2)Press 2 to Delete book\n" +
                "3)Press 3 to Search book\n" +
                "4)Press 4 to Borrow book\n" +
                "5)Press 5 to Return book\n" +
                "6)To Close Press Library 6 \n" +
                "7)To get the details of all books\n\n"
                );
                Console.WriteLine("--------------------------");

                Console.Write("Enter the Option you want to perform :");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    GetBook();
                }
                else if (option == 2)
                {
                    RemoveBook();
                }
                else if (option == 3)
                {
                    SearchBook();
                }
                else if (option == 4)
                {
                    Borrow();
                }
                else if (option == 5)
                {
                    ReturnBook();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Thank you");
                    close = false;
                    break;
                }
                else if (option == 7)
                {
                    if (bookList.Count > 0)
                    {
                        details();
                    }
                    else
                    {
                        Console.WriteLine("No Book ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }

            }
        }
        public static void forNewspaper()
        {
            bool close = true;
            while (close)
            {

                Console.WriteLine("\nOption To Select\n" +
                "1)press 1 to  Add newspaper\n" +
                "2)Press 2 to Delete newspaper\n" +
                "3)Press 3 to Search newspaper\n" +

                "4)To Close Press Library 4 \n" +
                "5)To get the details of all newspaper\n\n"
                );
                Console.WriteLine("--------------------------");

                Console.Write("Enter the Option you want to perform :");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    GetNewspaper();
                }
                else if (option == 2)
                {
                    RemoveNewspaper();
                }
                else if (option == 3)
                {
                    SearchNewspaper();
                }

                else if (option == 4)
                {
                    Console.WriteLine("Thank you");
                    close = false;
                    break;
                }
                else if (option == 5)
                {
                    if (paperList.Count > 0)
                    {
                        detailsNewspaper();
                    }
                    else
                    {
                        Console.WriteLine("No Book ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }

            }
        }

        //To add book details to the Library database
        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Enter the MRP of Book :");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books You want Add=:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());

            bookList.Add(book);
        }

        //To delete book details from the Library database
        public static void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to delete : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);
        }

        //To search book details from the Library database using Book id
        public static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Please Enter The Particular Book Id for Search :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Searched Book infromation:");
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public static void details()
        {
            foreach (Book searchId in bookList)
            {


                Console.WriteLine(" Book infromation:");
                Console.WriteLine("Book id :{0}\n" +
                "Book name :{1}\n" +
                "Book price :{2}\n" +
                "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                Console.WriteLine();

            }
        }

        //To borrow book details from the Library
        public static void Borrow()
        {
            Book book = new Book();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());
            Console.WriteLine("Book Borrowed succesfully");

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }

        //To return borrowed book to the library
        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }
        // for newspaper

        public static void GetNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.WriteLine("Newspaper Id:{0}", newspaper.paperID = paperList.Count + 1);
            Console.Write("Newspaper Name:");
            newspaper.paperName = Console.ReadLine();
            Console.Write("Enter the MRP of Newspaper :");
            newspaper.paperPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper You want Add=:");
            newspaper.a = newspaper.paperCount = int.Parse(Console.ReadLine());

            paperList.Add(newspaper);
        }

        //To delete Newspaper details from the Library database
        public static void RemoveNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.Write("Enter newspaper id to delete : ");

            int Del = int.Parse(Console.ReadLine());

            if (paperList.Exists(x => x.paperID == Del))
            {
                paperList.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            paperList.Add(newspaper);
        }

        //To search book details from the Library database using Book id
        public static void SearchNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.Write("Please Enter The Particular Newspaper Id for Search :");
            int find = int.Parse(Console.ReadLine());

            if (paperList.Exists(x => x.paperID == find))
            {
                foreach (Newspaper searchId in paperList)
                {
                    if (searchId.paperID == find)
                    {
                        Console.WriteLine("Searched Newspaper infromation:");
                        Console.WriteLine("Book id :{0}\n" +
                        "Newspaper name :{1}\n" +
                        "Newspaper price :{2}\n" +
                        "Newspaper Count :{3}", searchId.paperID, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", find);
            }
        }
        public static void detailsNewspaper()
        {
            foreach (Newspaper searchId in paperList)
            {


                Console.WriteLine(" Newspaper infromation:");
                Console.WriteLine("Newspaper id :{0}\n" +
                "Newspaper name :{1}\n" +
                "Newspaper price :{2}\n" +
                "Newspaper Count :{3}", searchId.paperID, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                Console.WriteLine();

            }
        }



    }
}
