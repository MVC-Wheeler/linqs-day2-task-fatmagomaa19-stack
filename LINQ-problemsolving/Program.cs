using System.Xml.Linq;

namespace LINQ_problemsolving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>
            {
               new Student { Id = 1, Name = "Ahmed Ali", Age = 21, Department = "CS", GPA = 3.6 },
    new Student { Id = 2, Name = "Sara Mohamed", Age = 20, Department = "IT", GPA = 3.2 },
    new Student { Id = 3, Name = "Omar Hassan", Age = 22, Department = "CS", GPA = 2.8 },
    new Student { Id = 4, Name = "Mona Adel", Age = 19, Department = "IS", GPA = 3.9 },
    new Student { Id = 5, Name = "Youssef Kamal", Age = 23, Department = "CS", GPA = 2.4 },
    new Student { Id = 6, Name = "Aya Mostafa", Age = 21, Department = "IT", GPA = 3.5 },
    new Student { Id = 7, Name = "Hassan Mahmoud", Age = 24, Department = "IS", GPA = 1.9 },
    new Student { Id = 8, Name = "Nada Fathy", Age = 20, Department = "CS", GPA = 3.1 },
    new Student { Id = 9, Name = "Ali Samir", Age = 18, Department = "IT", GPA = 2.6 },
    new Student { Id = 10, Name = "Reem Tarek", Age = 22, Department = "IS", GPA = 3.7 },
    new Student { Id = 11, Name = "Amr Nabil", Age = 21, Department = "CS", GPA = 4.0 },
    new Student { Id = 12, Name = "Laila Ashraf", Age = 19, Department = "IT", GPA = 2.2 }
            };
            var courses = new List<Course>
 {
     new Course { Id = 1, Title = "C# Fundamentals", Credits = 3 },
     new Course { Id = 2, Title = "OOP", Credits = 4 },
     new Course { Id = 3, Title = "Databases", Credits = 3 },
     new Course { Id = 4, Title = "ASP.NET MVC", Credits = 4 },
     new Course { Id = 5, Title = "LINQ Deep Dive", Credits = 2 }
 };
            var enrollments = new List<Enrollment>
{
    new Enrollment { StudentId = 1, CourseId = 1 },
    new Enrollment { StudentId = 1, CourseId = 2 },

    new Enrollment { StudentId = 2, CourseId = 1 },
    new Enrollment { StudentId = 2, CourseId = 3 },

    new Enrollment { StudentId = 3, CourseId = 2 },

    new Enrollment { StudentId = 4, CourseId = 4 },
    new Enrollment { StudentId = 4, CourseId = 5 },

    new Enrollment { StudentId = 6, CourseId = 3 },
    new Enrollment { StudentId = 6, CourseId = 4 },

    new Enrollment { StudentId = 8, CourseId = 1 },

    new Enrollment { StudentId = 10, CourseId = 2 },
    new Enrollment { StudentId = 10, CourseId = 3 },

    new Enrollment { StudentId = 11, CourseId = 5 }
};
            var res1 = students.Select(s => s.Name).ToList();
            foreach (var student in res1)
            {
                Console.WriteLine(student);
            }
            var res2 = students.Select(s => new
            {
                s.Name,
                s.GPA,
            });
            foreach (var student in res2) { Console.WriteLine(student); }
            var res3 = students.Any(s => s.GPA > 3.8);
            Console.WriteLine(res3);
            var res4 = students.All(s => s.Age < 18); Console.WriteLine(res4);
            var res5 = students.Where(s => s.Age > 20);
            foreach (var student in res5)
            {
                Console.WriteLine(student);

            }
            var res6 = students.Where(s => s.Department == "CS");
            foreach(var student in res6)
            {
                Console.WriteLine(student);
            }
            var res7= students.Select(s=> new
            {
                s.Name,
                s.Department,
            });
            foreach(var student in res7)
            {
                Console.WriteLine(student);
            }
            var res8 = students.OrderBy(s => s.GPA); foreach(var student in res8) { Console.WriteLine(student); }
            var res9 = students.OrderByDescending(s => s.GPA);foreach(var student in res9) {  Console.WriteLine(student); }
            var res10 = students.Take(5); foreach(var student in res10) { Console.WriteLine( student); }
            var res11 = students.Any(s => s.GPA < 2.0); Console.WriteLine(res11);
            //var res12 = students.All(s => s.GPA);
        }
    }
}
