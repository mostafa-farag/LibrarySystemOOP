using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryManager
    {
        public List<Book> books { get; set; }
        public List<Member>members{ get; set; }
        public Librarian librarian { get; set; }

        public LibraryManager() 
        {
            books = new List<Book>(); 
            members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member '{member.Name}' added to the library.");
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("\nBooks in Library:");
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }
        }

        public void ShowAllMembers()
        {
            Console.WriteLine("\nMember in Library");
            foreach (Member member in members)
            {
                member.DisplayInfo();
            }
        }

        // method to borrow books
        public void BorrowBook(Book book, Member member)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                member.BorrowedBook.Add(book);
                Console.WriteLine($"{book.Title} Has been brrorowed by {member.Name}");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available.");
            }
        }

        // method to Return Book
        public void ReturnBook(Book book, Member member)
        {
            if (member.BorrowedBook.Contains(book))
            {
                member.BorrowedBook.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{member.Name} has returned '{book.Title}'");
            }

            else
                Console.WriteLine($"{member.Name} does not have this book.");
        }


       
    }
}
