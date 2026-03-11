// See https://aka.ms/new-console-template for more information
using web_task1;

Console.WriteLine("Hello, World!");
List<Book> books = new List<Book>() {
new Book(1,"C# Basics",150,1,300),
new Book(2, "LINQ Guide", 200, 2, 250),
new Book(3, "ASP.NET Core", 250, 3, 400),
new Book(4, "Entity Framework", 180, 2, 280),
new Book(5, "Programing", 350, 4, 500),
new Book(6, "Utopia", 100, 3, 150),
    };
List<Author> author = new List<Author>()
{
  new Author (1, "Ahmed Khaled" ),
    new Author ( 2,  "Naguib Mahfouz" ),
    new Author ( 3, "Taha Hussein" ),
};
Console.WriteLine("===============Task 1 - day 1==============================");
var q1 = books.Where(b => b.Pages > 300);
foreach (var book in q1)
{
    Console.WriteLine(book.Title);
}
var q2 = books.Where(b => b.Authorid == 1);
foreach (var book in q2)
{
    Console.WriteLine(book.Title);
}
var q3 = books.Where(b => b.Pages >= 200 && b.Pages <= 300);
foreach (var book in q3)
{
    Console.WriteLine(book.Title);
}
var q4 = books.Where(b => b.Title.StartsWith("P"));
foreach (var book in q4)
{
    Console.WriteLine(book.Title);
}
var q5 = books.Select(b => b.Title);
foreach (var book in q5)
{
    Console.WriteLine(book);
}
var q6 = books.Select(b => new { b.Title, b.Pages });
foreach (var book in q6)
{
    Console.WriteLine(book.Title + " " + book.Pages);
}
var q7 = author.Select(x => x.Name);
foreach (var aut in q7)
{
    Console.WriteLine(aut);
}
var q8 = books.First(b => b.Pages > 300);
Console.WriteLine(q8.Title);
var q9 = books.FirstOrDefault(b => b.Authorid == 2);
Console.WriteLine(q9.Title);
var q10 = author.Single(x => x.ID == 3);
Console.WriteLine(q10.Name);
var q11 = books.Single(b => b.Title == "Utopia");
Console.WriteLine(q11.Title);
var q12 = books.OrderBy(b => b.Pages);
foreach (var book in q12)
{
    Console.WriteLine(book.Title + " , " + book.Pages);
}
var q13 = books.OrderByDescending(b => b.Title);
foreach (var book in q13)
{
    Console.WriteLine(book.Title);
}
var q14 = books.OrderBy(b => b.Authorid).ThenBy(b => b.Pages).ToList();
foreach (Book book in q14)
{
    Console.WriteLine(book.Authorid + " " + book.Title + " " + book.Pages);
}
var q15 = books.Count();
Console.WriteLine(q15);
var q16 = books.Average(b => b.Pages);
Console.WriteLine(q16);
var q17 = books.Max(b => b.Pages);
Console.WriteLine(q17);
var q18 = books.Any(b => b.Pages > 400);
Console.WriteLine(q18);
var q19 = books.All(b => b.Pages > 100);
Console.WriteLine(q19);
var q20 = books.Select(b => b.Title).ToList();
bool res = q20.Contains("Utopia");
Console.WriteLine(res);
//Console.WriteLine("======================Task 2 - day2======================");
//var q21 =
//    from b in books
//    join a in author
//   on b.Authorid equals a.ID
//    select new
//    {
//        b.Title,
//        a.Name,
//    };
//foreach (var item in q21)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("=====================");
//var q22 =
//    from b in books
//    join a in author on b.Authorid equals a.ID
//    select new
//    {
//        b.Title,
//        b.Pages,
//        a.Name,
//    };
//foreach (var item in q22)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("=====================");

//var q23 = books.GroupBy(b => b.Authorid)
//    .Select(g => new
//    {
//        Authorid = g.Key,
//        book = g.Count(),
//    });
//foreach (var item in q23)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("=====================");
//var q24 = books.GroupBy(b => b.Authorid);
//foreach (var item in q24)
//{
//    Console.WriteLine(item.Key); 
//    foreach(var item2 in item)
//    {
//        Console.WriteLine(item2.Title); 
//    }
//}
//Console.WriteLine("=====================");
//var q25 = books.Take(3);
//foreach (var item in q25)
//{
//    Console.WriteLine(item.Title);
//}
//Console.WriteLine("=====================");
//var q26 = books.Skip(2);
//foreach (var item in q26)
//{
//    Console.WriteLine(item.Title);
//}
//Console.WriteLine("=====================");
//var q27 = books.Skip(2).Take(3);
//foreach (var item in q27)
//{
//    Console.WriteLine(item.Title);
//}
//Console.WriteLine("=====================");
//var q28 = books.TakeWhile(b => b.Pages < 300);
//foreach (var item in q28)
//{
//    Console.WriteLine(item.Title);
//}
//Console.WriteLine("=====================");
//var q29 = books.SkipWhile(b => b.Pages < 250);
//foreach (var item in q29)
//{
//    Console.WriteLine(item.Title);
//}
//Console.WriteLine("=====================");
//var q30 = books.Chunk(2);
//foreach (var item in q30)
//{
//    foreach (var item2 in item)
//    {
//        Console.WriteLine(item2.Title);
//    }
//}
