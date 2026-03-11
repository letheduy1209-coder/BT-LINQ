using System;
using System.Collections.Generic;
using System.Linq;

class Bai7
{
    static void Main()
    {
        Console.WriteLine("Ma SV: 2415053122208");
        Console.WriteLine("Ten SV: Le The Duy");
        Console.WriteLine("Lop: 225LTC#01");

        List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,12};

        bool ketQua = numbers.Any(n => n > 10);

        Console.WriteLine("Co so > 10 khong: " + ketQua);
    }
}