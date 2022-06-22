using System;

namespace Implementing_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var idk = new DoublyLinkedList<int>();
            idk.AddHead(1);
            idk.AddHead(2);
            idk.AddHead(3);
            idk.AddTail(4);

            Console.WriteLine($"Head: {idk.Head.Value}");
            Console.WriteLine($"Tail: {idk.Tail.Value}");

            Console.WriteLine($"Removed Head : {idk.RemoveHead()}");
            Console.WriteLine($"Head: {idk.Head.Value}");

            Console.WriteLine($"Removed Tail : {idk.RemoveTail()}");
            Console.WriteLine($"Tail: {idk.Tail.Value}");







        }
    }
}
