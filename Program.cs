using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddLast(10);
            myLinkedList.AddLast(20);
            myLinkedList.AddLast(30);
            myLinkedList.AddLast(40);
            myLinkedList.AddLast(50);
            myLinkedList.AddLast(60);
            myLinkedList.AddLast(70);
            myLinkedList.AddLast(50);

            Console.WriteLine("List contains these numbers.");
            myLinkedList.Print();

            Console.Write("\nEnter a number which you wanna remove: ");
            int num = Int32.Parse(Console.ReadLine());

            myLinkedList.RemoveNode(num);

            Console.WriteLine("\nAfter Removing Node(s).");

            myLinkedList.Print();
        }
    }
}
