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

        }
    }
}
