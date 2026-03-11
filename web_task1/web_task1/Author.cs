using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace web_task1
{
    internal class Author
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Author(int id,string name)
        {
            Name = name;
            ID = id;
        }
        public void Tostring()
        {
            Console.WriteLine($"Id:{ID},Name:{Name}");
        }
    }
}
