using System.Collections.Generic;

namespace BinaryTrees
{
    internal class SelfBalancingBinarySearchTree : BinaryTree
    {
        protected override string GetNodeValue(Node node) => ((char)node.Value).ToString();

        private void AddNodes(ref Node node, Queue<int> values, int nodesCount)
        {
            if (nodesCount == 0)
                return;

            node = new Node(values.Dequeue());

            int leftNodesCount = nodesCount / 2;
            int rightNodesCount = nodesCount - leftNodesCount - 1;

            AddNodes(ref node.Left, values, leftNodesCount);
            AddNodes(ref node.Right, values, rightNodesCount);
        }

        public override void AddNodes(Queue<int> values)
        {
            AddNodes(ref Root, values, values.Count);
        }
    }
}