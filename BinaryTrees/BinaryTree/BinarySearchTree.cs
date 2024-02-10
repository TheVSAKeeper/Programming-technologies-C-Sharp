using System.Collections.Generic;

namespace BinaryTrees
{
    internal class BinarySearchTree : BinaryTree
    {
        public override void AddNodes(Queue<int> values)
        {
            foreach (int value in values)
                AddOrUpdateNode(ref Root, value);
        }

        protected override string GetNodeValue(Node node) => node.Value.ToString();

        private void AddOrUpdateNode(ref Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
                return;
            }

            if (node.Value == value)
            {
                node.Count++;
                return;
            }

            if (node.Value > value)
                AddOrUpdateNode(ref node.Left, value);
            else
                AddOrUpdateNode(ref node.Right, value);
        }
    }
}