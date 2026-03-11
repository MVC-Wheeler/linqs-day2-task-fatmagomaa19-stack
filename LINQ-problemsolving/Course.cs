using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_problemsolving
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        //public Course(int id,string titel,int credits)
        //{
        //    this.Id = id;
        //    this.Title = titel;
        //    this.Credits = credits;
        //}
        public override string ToString()
        {
            return $"Id : {Id},Titel : {Title},Credits: {Credits}";
        }

    }
    

}

