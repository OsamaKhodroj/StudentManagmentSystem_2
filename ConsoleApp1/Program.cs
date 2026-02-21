using Pioneersacademy.SMS.Domains.DTOs.Student;
using Pioneersacademy.SMS.Domains.Entities;
using Pioneersacademy.SMS.Domains.Enums;
using System.ComponentModel.Design;

namespace Pioneersacademy.SMS.ConsoleApp1;

public class Program
{
    public static async Task Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student() { Id = 1, Age = 10,  FirstName = "John 1", LastName = "Doe", BirthOfDate = new DateTime(2000, 1, 1), PhoneNumber = "111111", StudentStatus = StudentStatus.Pass },
            new Student() { Id = 1, Age = 20, FirstName = "John 2" , LastName = "Doe", BirthOfDate = new DateTime(2000, 1, 1), PhoneNumber = "22222", StudentStatus = StudentStatus.Fail },
            new Student() { Id = 3, Age = 25, FirstName = "John 3", LastName = "Doe", BirthOfDate = new DateTime(2000, 1, 1), PhoneNumber = "333333", StudentStatus = StudentStatus.Fail },
            new Student() { Id = 4, Age = 30, FirstName = "John 4", LastName = "Doe", BirthOfDate = new DateTime(2000, 1, 1), PhoneNumber = "44444", StudentStatus = StudentStatus.Pass },
            new Student() { Id = 5, Age = 35, FirstName = "John 5", LastName = "Doe", BirthOfDate = new DateTime(2000, 1, 1), PhoneNumber = "55555", StudentStatus = StudentStatus.Pass },
        };

        var student = students
            .Select(q => new GetAllStudentResponse()
            {
                Id = q.Id,
                FullName = $"{q.FirstName} {q.LastName}"
            })
            .OrderByDescending(q => q.Id)   
            .ToList();



        var _students = students.All(s => s.Age >= 20);
        var _students1 = students.Any(s => s.Age >= 20);
        var _students2 = students.Contains(new Student() { Id = 1, Age = 10, FirstName = "John 1", LastName = "Doe", BirthOfDate = new DateTime(2000, 1, 1), PhoneNumber = "111111", StudentStatus = StudentStatus.Pass });



        var d = students.Where(x => x.Id == 1)
            .FirstOrDefault();

        var d = students.FirstOrDefault(x => x.Id == 1);
        var d = students.Distinct();
            




        var data = students.First(s => s.Age == 1);    // Exception
        var data = students.FirstOrDefault(s => s.Age == 1);  //Null   


        var data = students.Last(s => s.Age == 1);    // Exception
        var data = students.LastOrDefault(s => s.Age == 1);  //Null   



        var data = students.Single(s => s.Age == 1);    // Exception
        var data = students.SingleOrDefault(s => s.Age == 1);  //Null  


        //int[] marks = { 90, 80, 70, 60, 50 };
        //Console.WriteLine(marks.Average());
        //Console.WriteLine(marks.Sum());
        //Console.WriteLine(marks.Min());
        //Console.WriteLine(marks.Max());
        //Console.WriteLine(marks.Count());



        //var result = from s in students
        //             where s.Age >= 20
        //             orderby s.Id descending
        //             select s;


    }
}
