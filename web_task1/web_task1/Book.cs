using System;
using System.Collections.Generic;
using System.Text;

namespace web_task1
{
    internal class Book
    {
        public int ID {  get; set; }
        public string Title {  get; set; }
        public int Price { get; set; }
        public int Authorid {  get; set; }
        public int Pages {  get; set; }
        public Book(int id,string titel,int price,int authorid,int pages) {
            ID = id;
            Title = titel;
            Price = price;
            Authorid = authorid;
            Pages = pages;
        }
        public void Tostring()
        {
            Console.WriteLine($"Id:{ID},Titel:{Title},Price:{Price},Authorid:{Authorid},Pages:{Pages}"); 
        }
    }
}
