using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Binary_Trees
{
    class Node
    {
        // properties
        public char letter;
        public Node left;
        public Node right;


        public char Letter { get => letter; set => letter = value; }
        internal Node Left { get => left; set => left = value; }
        internal Node Right { get => right; set => right = value; }


        // constructor
        public Node()
        {
            letter = '\0';
            left = null;
            right = null;
        }

        // constructor
        public Node(char data)
        {
            this.letter = data;
        }

        public override string ToString() 
        {
            var lString = this.Left != null ? this.Left.ToString() : "null";
            var rString = this.Right != null ? this.Right.ToString() : "null";
            var dString = this.Letter != '\0' ? this.Letter.ToString() : "empty node";

            lString = String.Join("\n", lString.Split('\n').Select(a => "\t" + a));
            rString = String.Join("\n", rString.Split('\n').Select(a => "\t" + a));

            return String.Format("\nData: {0}\nLeft: {1}\nRight: {2}", dString, lString, rString);
        }
    }
}