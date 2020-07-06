﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Practice
{
    class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
