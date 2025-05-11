using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string author)
        {
            ID = id;
            Title = title;
            Author = author;
            IsAvailable = true;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");

        }
    }
}
