using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        //MEMBER VARIABLES (NODES HAVE A..)
        public int num;
        public Node leftChild;
        public Node rightChild;

        //CONSTRUCTOR (EVERY NODE..)
        public Node(int num)
        {
            this.num = num;
        }
    }
}
