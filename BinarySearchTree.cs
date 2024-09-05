using System;
using System.Collections.Generic;


namespace TestWeek_1.TSB
{
    internal class BinarySearchTree
    {
        private Defence _root {  get; set; }

        //O(n log(n)).
        public BinarySearchTree(List<Defence> children)
        {
            for(int i = 0; i < children.Count; ++i)
            {
                this.Insert(children[i]);
            }
        }

        //O(log(n)).
        public void Insert(Defence node)
        {
            _root = Insert(_root, node);
        }

        //O(log(n)).
        private Defence Insert(Defence root, Defence node)
        {
            if (root == null)
                return node;

            if (node.MaxSeverity < root.MinSeverity)
                root.Left = Insert(root.Left, node);
            else
                root.Right = Insert(root.Right, node);

            return root;
        }

        //O(log(n)).
        public Defence Find(int value)
        {
            return Find(_root, value);
        }

        //O(log(n)).
        private Defence Find(Defence root, int value)
        {
            if (root == null)
                return null;
            if (value < root.MinSeverity)
                return Find(root.Left, value);
            else if (value > root.MaxSeverity)
                return Find(root.Right, value);
            else
                return root;
        }

        //O(n).
        public void Print()
        {
            PreOrderTraversal(_root);
        }

        //O(log(n)).
        public int Min()
        {
            return Min(_root);
        }

        //O(log(n)).
        private int Min(Defence root)
        {
            if(root.Left == null)
                return root.MinSeverity;
            return Min(root.Left);

        }

        //O(n).
        private void PreOrderTraversal(Defence root)
        {
            if(root == null) return;
            Console.WriteLine(root.ToString());
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

    }

}
