 using System;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree!");
            binaryTree<int> binaryObj = new binaryTree<int>(56);
            binaryObj.insert(30);
            binaryObj.insert(70);
            binaryObj.insert(22);
            binaryObj.insert(40);
            binaryObj.insert(60);
            binaryObj.insert(95);
            binaryObj.insert(65);
            binaryObj.insert(63);
            binaryObj.insert(67);
            binaryObj.insert(11);
            binaryObj.insert(3);
            binaryObj.insert(16);

            binaryObj.Display();
            binaryObj.GetSize();
        }
    }
}
