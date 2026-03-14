using System;
using System.Collections.Generic;
using System.Linq;

class Bai15
{
    static void Main()
    {
        Console.WriteLine("Ma SV: 2415053122208");
        Console.WriteLine("Ten SV: Le The Duy");
        Console.WriteLine("Lop: 225LTC#01");

        List<int> numbers = new List<int>{1,2,2,3,4,4,5};

        var unique = numbers.Distinct();

        Console.WriteLine("Danh sach sau khi loai trung:");
        foreach (var n in unique)
            Console.Write(n + " ");
    }
}