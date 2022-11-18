﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*Node class represent the node of doubly linked list
         * It consist of the information part amnd links to
         * Its succeding and preceeding
         * in terms on next and previousm */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the precceding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;

        //constructor

        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;  

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START !=null) START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
