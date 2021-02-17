using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invert_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let us create binary tree 
            // shown in above diagram 
            Node root = newNode(7);
            root.left = newNode(6);
            root.right = newNode(5);
            root.left.left = newNode(4);
            root.left.right = newNode(3);
            root.right.left = newNode(2);
            root.right.right = newNode(1);

            /*      7 
                   / \ 
                 6     5 
                / \   / \ 
                4 3   2 1         */

            int data = 4;

            // Reverse Tree Path 
            reverseTreePath(root, data);

            // Traverse inorder 
            inorder(root);
            Console.Read();
        }

        // A Binary Tree Node 
        public class Node
        {
            public int data;
            public Node left, right;
        }

        //class for int values 
        public class INT
        {
            public int data;
        }

        // 'data' is input. We need to reverse 
        // path from root to data. 
        // 'level' is current level. 
        // 'temp' that stores path nodes. 
        // 'nextpos' used to pick next item for reversing. 
        public static Node reverseTreePathUtil(Node root, int data,
                                               IDictionary<int, int> temp,
                                               int level, INT nextpos)
        {
            // return null if root null 
            if (root == null)
            {
                return null;
            }

            // Final condition 
            // if the node is found then 
            if (data == root.data)
            {

                // store the value in it's level 
                temp[level] = root.data;

                // change the root value with the 
                // current next element of the map 
                root.data = temp[nextpos.data];

                // increment in k for the next element 
                nextpos.data++;
                return root;
            }

            // store the data in perticular level 
            temp[level] = root.data;

            // We go to right only when left does not 
            // contain given data. This way we make sure 
            // that correct path node is stored in temp[] 
            Node left, right = null;
            left = reverseTreePathUtil(root.left, data, temp,
                                       level + 1, nextpos);
            if (left == null)
            {
                right = reverseTreePathUtil(root.right, data, temp,
                                            level + 1, nextpos);
            }

            // If current node is part of the path, 
            // then do reversing. 
            if (left != null || right != null)
            {
                root.data = temp[nextpos.data];
                nextpos.data++;
                return (left != null ? left : right);
            }

            // return null if not element found 
            return null;
        }

        // Reverse Tree path 
        public static void reverseTreePath(Node root,
                                           int data)
        {
            // store per level data 
            IDictionary<int,
                        int> temp = new Dictionary<int,
                                                   int>();

            // it is for replacing the data 
            INT nextpos = new INT();
            nextpos.data = 0;

            // reverse tree path 
            reverseTreePathUtil(root, data,
                                temp, 0, nextpos);
        }

        // INORDER 
        public static void inorder(Node root)
        {
            if (root != null)
            {
                inorder(root.left);
                Console.Write(root.data + " ");
                inorder(root.right);
            }
        }

        // Utility function to create 
        // a new tree node 
        public static Node newNode(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.left = temp.right = null;
            return temp;
        }

    }
}
