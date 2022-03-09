using System;

namespace MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RefOutPractice

            //int[] numbers = {-1, 20, -5, 0, 6};


            //int[] arr = NegativeToPositive(ref numbers);
            //foreach (var item in NegativeToPositive(ref numbers))
            //{
            //    Console.WriteLine(item);
            //}
            //int[] arr = numbers;
            #endregion

            #region HomeWorks
            //Console.WriteLine(Sum(1,23,4,5));
            //Console.WriteLine(LetterCount("salam", 'a'));

            //int[] arr = { 1, 2, 3, 4 };

            //Console.WriteLine(Search(arr, 5));

            //Console.WriteLine(Area(5));
            #endregion
        }

        #region HomeWorks 
        //static int Area(int r)
        //{
        //    return 3 * r * r;
        //}

        //static int Area(int a, int b)
        //{
        //    return a * b;
        //}

        //static int Area(int a, int b, int c, int r)
        //{
        //    int p = (a + b + c) / 2;

        //    return p * r;
        //}

        //static bool Search(int[] arr, int number)
        //{
        //    int start = 0;
        //    int end = arr.Length;

        //    while (start < end)
        //    {
        //        int mid = (start + end) / 2;

        //        if(arr[mid] == number)
        //            return true;

        //        if(arr[mid] < number)
        //        {
        //            start = mid + 1;
        //        }
        //        else
        //        {
        //            end = mid - 1;
        //        }
        //    }

        //    return false;
        //}

        //static int Sum(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var number in numbers)
        //    {
        //        sum += number;
        //    }

        //    return sum;
        //}

        //salam a
        //static int LetterCount(string word, char letter)
        //{
        //    int count = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if(word[i] == letter)
        //            count++;
        //    }

        //    return count;
        //}
        #endregion

        #region RefOutPractice
        //static int[] NegativeToPositive(ref int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < 0)
        //            arr[i] *= -1;
        //    }

        //    return arr;
        //}
        #endregion
    }
}
