using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251022117
{
    internal class Bai02
    {
        static void KhoiTaoMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Phần tử thứ {i}: "); arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Tim2SoLonNhatPhanBiet(int[] arr)
        {
            int? max1 = null;
            int? max2 = null;

            for (int i = 0; i < arr.Length; i++)
            {
                int x = arr[i];
                if (max1 == null || x > max1)
                {
                    max2 = max1;
                    max1 = x;
                }
                else if (x < max1 && (max2 == null || x > max2))
                {
                    max2 = x;
                }
            }

            if (max2 == null)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine($"{max1}  {max2}");
            }
        }

        static void Main2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: "); int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            KhoiTaoMang(arr);
            Tim2SoLonNhatPhanBiet(arr);
        }
    }
}
