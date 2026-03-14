using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Score {get;set;}
}

class Bai20
{
    static void Main()
    {
        Console.WriteLine("Ma SV: 2415053122208");
        Console.WriteLine("Ten SV: Le The Duy");
        Console.WriteLine("Lop: 225LTC#01");

        List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };

        var top3 = students
                    .OrderByDescending(s => s.Score)
                    .Take(3);

        Console.WriteLine("Top 3 sinh vien diem cao nhat:");

        foreach (var s in top3)
            Console.WriteLine(s.Name + " - " + s.Score);
    }
}