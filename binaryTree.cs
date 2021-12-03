using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Tree
{
    class binaryTree<T> where T:IComparable<T>
    {
      public T NodeData { get; set; }
      public binaryTree<T> LeftTree { get; set; }
      public binaryTree<T> RightTree { get; set; }
        int n = 0;
      public binaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        public void insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item))>0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new binaryTree<T>(item);
                else
                    this.LeftTree.insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new binaryTree<T>(item);
                else
                    this.RightTree.insert(item);
            }
            n = n + 1;
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.Write(this.NodeData.ToString()+" ");
            if(this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void GetSize()
        {
            this.leftCount += 1;
            this.rightCount += 1;
            int k = n + 1;
            Console.WriteLine("\nsize or number of nodes "+k);
            Console.WriteLine("\nHeight of BST is"+" "+(1+this.leftCount+this.rightCount));
        }

        /*public void ifExist(T element,binaryTree<T> node)
        {
            if(node==null)
                return false;
        }*/
    }
}
