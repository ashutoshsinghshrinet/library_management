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
    //Defining a class for newspaper
    class Newspaper
    {
        public int paperID;
        public string paperName;
        public int paperPrice;
        public int paperCount;
        public int a;
    }
    //Defining a class Borrow
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

        //Password verfication and Menu 
        static void Main(string[] args)
        {   again:
            Console.Write("==========Welcome========== !!!!\n" +
                "Please select the user type:  \n [1] Librarian \n [2] Reader\n ");
            int user_type = int.Parse(Console.ReadLine());
            if (user_type == 1)
            {
                Console.WriteLine("Welcome to the library Librarian!!!!!\n");
                Console.WriteLine("What Do you want to acces: \n" +
                    "1) Books\n" +
                    "2) Newspapers\n");
                int prod_type = int.Parse(Console.ReadLine());
                if (prod_type == 1)
                {
                    bool clos = true;
                    while (clos)
                    {
                        Console.WriteLine("\nMenu\n" +
                        "1)Add book\n" +
                         "2)Delete book\n" +
                         "3)Search book\n4) Close\n");
                        Console.Write("Choose your option from menu :");

                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                GetBook();
                                break;
                            case 2:
                                RemoveBook();
                                break;
                            case 3:
                                SearchBook();
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Thank you");
                                    clos = false;
                                    break;
                                }
                        }

                    }
                }
                else if (prod_type == 2)
                {
                    bool clos = true;
                    while (clos)
                    {
                        Console.WriteLine("\nMenu\n" +
                         "1)Add Paper\n" +
                         "2)Delete Paper\n" +
                         "3)Search Paper\n4) Close\n");
                        Console.Write("Choose your option from menu :");

                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                AddPaper();
                                break;
                            case 2:
                                RemovePaper();
                                break;
                            case 3:
                                SearchPaper();
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Thank you");
                                    clos = false;
                                    break;
                                }

                        }

                    }
                }
            }

            else if (user_type == 2)
            {
                Console.WriteLine("Welcome to the Library :: Reader!!!!!!");
                Console.WriteLine("What Do you want to acces: \n" +
               "1) Books\n" +
               "2) Newspapers\n");
                int prod_type = int.Parse(Console.ReadLine());
                if (prod_type == 1)
                {
                    bool close = true;
                    while (close)
                    {
                        Console.WriteLine("\nMenu\n" +
                        "1) Borrow a book\n" +
                        "2) Return a book\n" +
                        "3) Close\n\n");
                        Console.Write("Choose your option from menu :");

                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Borrow();
                                break;
                            case 2:
                                ReturnBook();
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Thank you");
                                    close = false;
                                    break;
                                }

                        }
                    }

                }
                else if (prod_type == 2)
                {
                    Console.WriteLine("Can read newspapers");
                }


            }
            else 
            {
                Console.WriteLine("Invalid Input\n" +
                    "If You want to continue Press Y to or else press any key");
                string c = Console.ReadLine();
                if(c == "y" || c == "Y")
                         goto again;
            }
            
        }
        //To add book details to the Library database
        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        //To delete book details from the Library database 
        public static void RemoveBook()
        {
            Book book = new Book();
            Console.Write("Enter Book id to be deleted : ");

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
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
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

        //Adding a newspaper to library
        public static void AddPaper()
        {
            Newspaper paper = new Newspaper();
            Console.WriteLine("Paper Id:{0}", paper.paperID = paperList.Count + 1);
            Console.Write("Paper Name:");
            paper.paperName = Console.ReadLine();
            Console.Write("Paper Price:");
            paper.paperPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of papers:");
            paper.a = paper.paperCount = int.Parse(Console.ReadLine());
            paperList.Add(paper);
        }

        //Deleting paper from the library

        public static void RemovePaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Enter Paper id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (paperList.Exists(x => x.paperID == Del))
            {
                paperList.RemoveAt(Del - 1);
                Console.WriteLine("Paper id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Paper id");
            }

            paperList.Add(paper);
        }

        //To search paper details from the Library database using Paper id 

        public static void SearchPaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Search by Paper id :");
            int find = int.Parse(Console.ReadLine());

            if (paperList.Exists(x => x.paperID == find))
            {
                foreach (Newspaper searchId in paperList)
                {
                    if (searchId.paperID == find)
                    {
                        Console.WriteLine("Paper id :{0}\n" +
                        "Paper name :{1}\n" +
                        "Paper price :{2}\n" +
                        "Paper Count :{3}", searchId.paperID, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Paper id {0} not found", find);
            }
        }

    }

    

}
