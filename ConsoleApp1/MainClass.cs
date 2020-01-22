using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Binary_Trees
{
    class MainClassTesting123
    {
        static void Main(string[] args)
        {
            // make new tree
            Tree bst = new Tree();
            BinarySearchTree St = new BinarySearchTree();

            char a = 'a';

            St.Insert(a);

            // formats output
            WriteLine(bst.ToString());         

            // keeps console open until key is pressed
            ReadKey();
        }     
    }   
}
