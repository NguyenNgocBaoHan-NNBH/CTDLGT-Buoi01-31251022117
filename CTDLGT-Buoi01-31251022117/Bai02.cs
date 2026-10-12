using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251022117
{
    internal class Bai02
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử n (2 <= n <= 100000): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Số lượng phần tử không hợp lệ.");
                return;
            }

            Console.WriteLine($"Nhập {n} phần tử của mảng (cách nhau bởi dấu cách):");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            bool coMax1 = false;
            bool coMax2 = false;

            for (int i = 0; i < n; i++)
            {
                int val = arr[i];

                if (!coMax1)
                {
                    max1 = val;
                    coMax1 = true;
                }
                else if (val > max1)
                {
                    max2 = max1;
                    coMax2 = coMax1;
                    max1 = val;
                }
                else if (val < max1)
                {
                    if (!coMax2 || val > max2)
                    {
                        max2 = val;
                        coMax2 = true;
                    }
                }
            }

            if (coMax2)
            {
                Console.WriteLine($"{max1} {max2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
