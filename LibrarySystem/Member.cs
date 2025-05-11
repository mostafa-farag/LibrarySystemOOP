using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Member:User
    {
        public List<Book> BorrowedBook= new List<Book>();

        public Member(int id , string name):base(id,name) 
        {
            BorrowedBook =new List<Book>();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID : {Id} , Name {Name} , Borrowe Books : {BorrowedBook.Count}");
        }

        public void ShowBorrowedBooks()
        {

            if (BorrowedBook.Count==0)
            {
                Console.WriteLine("No borrowed books.");
            }

            else
            {
                Console.WriteLine("Borrowed Books:");
                
                foreach (Book book in BorrowedBook) 
                {
                    book.DisplayInfo();
                }
            }
        }
    }
}
