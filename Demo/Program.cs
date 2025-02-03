using System.Collections;

namespace Demo
{
    internal class Program
    {
        #region  Q1)	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        //public static void ReverseArrayList(ArrayList arr)
        //{

        //    if (arr != null)
        //    {
        //        object temp = 0;

        //        for (int i = 0; i < (arr.Count) / 2; i++)
        //        {
        //            temp = arr[i]; //1

        //            arr[i] = arr[arr.Count - 1 - i];

        //            arr[arr.Count - 1 - i] = temp;
        //        }
        //    }

        //}

        #endregion


        #region 5.	Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
        //public static void CheckForArrayQueries(int size, int noQ)
        //{
        //    int[] numbers = new int[size];
        //    int[] quires = new int[noQ];
        //    bool isParsed = false;
        //    for (int i = 0; i < size; i++)
        //    {
        //        do
        //        {
        //            Console.Write($"Enter the {i + 1} element of the array: ");
        //            isParsed = int.TryParse(Console.ReadLine(), out numbers[i]);
        //        }
        //        while (!isParsed);

        //    }

        //    for (int i = 0; i < noQ; i++)
        //    {
        //        do
        //        {
        //            Console.Write($"Enter the {i + 1} number of quires : ");
        //            isParsed = int.TryParse(Console.ReadLine(), out quires[i]);
        //        }
        //        while (!isParsed);

        //    }
        //    int counter = 0;

        //    for (int i = 0; i < quires.Length; i++)
        //    {
        //        counter = 0;
        //        for (int j = 0; j < numbers.Length; j++)
        //        {
        //            if (quires[i] < numbers[j])
        //                counter++;

        //        }
        //        Console.Write($"{counter} ");
        //    }

        //}
        #endregion


        #region Q6)	Given a number N and an array of N numbers. Determine if it's palindrome or not.

        //public static void CheckForPalindrome(int n) {
        //    int[] numbers = new int[n];

        //    bool isParsed = false;
        //    for (int i = 0; i < n; i++)
        //    {
        //        do
        //        {
        //            Console.Write($"Enter the {i + 1} element of the array: ");
        //            isParsed = int.TryParse(Console.ReadLine(), out numbers[i]);
        //        }
        //        while (!isParsed);

        //    }

        //    bool notPalindrome=false;
        //    for (int i = 0; i < (numbers.Length) / 2; i++)
        //    {
        //        if (numbers[i] != numbers[numbers.Length - 1 - i]) {
        //            notPalindrome = true;
        //            break;
        //        }

        //    }
        //    if(notPalindrome)
        //        Console.WriteLine("No");
        //    else
        //        Console.WriteLine("YES");

        //}

        #endregion

        #region Q7)	Given an array, implement a function to remove duplicate elements from an array.

        //public static int[] RemoveDuplicates(int[] arr)
        //{
        //    int[] newarr = new int[arr.Length];

        //    bool Found = false;
        //    int counter = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Found = false;
        //        for (int j = 0; j < arr.Length; j++)
        //        {
        //            if (i == j) {
        //                continue;
        //            }

        //            if (arr[i] == arr[j])
        //            {
        //                Found = true;
        //                break;

        //            }
        //        }
        //        if (!Found)
        //        {

        //            newarr[counter++] = arr[i];
        //        }
        //    }

        //    int[] returnedArray = new int[counter];

        //    for (int i = 0; i < counter; i++)
        //    {
        //        if (newarr[i] != 0)
        //        {

        //            returnedArray[i] = newarr[i];
        //        }
        //    }




        //    return returnedArray;
        //}
        #endregion



        static void Main(string[] args)
        {
            #region  Q1)	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList arr = new ArrayList(5) { 1, 2, 3, 4, 5 };

            //ReverseArrayList(arr);

            //foreach (int i in arr)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Q2)	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> numbers = new List<int>(5) { 1,2,3,4,5};

            //List<int> result=new List<int>(5);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] %2 == 0)
            //        result.Add(numbers[i]);
            //}
            //foreach (int i in result) {
            //    Console.Write($"{i} ");
            //}


            #endregion


            #region 3.	implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.


            //FixedSizeList<int> fixedlist= new FixedSizeList<int> (5);

            //fixedlist.Add (5);
            //fixedlist.Add (5);
            //fixedlist.Add (5);
            //fixedlist.Add (5);
            //fixedlist.Add (5);
            //fixedlist.Add (5);
            //Console.WriteLine(fixedlist.Get(0));
            #endregion


            #region Q4)	Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
            //string x = "Helo Mstfa";
            //int firstApp = -1;
            //bool flag = false;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    flag = false;
            //    for (int j = 0; j < x.Length; j++)
            //    {
            //        if (i == j) {
            //            continue;
            //        }
            //        if (x[i] == x[j]) {
            //            firstApp = j;
            //            flag = true;
            //            break;

            //        }
            //    }
            //    if (flag) {
            //        break;
            //    }

            //}
            //if (firstApp == -1)
            //{
            //    Console.WriteLine(-1);
            //}
            //else {
            //    Console.WriteLine(x[firstApp]);
            //}


            #endregion

            #region Q5)	Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //CheckForArrayQueries(3, 3);

            #endregion
            #region Q6.	Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //CheckForPalindrome(4);
            #endregion
            #region Q7)	Given an array, implement a function to remove duplicate elements from an array.
            //int[] x = RemoveDuplicates(new int[] { 1, 2, 3, 4, 2 });

            //foreach (int i in x)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion



            #region Q8)	 Given an array list , implement a function to remove all odd numbers from it.
            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //List<int> result = new List<int>(5);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //        result.Add(numbers[i]);
            //}
            //foreach (int i in result)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion
        }
    }
}
