using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    class IntTree
    {
        Node firstNode;        
        public IntTree()
        {
            int item = 0;
            firstNode = new Node(item);
        }
        public void AddItem(int item)
        {
            Node AddedNode = new Node(item);
            Node current = firstNode;
            Node parent = null;
            int results;
            if (firstNode.Value == default(int) && firstNode.Left == null && firstNode.Right == null)
            {
                firstNode.Value = item;
            }
            else
            { 
                while (current != null)
                {
                    results = current.Value.CompareTo(item);
                    if (results > 0)
                    {
                        parent = current;
                        current = current.Left;
                    }
                    else if (results < 0)
                    {
                        parent = current;
                        current = current.Right;
                    }
                    else if (results == 0)
                    {
                        Console.WriteLine("Your number has already been added");
                        parent = current;
                        return;
                    }
                }
            
                results = parent.Value.CompareTo(item);
                if (results < 0)
                {
                    parent.Right = AddedNode;
                }
                else
                {
                    parent.Left = AddedNode; 
                }
                
            }
           
        }
    }
}
