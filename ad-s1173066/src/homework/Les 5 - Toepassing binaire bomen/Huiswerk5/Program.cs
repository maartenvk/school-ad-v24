﻿namespace AD
{
    class Program
    {
        static void Opgave1()
        {
            BinarySearchTree<int> bst;

            System.Console.WriteLine("\n=====   Opgave 1 : BST   =====\n");

            bst = new BinarySearchTree<int>();
            System.Console.WriteLine(bst);
            bst.Insert(3);
            bst.Insert(1);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(9);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            System.Console.WriteLine(bst.ToInfixString());
            System.Console.WriteLine(bst);
            bst.Remove(6);

            System.Console.WriteLine();

            bst = new BinarySearchTree<int>();
            bst.Insert(6);
            System.Console.WriteLine(bst.ToInfixString());
            bst.Insert(4);
            bst.Insert(7);
            bst.Insert(2);
            bst.Insert(5);
            System.Console.WriteLine(bst.ToInfixString());
            System.Console.WriteLine(bst);
        }


        static void Opgave2()
        {
            PriorityQueue<int> pq = new PriorityQueue<int>();

            System.Console.WriteLine("\n=====   Opgave 2 : PriorityQueue   =====\n");

            pq.Add(1);
            pq.Add(2);
            pq.Add(3);
            pq.Add(7);
            pq.Add(5);
            pq.Add(6);
            pq.Add(12);
            pq.Add(14);
            pq.Add(9);
            pq.Add(13);
            pq.Add(8);
            System.Console.WriteLine(pq);  // 1 2 3 7 5 6 12 14 9 13 8
            pq.Remove();
            System.Console.WriteLine(pq);  // 2 5 3 7 8 6 12 14 9 13
            pq.Remove();
            System.Console.WriteLine(pq);  // 3 5 6 7 8 13 12 14 9
            pq.Remove();
            System.Console.WriteLine(pq);  // 5 7 6 9 8 13 12 14
            pq.Remove();
            System.Console.WriteLine(pq);  // 6 7 12 9 8 13 14
        }

        static void Opgave3()
        {
            var pq = new PriorityQueue<int>();

            System.Console.WriteLine("\n===== Opgave 3 : BuildHeap =====\n");

            int[] elements = new[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            foreach (int element in elements)
                pq.AddFreely(element);

            System.Console.WriteLine(pq); // 20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1
            pq.BuildHeap();
            System.Console.WriteLine("After BuildHeap");
            System.Console.WriteLine(pq); // 1 2 6 3 10 8 7 4 12 11 19 9 15 18 14 5 13 17 20 16
        }

        static void Main(string[] args)
        {
            Opgave1();
            Opgave2();
            Opgave3();
        }
    }
}
