using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_problemsolving
{
  public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
        //  public Student(int id,string name,int age,string depar,double gpa) {
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //    Department = depar;
        //    GPA = gpa;
        //}
        public override string ToString() {
            return $"Id : {Id},Name : {Name},Age: {Age},Department :{Department},GPA : {GPA}";
        }
    }
}
