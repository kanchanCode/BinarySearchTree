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
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                Console.Write("L"+leftCount);
                this.LeftTree.Display();
            }
            Console.Write(this.NodeData.ToString()+" ");
            if(this.RightTree != null)
            {
                this.rightCount++;
                Console.Write("R" + rightCount);

                this.RightTree.Display();
            }

        }


    }
}
