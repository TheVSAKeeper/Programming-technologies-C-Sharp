using System;
using System.Collections.Generic;

namespace BinaryTrees.Search
{
    public static class SearchMethods
    {
        private static readonly Dictionary<SearchType, string> OptionsDescription = new Dictionary<SearchType, string>
        {
            { SearchType.InOrder, "Симметричный метод LNR" },
            { SearchType.PostOrder, "Обратный метод LRN" },
            { SearchType.ReverseInOrder, "Справа налево RNL" },
            { SearchType.PreOrder, "Прямой метод NLR" },
            { SearchType.BreadthFirst, "Обход в ширину BFS" },
            { SearchType.BreadthFirstLineByLine, "Все слои дерева, начиная с корня" },
            { SearchType.DepthFirst, "Обход в глубину DFT" },
            { SearchType.DepthFirstLineByLine, "Все слои дерева, начиная с вершины" }
        };

        private static Func<Node, string> _getNodeValue;

        public static string GetDescription(SearchType searchType)
        {
            if (OptionsDescription.TryGetValue(searchType, out string description))
                return description;

            throw new ArgumentOutOfRangeException(nameof(searchType), searchType, null);
        }

        public static string GetResult(SearchType searchType, Node root, Func<Node, string> getNodeValue)
        {
            _getNodeValue = getNodeValue;

            switch (searchType)
            {
                case SearchType.InOrder:
                    return GetInOrder(root);

                case SearchType.PostOrder:
                    return GetPostOrder(root);

                case SearchType.ReverseInOrder:
                    return GetReverseInOrder(root);

                case SearchType.PreOrder:
                    return GetPreOrder(root);

                case SearchType.BreadthFirst:
                    return GetBreadthFirst(root);

                case SearchType.DepthFirst:
                    return GetDepthFirst(root);

                case SearchType.DepthFirstLineByLine:
                    return GetDepthFirstLineByLine(root);

                case SearchType.BreadthFirstLineByLine:
                    return GetBreadthFirstLineByLine(root);

                default:
                    throw new ArgumentOutOfRangeException(nameof(searchType), searchType, null);
            }
        }

        private static string GetInOrder(Node node)
        {
            if (node == null)
                return string.Empty;

            string left = GetInOrder(node.Left);
            string value = _getNodeValue(node) + " ";
            string right = GetInOrder(node.Right);

            return left + value + right;
        }

        private static string GetPostOrder(Node node)
        {
            if (node == null)
                return string.Empty;

            string left = GetPostOrder(node.Left);
            string right = GetPostOrder(node.Right);
            string value = _getNodeValue(node) + " ";

            return left + right + value;
        }

        private static string GetReverseInOrder(Node node)
        {
            if (node == null)
                return string.Empty;

            string right = GetReverseInOrder(node.Right);
            string value = _getNodeValue(node) + " ";
            string left = GetReverseInOrder(node.Left);

            return right + value + left;
        }

        private static string GetPreOrder(Node node)
        {
            if (node == null)
                return string.Empty;

            string value = _getNodeValue(node) + " ";
            string left = GetPreOrder(node.Left);
            string right = GetPreOrder(node.Right);

            return value + left + right;
        }

        private static string GetBreadthFirst(Node root)
        {
            if (root == null)
                return string.Empty;

            string result = string.Empty;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);

                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);

                result += _getNodeValue(currentNode) + " ";
            }

            return result;
        }

        private static string GetBreadthFirstLineByLine(Node root)
        {
            if (root == null)
                return string.Empty;

            List<string> result = GetTreeLevels(root);

            return Environment.NewLine + string.Join(Environment.NewLine, result);
        }

        private static List<string> GetTreeLevels(Node root)
        {
            List<string> result = new List<string>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int levelSize = queue.Count;
                string levelDescription = string.Empty;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);

                    levelDescription += _getNodeValue(currentNode) + " ";
                }

                result.Add(levelDescription);
            }

            return result;
        }

        private static string GetDepthFirst(Node root)
        {
            if (root == null)
                return string.Empty;

            string result = string.Empty;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                Node currentNode = stack.Pop();

                if (currentNode.Right != null)
                    stack.Push(currentNode.Right);

                if (currentNode.Left != null)
                    stack.Push(currentNode.Left);

                result += _getNodeValue(currentNode) + " ";
            }

            return result;
        }

        private static string GetDepthFirstLineByLine(Node root)
        {
            List<string> result = new List<string>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int levelSize = queue.Count;
                string levelDescription = string.Empty;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);

                    levelDescription = _getNodeValue(currentNode) + " " + levelDescription;
                }

                result.Add(levelDescription);
            }

            result.Reverse();
            return Environment.NewLine + string.Join(Environment.NewLine, result);
        }
    }
}