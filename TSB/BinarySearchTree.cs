﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek_1.TSB
{
    internal class BinarySearchTree
    {
        public Defence Root {  get; set; }
        public BinarySearchTree(List<Defence> children)
        {
            for(int i = 0; i < children.Count; ++i)
            {
                this.Insert(children[i]);
            }
        }

        public void Insert(Defence node)
        {
            Root = Insert(Root, node);
        }

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

        public Defence Find(int value)
        {
            return Find(Root, value);
        }

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

        public void Print()
        {
            PreOrderTraversal(Root);
        }
        public int Min()
        {
            return Min(Root);
        }

        private int Min(Defence root)
        {
            if(root.Left == null)
                return root.MinSeverity;
            return Min(root.Left);

        }
        private void PreOrderTraversal(Defence root)
        {
            if(root == null) return;
            Console.WriteLine(root.ToString());
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }
    }
}
