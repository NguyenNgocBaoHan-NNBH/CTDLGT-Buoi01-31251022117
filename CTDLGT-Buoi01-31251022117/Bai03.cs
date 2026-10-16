using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CTDLGT_Buoi01_31251022117
{
    internal class Bai03
    {
        static long VersionA(int[] arr)
        {
            long maxSum = long.MinValue;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                long currentSum = 0;
                for (int j = i; j < n; j++)
                {
                    currentSum += arr[j];
                    if (currentSum > maxSum) maxSum = currentSum;
                }
            }
            return maxSum;
        }

        static long VersionB(int[] arr)
        {
            long maxSoFar = arr[0];
            long currentMax = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currentMax = Math.Max(arr[i], currentMax + arr[i]);
                maxSoFar = Math.Max(maxSoFar, currentMax);
            }
            return maxSoFar;
        }

        static void Main3()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: "); int userN = int.Parse(Console.ReadLine());
            int[] userArr = new int[userN];
            for (int i = 0; i < userN; i++)
            {
                Console.Write($"Phần tử thứ {i}: "); userArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"-> Phiên bản A: {VersionA(userArr)}");
            Console.WriteLine($"-> Phiên bản B: {VersionB(userArr)}");

            Console.Write("\nNhập n lớn để thử nghiệm (vd 100, 200,...): ");
            int size = int.Parse(Console.ReadLine());

            int[] data = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = rand.Next(-100, 100);
            }
            var stopwatchA = System.Diagnostics.Stopwatch.StartNew();
            var resultA = VersionA(data);
            stopwatchA.Stop();
            Console.Write("Thời gian phiên bản A: ");
            Console.WriteLine(stopwatchA.Elapsed.TotalMilliseconds);

            var stopwatchB = System.Diagnostics.Stopwatch.StartNew();
            var resultB = VersionB(data);
            stopwatchB.Stop();
            Console.Write("Thời gian phiên bản B: ");
            Console.WriteLine(stopwatchB.Elapsed.TotalMilliseconds);
        }
    }
}