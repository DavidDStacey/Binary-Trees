using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    class Tree
    {
        public Node Insert(Node root, char v)
        {
            if (root == null)
            {
                root = new Node();
                root.letter = v;
            }
            else if (v < root.letter)
            {
                root.left = Insert(root.left, v);
            }
            else
            {
                root.right = Insert(root.right, v);
            }
            return root;
        }

        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left);
            Traverse(root.right);
        }
    }
}
