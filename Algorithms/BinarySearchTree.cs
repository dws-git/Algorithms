using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearchTree
    {
        
        /// <summary>
        /// First visit the root node (perform any logic, get values, etc.)
        /// then the left subtree, and then the right subtree, all recursively
        /// </summary>
        public void PreorderTraversal(Node current)
        {
            if (current == null)
            {
                return;
            }
            Process(current);
            PreorderTraversal(current.Left);
            PreorderTraversal(current.Right);
        }

        /// <summary>
        /// First visit the left subtree (perform any logic, get values, etc.)
        /// then the root node, and then the right subtree, all recursively
        /// </summary>
        public void InorderTraversal(Node current)
        {
            if (current == null)
            {
                return;
            }
            InorderTraversal(current.Left);
            Process(current);
            InorderTraversal(current.Right);
        }

        /// <summary>
        /// First visit the left subtree (preform any logic, get values, etc.)
        /// then the right subtree, and then the root node, all recursively
        /// </summary>
        public void PostorderTraversal(Node current)
        {
            if (current == null)
            {
                return;
            }
            PostorderTraversal(current.Left);
            PostorderTraversal(current.Right);
            Process(current);
        }

        private void Process(Node current)
        {
            //perform logic - check value, write to console, return node, etc.
            Console.WriteLine(current.Value);
            //return current.Value;
        }
    }
}
