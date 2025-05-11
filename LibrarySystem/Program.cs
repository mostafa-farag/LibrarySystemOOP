using static System.Reflection.Metadata.BlobBuilder;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LibraryManager manage=new LibraryManager();
            
            //add librarian
            Console.Write("Enter Librarian Name : ");
            string librarianName=Console.ReadLine();

            Console.Write("Enter Librarian ID : ");
            int librarianId=int.Parse(Console.ReadLine());

            manage.librarian=new Librarian(librarianId,librarianName);
            Console.WriteLine($"Librarian added {librarianName}.\n");

            //add books
            Console.Write("How many books do you want to add ? : \n");
            int bookCount=int.Parse(Console.ReadLine());
            for (int i = 0; i < bookCount; i++) 
            {
                Console.WriteLine($"Book{i+1} : ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Titel : ");
                string titel=Console.ReadLine();

                Console.Write("Author : ");
                string author=Console.ReadLine();

                manage.AddBook(new Book(id,titel,author));
            }

            // add member
            Console.Write("How many Member do you want to add ? : \n");
            int memberCount = int.Parse(Console.ReadLine());
            for(int i = 0;i < memberCount; i++)
            {
                Console.WriteLine($"Member{i + 1}");
                Console.Write(" ID : ");
                int memberID=int.Parse(Console.ReadLine());

                Console.Write("Name : ");
                string memberName=Console.ReadLine();
                manage.AddMember(new Member(memberID,memberName));
            }

            //show all data
            manage.ShowAllBooks();
            manage.ShowAllMembers();

            // borrow book
            Console.Write("\nEnter member ID to borrow book: ");
            int memberId = int.Parse(Console.ReadLine());

            Console.Write("Enter book ID to borrow: ");
            int bookId = int.Parse(Console.ReadLine());

           
            Member member = manage.members.Find(m => m.Id == memberId);
            Book book = manage.books.Find(b => b.ID == bookId);

            
            if (member != null && book != null)
            {
                manage.BorrowBook(book, member); 
            }
            else
            {
                Console.WriteLine("Invalid member ID or book ID.");
            }

            // return book
            Console.Write("\nEnter member ID to borrow book: ");
            int memId = int.Parse(Console.ReadLine());

            Console.Write("Enter book ID to Return : ");
            int bkId = int.Parse(Console.ReadLine());

            if (member != null && book != null)
            {
                manage.ReturnBook(book, member);
            }
            else
            {
                Console.WriteLine("Invalid member ID or book ID.");
            }



        }
    }
}
