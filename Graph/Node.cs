namespace Graph;

public class Node<T>
{
    public T Data;
    private HashSet<Node<T>> _neighbours = new();
    public Node(T data)
    {
        Data = data;
    }
    public void AddEdge(Node<T> neighbour)
    {
        _neighbours.Add(neighbour);
    }
    public List<Node<T>> GetNeighbours() => _neighbours.ToList();
    public void PrintNeighbours()
    {
        this.GetNeighbours().ForEach(n =>
        {
            Console.Write(n.Data+" ");
        });
        Console.WriteLine();
    }

}
