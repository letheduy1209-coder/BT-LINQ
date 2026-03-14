using System;
using System.Collections.Generic;
using System.Linq;

class Bai19
{
    static void Main()
    {
        Console.WriteLine("Ma SV: 2415053122208");
        Console.WriteLine("Ten SV: Le The Duy");
        Console.WriteLine("Lop: 225LTC#01");

        List<int> numbers = new List<int>{1,2,2,3,3,3,4,5};

        var max = numbers
                    .GroupBy(n => n)
                    .OrderByDescending(g => g.Count())
                    .First();

        Console.WriteLine("So xuat hien nhieu nhat: " + max.Key);
    }
}