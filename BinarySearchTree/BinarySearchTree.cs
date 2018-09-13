using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        //Member Variables
        public Node root;
        
        //Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(int nodeEntries)
        {

        }

        //Methods
        public void AddChild(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if(root == null)
            {
                root = newNode;
            }
            else 
            {
                Node currentNode = root;
                while (true)
                {
                    if(data < currentNode.data)
                    {                       
                        if(currentNode.leftChild == null)
                        {
                            currentNode.leftChild = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.leftChild;
                        }
                    }
                    else
                    {
                        if (currentNode.rightChild == null)
                        {
                            currentNode.rightChild = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.rightChild;
                        }
                    }
                }
            }
        }

        public void SearchTheTree(int searchCriteria)
        {
            Node currentNode = root;

            if (currentNode == null)
            {
                Console.WriteLine("Node has not been found!");
                Console.ReadKey();
            }
            else if (currentNode.data == searchCriteria)
            {
                Console.WriteLine("Node has been found!");
                Console.ReadKey();
            }
            else if (currentNode.data < searchCriteria)
            {
                SearchTheTree(currentNode.rightChild, searchCriteria);
            }
            else
            {
                SearchTheTree(currentNode.leftChild, searchCriteria);
            }
        }
        public void SearchTheTree(Node currentNode, int searchCriteria)
        {
            if(currentNode == null)
            {
                Console.WriteLine("Node has not been found!");
                Console.ReadKey();
            }
            else if(currentNode.data == searchCriteria)
            {
                Console.WriteLine("Node has been found!");
                Console.ReadKey();
            }
            else if(currentNode.data < searchCriteria)
            {
                SearchTheTree(currentNode.rightChild, searchCriteria);
            }
            else 
            {
                SearchTheTree(currentNode.leftChild, searchCriteria);
            }
        }
    }
}
