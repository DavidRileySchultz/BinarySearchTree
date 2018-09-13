using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newTree = new BinarySearchTree();
            int nodeEntries;
            Console.WriteLine("Please enter how many nodes would you like to enter into your Binary Search Tree?");
            nodeEntries = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < nodeEntries; i++)
            {
                Console.WriteLine("Please enter your Node's criteria. Must be a whole positive number.");
                newTree.AddChild(Convert.ToInt32(Console.ReadLine()));
            }
            
            Console.WriteLine("Please enter the number you wish to search for. . .");
            int searchCriteria = Convert.ToInt32(Console.ReadLine());
            newTree.SearchTheTree(searchCriteria);
        }
    }
}
