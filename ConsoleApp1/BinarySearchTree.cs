using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Binary_Trees
{
    class BinarySearchTree
    {
        public Node root;
        public Node current;
        private IComparer<int> _comparer = Comparer<int>.Default;

        internal Node Root { get => root; set => root = value; }
        internal Node Current { get => current; set => current = value; }

        public BinarySearchTree()
        {
            root = null;
            current = null;
        }

        public bool Insert(char v)
        {
            if (root == null)
            {
                root = new Node(v);
                return true;

            }
            else
            {
                return Insert2(root, v);
            }
        }

        private bool Insert2(Node Node, char Item)
        {
            if (_comparer.Compare(Node.letter, Item) < 0)
            {
                if (Node.right == null)
                {
                    Node.right = new Node(Item);
                    return true;
                }
                else
                {
                    return Insert2(Node.right, Item);
                }
            }
            else if (_comparer.Compare(Node.letter, Item) > 0)
            {
                if (Node.left == null)
                {
                    Node.left = new Node(Item);
                    return true;
                }
                else
                {
                    return Insert2(Node.left, Item);
                }
            }
            else
            {
                return false;
            }
        }
    }
}
