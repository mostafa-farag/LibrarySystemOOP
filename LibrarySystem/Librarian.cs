using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : User 
    {
        public Librarian(int id, string name): base(id,name) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Librarian] ID: {Id}, Name: {Name}");

        }
      
    }
}
