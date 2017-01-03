using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    class Program
    {
        static void Main(string[] args)
        {
            IntTree BST = new IntTree();
            BST.AddItem(15);
            BST.AddItem(30);
            BST.AddItem(45);
            BST.AddItem(35);
            BST.AddItem(10);
            BST.AddItem(5);
            BST.AddItem(7);

            Console.WriteLine();
            Console.ReadKey();
        
        }
    }
}
