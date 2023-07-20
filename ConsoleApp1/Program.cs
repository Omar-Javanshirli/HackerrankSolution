using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int fact = number;

            for (int i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            var a = factorial_Recursion(5);
            string path = "UDDDUDUU";

        }

        static string catAndMouse(int x, int y, int z)
        {
            int catA = Math.Abs(z - x); 
            int catB = Math.Abs(z - y); 

            if (catA < catB)
                return "Cat A";
            else if (catA > catB)
                return "Cat B";
            else
                return "Mouse C";
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxSpent = -1;
            foreach (int keyboardPrice in keyboards)
            {
                foreach (int drivePrice in drives)
                {
                    int totalPrice = drivePrice + keyboardPrice;

                    if (totalPrice <= b && totalPrice > maxSpent)
                        maxSpent = totalPrice;
                }
            }
            return maxSpent;
        }

        public static int countingValleys(int steps, string path)
        {
            int seaLevel = 0;
            int valleyCount = 0;

            foreach (char step in path)
            {
                if (step == 'U')
                    seaLevel++;

                else if (step == 'D')
                    seaLevel--;

                if (seaLevel == 0 && step == 'U')
                    valleyCount++;
            }

            return valleyCount;
        }

        public static int pageCount(int n, int p)
        {
            int fromStart = p / 2;
            int fromEnd = n % 2 == 0 ? (n - p + 1) / 2 : (n - p) / 2;
            return Math.Min(fromStart, fromEnd);
        }

        public static int sockMerchant(int n, List<int> ar)
        {
            int total = 0;
            List<int> checkList = new List<int>();

            for (int i = 0; i < ar.Count; i++)
            {
                int count = 0;

                if (checkList.Contains(ar[i]))
                    continue;
                else
                    checkList.Add(ar[i]);

                for (int j = 0; j < ar.Count; j++)
                {
                    if (ar[i] == ar[j])
                        count++;
                }
                if (count % 2 == 0)
                    total += count / 2;
                else
                {
                    int a = count / 2;
                    total += a;
                }
            }

            return total;
        }

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int total = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                    continue;

                total += bill[i];
            }

            if (total % b == 0)
                Console.WriteLine("Bon Appetit");
            else
            {
                var result = total / 2;
                result = b - result;
                Console.WriteLine(result);
            }
        }

        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdCounts = new Dictionary<int, int>()
            {
                {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}
            };

            foreach (int birdType in arr)
            {
                if (birdCounts.ContainsKey(birdType))
                {
                    birdCounts[birdType]++;
                    Console.WriteLine();
                }
            }

            int maxFrequency = 0;
            int mostCommonBird = 0;

            foreach (var kvp in birdCounts)
            {
                if (kvp.Value > maxFrequency || (kvp.Value == maxFrequency && kvp.Key < mostCommonBird))
                {
                    maxFrequency = kvp.Value;
                    mostCommonBird = kvp.Key;
                }
            }
            return mostCommonBird;
        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        count++;
                }
            }
            return count;
        }

        public static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }
    }
}
