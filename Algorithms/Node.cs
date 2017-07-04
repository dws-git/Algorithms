using System;

namespace Algorithms
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public Node Right { get; set; }
        public Node Left { get; set; }
        public int Value { get; set; }

        public void Add(Node node)
        {          
            if (node.Value < this.Value)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(node);
                }
            }
        }

        public Node Find(Node curentNode, int value)
        {
            throw new NotImplementedException();
        }

        public void Remove(Node node)
        {
            throw new NotImplementedException();
        }
    }
}