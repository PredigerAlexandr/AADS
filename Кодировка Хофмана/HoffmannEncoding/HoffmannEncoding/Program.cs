using System.Collections;
using System.Text;

var str = Console.ReadLine();
var charScores = new Dictionary<char, long>();
foreach (var symbol in str)
{
    if (charScores.ContainsKey(symbol))
    {
        charScores[symbol]++;
    }
    else
    {
        charScores.Add(symbol, 1);
    }
}

var nodes = charScores.OrderByDescending(x => x.Value)
    .Select(x => new LeafNode(x.Value, x.Key)).ToList();
var queue = new Stack<Node>(nodes);
if (queue.Count == 1)
{
    var hoffmanTree = queue.Pop();
    hoffmanTree.GenerateCode("0");
}
else
{
    while (queue.Count != 1)
    {
        var first = queue.Pop();
        var second = queue.Pop();
        var node = new InternalNode(first, second);
        queue.Push(node);
    }

    var hoffmanTree = queue.Pop();
    hoffmanTree.GenerateCode("");
}


var result = new StringBuilder();

foreach (var symbol in str)
{
    result.Append(Node.symbolCodes[symbol]);
}

Console.WriteLine(Node.symbolCodes.Count() + " " + result.Length);

foreach (var element in Node.symbolCodes)
{
    Console.WriteLine(element.Key + ": " + element.Value);
}

Console.WriteLine(result);

public class Node
{
    private char symbol;
    public static Dictionary<char, string> symbolCodes = new Dictionary<char, string>();
    public long Weight;
    public string Code;

    public char Symbol
    {
        get { return symbol; }
        set
        {
            symbol = value;
            symbolCodes.Add(value, "-");
        }
    }

    public virtual void GenerateCode(string code)
    {
        Code = code;
    }
}

public class InternalNode : Node
{
    public Node Left;
    public Node Right;

    public InternalNode(Node left,
        Node right)
    {
        Left = left;
        Right = right;
        Weight = left.Weight + right.Weight;
    }

    public override void GenerateCode(string code)
    {
        base.GenerateCode(code);
        Left.GenerateCode(code + "0");
        Right.GenerateCode(code + "1");
    }
}

public class LeafNode : Node
{
    public LeafNode(long weight, char symbol)
    {
        Weight = weight;
        Symbol = symbol;
    }

    public override void GenerateCode(string code)
    {
        base.GenerateCode(code);
        symbolCodes[Symbol] = code;
    }
}