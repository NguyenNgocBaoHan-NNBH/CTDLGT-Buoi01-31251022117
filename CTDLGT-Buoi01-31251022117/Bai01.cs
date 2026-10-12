using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251022117
{
    internal class Bai01
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập 3 số nguyên a, b, c (cách nhau bởi dấu cách): ");

            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input.Length >= 3 &&
                long.TryParse(input[0], out long a) &&
                long.TryParse(input[1], out long b) &&
                long.TryParse(input[2], out long c))
            {
                long max = Math.Max(a, Math.Max(b, c));
                long min = Math.Min(a, Math.Min(b, c));

                long tong = a + b + c;
                double trungBinh = tong / 3.0;

                Console.WriteLine($"Lớn nhất: {max}; nhỏ nhất: {min}; tổng: {tong}; trung bình: {trungBinh:F2}");
            }
            else
            {
                Console.WriteLine("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập đúng 3 số nguyên.");
            }
        }
    }
}

