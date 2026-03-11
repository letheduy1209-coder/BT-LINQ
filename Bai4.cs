using System;
using System.Collections.Generic;
using System.Linq;

class Bai4
{
    static void Main()
    {
        Console.WriteLine("Ma SV: 2415053122208");
        Console.WriteLine("Ten SV: Le The Duy");
        Console.WriteLine("Lop: 225LTC#01");

        List<int> numbers = new List<int>{1,2,3,4,5,6,7,8};

        var giamDan = numbers.OrderByDescending(n => n);

        Console.WriteLine("Sap xep giam dan:");
        foreach (var n in giamDan)
            Console.Write(n + " ");
    }
}