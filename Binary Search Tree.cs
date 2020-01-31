using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Binary_Search_Tree
    {
        //MEMBER VARIABLES (BST HAS A..)
        public Node root;

        //MEMBER METHODS (BST CAN DO..)

        public void Add(int num)
        {
            Node current; 
            
            if(root == null)
            {
                root = new Node(num);
            }
            else
            {
                current = root;

                while (true)
                {

                    if (num >= current.num)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = new Node(num);
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                        }

                    }
                    else
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = new Node(num);
                            break;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                }
            }
           
        }
        public bool Search(int num)
        {
            if(root == null)
            {
                return false;
            }
            Node current = root;

            while (true)
            {
                if (num == current.num)
                {
                    return true;
                }
                else if (num >= current.num)
                {
                    if (current.rightChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                else
                {
                    if (current.leftChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.leftChild;
                    }
                }
            }
        }
    }
}
