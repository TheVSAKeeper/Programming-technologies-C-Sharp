namespace BinaryTrees
{
    public class Node
    {
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Count = 1;
        }

        public int Value { get; }
        public int Count { get; set; }
    }
}