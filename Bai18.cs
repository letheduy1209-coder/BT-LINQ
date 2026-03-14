using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Score {get;set;}
}

class Bai18
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

        var groups = students.GroupBy(s =>
        {
            if (s.Score >= 8) return "Gioi";
            else if (s.Score >= 6) return "Kha";
            else return "Trung Binh";
        });

        foreach (var g in groups)
        {
            Console.WriteLine("Xep loai: " + g.Key);
            foreach (var s in g)
                Console.WriteLine(s.Name + " - " + s.Score);
        }
    }
}