using System;
using System.Collections.Generic;

namespace Implementing_Stack_and_Queue
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var originalList = new List<int>();

            var list = new MyList();

            Console.WriteLine($"Count before Adding: {list.Count}");
            list.Add(0);
            list.Add(1);
            Console.WriteLine($"Count after adding two numbers in the list: {list.Count}");
            list.Add(2);
            list.Add(3);
            Console.WriteLine($"Count after adding over the initial capacity of 2: {list.Count}");
            list.Add(4);
            list.Add(5);
            Console.WriteLine($"Count after one more resize: {list.Count}");
            Console.WriteLine($"Capacity after the above operations: {list.Capacity()}\n");

            list[0] = 3;
            Console.WriteLine($"Indexer functionality added - list[0] = 3 : {list[0]}\n");

            Console.WriteLine($"Remove at index \"0\" and return the value:  {list.RemoveAt(0)}\n");
            Console.WriteLine($"Count after removing at 0 index: {list.Count}");
            Console.WriteLine($"Capacity after removing at index \"0\": {list.Capacity()} \n");
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            Console.WriteLine($"Count after removing at index 0 three more times: {list.Count}\n");
            Console.WriteLine($"List capacity after all the removes: {list.Capacity()}\n");

            Console.WriteLine("List.Clear();");
            list.Clear();
            Console.WriteLine($"List.Count : {list.Count}, List.Capacity : {list.Capacity()}");
            Console.WriteLine($"List.Contains(5) : {list.Contains(5)}");
            for (int i = 1; i <= 10; i++)// list.Add(0 - 10)
            {
                list.Add(i);
            }
            Console.WriteLine($"Added 1 - 10 to the list : List.Count - {list.Count}, List.Capacity - {list.Capacity()}");
            Console.WriteLine($"List.Contains(5) : {list.Contains(5)}");
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            //list.Add(17);
            Console.WriteLine($"Added 11 - 16 to the list : List.Count - {list.Count}, List.Capacity - {list.Capacity()}");
            Console.WriteLine($"List.Find(15) - {list.Find(15)}");

            Console.WriteLine("\nList.Clear();\n");
            list.Clear();
            list.Add(0);
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine($"We have 0, 1, 3, 4 and 5 in the list, list[2] == {list[2]} at the moment.");
            list.Insert(2, 2);
            Console.WriteLine($"After List.Insert(2, 2) on index 2 of our list we have list[2] == {list[2]} at the moment.");
            //list.Insert(0, 10);
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);

            Console.WriteLine("\nList.Clear();\n");
            list.Clear();
            list.Add(1);
            list.Add(0);
            Console.WriteLine($"Before swap : list[0]=={list[0]}, list[1]=={list[1]}");
            list.Swap(0, 1);
            Console.WriteLine($"After swap : list[0]=={list[0]}, list[1]=={list[1]}");

            Console.WriteLine("\nList.Clear();\n");
            list.Clear();
            for (int i = 0; i < 7; i++)
                list.Add(i);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[4]);
            Console.WriteLine(list[5]);
            Console.WriteLine(list[6]);
            Console.WriteLine($"Reverse : ");
            list.Reverse();
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[4]);
            Console.WriteLine(list[5]);
            Console.WriteLine(list[6]);
            //Console.WriteLine(String.Join(',',list));
            //foreach(var element in list)
            //{

            //}




        }
    }
}
