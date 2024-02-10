using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BinaryTrees.Search;

namespace BinaryTrees
{
    internal abstract class BinaryTree
    {
        protected Node Root;

        public abstract void AddNodes(Queue<int> values);

        protected abstract string GetNodeValue(Node node);

        public string PerformBypass(SearchType option) => SearchMethods.GetResult(option, Root, GetNodeValue);

        public void FillTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            AddNodesToTreeView(Root, treeView.Nodes);
        }

        private void AddNodesToTreeView(Node node, TreeNodeCollection parentNodes)
        {
            if (node == null)
                return;

            TreeNode treeNode = new TreeNode($"{GetNodeValue(node)} ({node.Count})");
            parentNodes.Add(treeNode);

            AddNodesToTreeView(node.Left, treeNode.Nodes);
            AddNodesToTreeView(node.Right, treeNode.Nodes);
        }

        public string GetDescription()
        {
            string description = string.Empty;
            AddNodeDescription(Root, 0, ref description);
            return description;
        }

        public string SearchKey(int key, out int depth)
        {
            depth = 0;
            return Find(Root, ref depth, key);
        }

        private void AddNodeDescription(Node root, int depth, ref string description)
        {
            if (root == null)
                return;

            string padding = string.Concat(Enumerable.Repeat(" - ", depth));
            string line = $"|{depth}|{padding} {GetNodeValue(root)}{Environment.NewLine}";

            for (int i = 0; i < root.Count; i++)
                description += line;

            AddNodeDescription(root.Left, depth + 1, ref description);
            AddNodeDescription(root.Right, depth + 1, ref description);
        }

        private string Find(Node current, ref int depth, int searchKey)
        {
            if (current is null)
                return string.Empty;

            depth++;

            if (current.Value == searchKey)
                return $"{current.Value} ";

            return Find(searchKey < current.Value ? current.Left : current.Right, ref depth, searchKey);
        }
    }
}