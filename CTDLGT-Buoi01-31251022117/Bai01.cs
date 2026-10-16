using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251022117
{
    internal class Bai01
    {
        static void MaxMinSumMean(int a, int b, int c, out int min, out double mean, out int sum, out int max)
        {
            max = a;
            min = a;
            mean = (a + b + c) / 3.0;
            sum = a + b + c;
            if (b > max) max = b;
            else if (c > max) max = c;

            if (b < min) min = b;
            else if (c < min) min = c;
        }


        static void Main1()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Input a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Input b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Input c: "); int c = int.Parse(Console.ReadLine());
            MaxMinSumMean(a, b, c, out int min, out double mean, out int sum, out int max);
            Console.WriteLine($"Lớn nhất: {max}; Nhỏ nhất: {min}; Tổng: {sum}; Trung bình: {mean:F2}");
        }
    }
}