﻿using System;

namespace Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example 1

            Random rand = new Random();
            Console.WriteLine("Enter the size of the array...");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-10, 11);
                Console.Write($"{numbers[i]}  ");
            }
            Console.WriteLine($"\n{"  <-Elements of an array->",28}");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}  ");
            }
            Console.ReadKey();

            #endregion

            #region Example 2
            Console.Clear();
            Console.WriteLine("Enter the size of the array...");
            int m = int.Parse(Console.ReadLine());

            int[] numbers2 = new int[m];
            int eventElement = 0;
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = rand.Next(21);
                Console.Write($"{numbers2[i]}  ");
                if (numbers2[i] % 2 == 0)
                {
                    eventElement++;
                }
            }
            Console.WriteLine($"\n Event element={eventElement}");
            Console.ReadKey();

            #endregion
            Console.Clear();
            #region Example 3
            int[] numbers_10 = new int[10];
            for (int i = 0; i < numbers_10.Length; i++)
            {
                numbers_10[i] = rand.Next(20);
                Console.Write($"{numbers_10[i]}  ");
            }
            Console.WriteLine("\nThe item you are looking for");
            Console.WriteLine("Enter the find element...");
            int element = int.Parse(Console.ReadLine());
            int find = 0;
            for (int i = 0; i < numbers_10.Length; i++)
            {
                if (numbers_10[i] == element)
                {
                    find++;
                }
            }
            Console.WriteLine($"Element {element} to {find} times.");

            #endregion
            #region Example 4
            Console.Clear();
            Console.WriteLine("Enter the size of the array...");
            int size_of = int.Parse(Console.ReadLine());
            int[] array = new int[size_of];
            Console.WriteLine("Array element");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2);
                Console.Write($"{array[i]} ");
            }

            int head = 0;
            int tail = array.Length - 1;

            bool flag = true;

            while (head < tail)
            {
                if (flag)
                {
                    if (array[head] == 1)
                    {
                        flag = false;
                    }
                    else head++;
                }
                else
                {
                    if (array[tail] == 0)
                    {
                        flag = true;
                    }
                    else tail--;
                }

                if (array[head] == 1 && array[tail] == 0)
                {
                    int temp = array[head];
                    array[head] = array[tail];
                    array[tail] = temp;

                    head++;
                    tail--;
                }

            }

            Console.WriteLine("\nChange array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            #endregion
            #region .. and ^
            Console.WriteLine("\nindices and ranges...");
            string[] words = new string[]
            {
                          // index from start    index from end
              "The",      // 0                   ^9
              "quick",    // 1                   ^8
              "brown",    // 2                   ^7
              "fox",      // 3                   ^6
              "jumped",   // 4                   ^5
              "over",     // 5                   ^4
              "the",      // 6                   ^3
              "lazy",     // 7                   ^2
              "dog"       // 8                   ^1
            };            // 9 (or words.Length) ^0

            for (int i = 1; i <= words.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{words[^i]}\t");
            }
            Console.ForegroundColor = ConsoleColor.Green;

            string[] quickBrownFox = words[1..4];
            foreach (var word in quickBrownFox)
                Console.Write($"< {word} >");
            Console.WriteLine();

            string[] lazyDog = words[^2..^0];
            foreach (var word in lazyDog)
                Console.Write($"< {word} >");
            Console.WriteLine();

            Console.WriteLine("allWords,firstPhrase,lastPhrase...");
            string[] allWords = words[..]; // contains "The" through "dog".
            string[] firstPhrase = words[..4]; // contains "The" through "fox"
            string[] lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
            foreach (var word in allWords)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in firstPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in lastPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();

            Index the = ^3;
            Console.WriteLine(words[the]);
            Range phrase = 1..4;
            string[] text = words[phrase];
            foreach (var word in text)
                Console.Write($"< {word} >");
            Console.WriteLine();
            #endregion
            #region
            int size = rand.Next(10);
            int[] arr = new int[size];
            int[] brr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(10);
                brr[i] = rand.Next(10);
            }
            int maxArr = arr[0];
            int minArr = arr[0];
            int maxBrr = brr[0];
            int minBrr = brr[0];

            for (int i = 0; i < size; i++)
            {
                if (maxArr < arr[i]) maxArr = arr[i];
                if (minArr > arr[i]) minArr = arr[i];

                if (maxBrr < brr[i]) maxBrr = brr[i];
                if (minBrr > brr[i]) minBrr = brr[i];
            }
            Console.WriteLine("array arr");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"maxArr={maxArr}  minArr={minArr}");
            Console.WriteLine();

            Console.WriteLine("array brr");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{brr[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"maxBrr={maxBrr}  minBrr={minBrr}");
            #endregion

            #region
            Console.WriteLine("Array-->");
            int[] arrAy = new int[10];
            for (int i = 0; i < arrAy.Length; i++)
            {
                arrAy[i] = rand.Next(10);
                Console.Write($"{arrAy[i]}\t");
            }

            Console.WriteLine("\nSort Array");
            int temp1;
            for (int i = 0; i < arrAy.Length; i++)
            {
                for (int j = i+1; j < arrAy.Length; j++)
                {
                    if (arrAy[i]>arrAy[j])
                    {
                        temp1 = arrAy[i];
                        arrAy[i] = arrAy[j];
                        arrAy[j] = temp1;
                    }
                }
            }
            for (int i = 0; i < arrAy.Length; i++)
            {
                Console.Write($"{arrAy[i]}\t");
            }
            #endregion
        }
    }
}
