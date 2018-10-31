using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    class Test
    {
        static void Main(string[] args)
        {
            //creating data for books
            LibraryBook book1 =
                new LibraryBook("Wealth of Nations", "Adam Smith", "Penguin House", "LB1234", 1776);
            LibraryBook book2 =
                new LibraryBook("The Bell Jar", "Silva Plath", "Harper Collins", "LB5678", 1996);
            LibraryBook book3 =
                new LibraryBook("Sense and Sensibility", "Jane Austen", "Barnse and Noble", "LB9101", 2003);
            LibraryBook book4 =
                new LibraryBook("Pride and Predjudice", "Jane Austen", "W.W. Norton and Company", "LB1213", 2001);
            LibraryBook book5 =
                new LibraryBook("Emma", "Jane Austen", "Penguin House", "LB1415", 1996);

            //Pre-condition: none
            //Post-condition: 5 library books are put in an array
            LibraryBook[] books = new LibraryBook[5];
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            WriteLine("***********Starting Data***********");
            WriteLine();
            //Pre-condition: none
            //Post-condition: prints data in array books to console
            foreach (LibraryBook book in books)//goes through the array and prints the data to the console
            {
                WriteLine(book);
                WriteLine();
            }

            //changing data of books

            //Two books checked out
            book1.CheckOut();
            book2.CheckOut();

            //Copyright year validation check
            book4.CopyRightYear = -2010;
            book3.CopyRightYear = 0;

            //Changing call number or publisher
            book1.Publisher = "Mary Had a Little Lamb";
            book2.CallNum = "LB1617";
            book3.CallNum = "LB1819";
            book4.Publisher = "Quack House";
            book5.Publisher = "Brick Wall";

            WriteLine();
            WriteLine("***********Changed Data***********");
            WriteLine();
            //precondition: None
            //Post-condition: prints data in array books to console
            foreach (LibraryBook book in books)//goes through the array and prints the data to the console
            {
                WriteLine(book);
                WriteLine();
            }

            WriteLine();
            WriteLine("*********Returning Checked out Books**********");
            WriteLine();

            //returning books to the library
            book1.ReturnToShelf();
            book2.ReturnToShelf();

            //Pre-condition: none
            //Post-condition: prints data in array books to console
            foreach (LibraryBook book in books)//goes through array and prints the data to the console
            {
                WriteLine(book);
                WriteLine();
            }
        }
    }
}

