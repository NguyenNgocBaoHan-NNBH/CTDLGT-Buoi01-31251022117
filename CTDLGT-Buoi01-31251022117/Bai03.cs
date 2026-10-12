using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CTDLGT_Buoi01_31251022117
{
    internal class Bai03
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Chọn chế độ nhập dữ liệu:");
            Console.WriteLine("1. Tự gõ mảng bằng tay (Để test các ví dụ ngắn)");
            Console.WriteLine("2. Nhập kích thước n để máy tự sinh mảng (Để lấy số liệu điền bảng 100, 1000, 10000)");
            Console.Write("Lựa chọn của bạn (1 hoặc 2): ");

            string chon = Console.ReadLine();
            int[] data;

            if (chon == "1")
            {
                Console.WriteLine("\nNhập các phần tử cách nhau bởi dấu cách:");
                string input = Console.ReadLine();
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                data = new int[tokens.Length];
                for (int i = 0; i < tokens.Length; i++)
                {
                    data[i] = int.Parse(tokens[i]);
                }
            }
            else
            {
                Console.Write("\nNhập kích thước n (Ví dụ: 100, 1000, hoặc 10000): ");
                int n = int.Parse(Console.ReadLine());

                Random rand = new Random(42);
                data = new int[n];
                for (int i = 0; i < n; i++)
                {
                    data[i] = rand.Next(-100, 100);
                }
                Console.WriteLine($"Mảng gồm {n} phần tử");
            }


            var stopwatchA = Stopwatch.StartNew();
            long resultA = TinhMaxSubArray_On2(data);
            stopwatchA.Stop();

            Console.WriteLine($"[Phiên bản A Θ(n²)]");
            Console.WriteLine($"-> Tổng lớn nhất: {resultA}");
            Console.WriteLine($"-> Thời gian chạy: {stopwatchA.Elapsed.TotalMilliseconds} ms");

            var stopwatchB = Stopwatch.StartNew();
            long resultB = TinhMaxSubArray_Kadane(data);
            stopwatchB.Stop();

            Console.WriteLine($"[Phiên bản B Kadane Θ(n)]");
            Console.WriteLine($"-> Tổng lớn nhất: {resultB}");
            Console.WriteLine($"-> Thời gian chạy: {stopwatchB.Elapsed.TotalMilliseconds} ms");

            Console.ReadKey();
        }

        // PHIÊN BẢN A: Θ(n²)
        public static long TinhMaxSubArray_On2(int[] arr)
        {
            long max_sum = long.MinValue;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                long current_sum = 0;
                for (int j = i; j < n; j++)
                {
                    current_sum += arr[j];
                    if (current_sum > max_sum) max_sum = current_sum;
                }
            }
            return max_sum;
        }

        // PHIÊN BẢN B: Kadane Θ(n)
        public static long TinhMaxSubArray_Kadane(int[] arr)
        {
            long max_so_far = arr[0];
            long curr_max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                curr_max = Math.Max(arr[i], curr_max + arr[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }
            return max_so_far;
        }
    }
}

