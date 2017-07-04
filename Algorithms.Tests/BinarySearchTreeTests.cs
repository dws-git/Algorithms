using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Tests
{
    public class BinarySearchTreeTests : IDisposable
    {
        private readonly ITestOutputHelper output;
        public Node Tree { get; set; }

        public BinarySearchTreeTests(ITestOutputHelper output)
        {
            this.output = output;
            Tree = new Node(4);
            Tree.Add(new Node(2));
            Tree.Add(new Node(6));
            Tree.Add(new Node(1));
            Tree.Add(new Node(3));
            Tree.Add(new Node(5));
            Tree.Add(new Node(7));
        }

        [Fact]
        public void PreorderTraversal()
        {
            BinarySearchTree bst = new BinarySearchTree();            
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                bst.PreorderTraversal(Tree);
                string expected = String.Format("4{0}2{0}1{0}3{0}6{0}5{0}7{0}", Environment.NewLine);
                string actual = writer.ToString();
                Assert.Equal(expected, actual);
                output.WriteLine(actual);
            }
        }

        [Fact]
        public void InorderTraversal()
        {
            BinarySearchTree bst = new BinarySearchTree();
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                bst.InorderTraversal(Tree);
                string expected = String.Format("1{0}2{0}3{0}4{0}5{0}6{0}7{0}", Environment.NewLine);
                string actual = writer.ToString();
                Assert.Equal(expected, actual);
                output.WriteLine(actual);
            }
        }

        [Fact]
        public void PostorderTraversal()
        {
            BinarySearchTree bst = new BinarySearchTree();
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                bst.PostorderTraversal(Tree);
                string expected = String.Format("1{0}3{0}2{0}5{0}7{0}6{0}4{0}", Environment.NewLine);
                string actual = writer.ToString();
                Assert.Equal(expected, actual);
                output.WriteLine(actual);
            }
        }

        private void ResetStandardOutput()
        {
            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            };
            Console.SetOut(standardOut);
        }

        public void Dispose()
        {
            ResetStandardOutput();
            GC.SuppressFinalize(this);
        }

        ~BinarySearchTreeTests()
        {
            ResetStandardOutput();
        }
    }
}
