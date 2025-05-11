using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User (int id , string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"User ID: {Id}, Name: {Name}");

        }
    }
}
