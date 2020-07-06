using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Practice
{
    class MyLinkedList
    {
        public Node Header { get; set; }

        public Node Pointer { get; set; }

        public void AddFirst(int value)
        {
            Node node = new Node(value);

            if (Pointer == null)
            {
                Pointer = node;
                Header = Pointer;
            }
            else
            {
                node.Next = Header;
                Header = node;
            }
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);

            if (Pointer == null)
            {
                Pointer = node;
                Header = Pointer;
            }
            else
            {
                Pointer.Next = node;
                Pointer = Pointer.Next;
            }
        }

        public void RemoveFirst()
        {
            if (Header == null)
            {
                Console.WriteLine("No Node found.");
            }
            else if (Header.Next == null)
            {
                Header = null;
                Pointer = null;
            }
            else
            {
                Header = Header.Next;
            }
        }

        public void RemoveLast()
        {
            if (Header == null)
            {
                Console.WriteLine("No Node found.");
            }
            else if (Header.Next == null)
            {
                Header = null;
                Pointer = null;
            }
            else
            {
                Node secondLast = Header;

                while (secondLast.Next.Next != null)
                {
                    secondLast = secondLast.Next;
                }

                secondLast.Next = null;
                Pointer = secondLast;
            }
        }

        public void RemoveNode(int value)
        {
            if (Header.Value == value)
            {
                Header = Header.Next;
            }
            else
            {
                Node node = Header;
                while (node != null)
                {
                    Node prevNode = node;
                    if (prevNode != null)
                    {
                        Node nextNode = node.Next;
                        if (nextNode != null)
                        {
                            Node tempNode = nextNode.Next;
                            if (nextNode.Value == value)
                            {
                                prevNode.Next = tempNode;
                            }
                        }
                    }

                    node = node.Next;
                }
            }
        }

        public void Print()
        {
            Node current = Header;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
