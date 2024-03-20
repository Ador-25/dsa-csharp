using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph;

public class Graph<T>
{
    List<Edge<T>>Edges = new();
    HashSet<Node<T>> visited = new();

    public void AddEdge(Node<T> source, Node<T> destination, double value =0)
    {
        source.AddEdge(destination);
        destination.AddEdge(source);
        Edges.Add(new Edge<T>(source, destination,value));
    }
    public void DFS(Node<T> node)
    {
        StringBuilder sb = new StringBuilder();
        Node<T> currentNode = node;
        Stack<Node<T>> neighbours = new();
        neighbours.Push(currentNode);
        HashSet<Node<T>> visitedNodes =  new ();
        while (neighbours.Count > 0)
        {

            currentNode = neighbours.Pop();
            if (visitedNodes.Contains(currentNode))
                continue;
            sb.Append(currentNode.Data+" ");
            visitedNodes.Add(currentNode);
            foreach(var neighbour in currentNode.GetNeighbours())
            {
                neighbours.Push(neighbour);
            }
        }
        Console.WriteLine(sb.ToString());
    }
    public void BFS(Node<T> node)
    {
        StringBuilder sb = new StringBuilder();
        Node<T> currentNode = node;
        Queue<Node<T>> neighbours = new();
        neighbours.Enqueue(currentNode);
        HashSet<Node<T>> visitedNodes = new();
        while (neighbours.Count > 0)
        {
            currentNode = neighbours.Dequeue();
            if (visitedNodes.Contains(currentNode))
                continue;
            sb.Append(currentNode.Data+" ");    
            visitedNodes.Add(currentNode);
            foreach(var neighbour in currentNode.GetNeighbours())
            {
                neighbours.Enqueue(neighbour);
            }
        }
        Console.WriteLine(sb.ToString());
    }

    private void startDFS(Node<T> node)
    {
        visited.Add(node);
        Console.Write(node.Data+" ");
        foreach(var neighbour in node.GetNeighbours())
        {
            if(!visited.Contains(neighbour))
                startDFS(neighbour);
        }
    }

    public void RecursiveDFS(Node<T> node)
    {
        startDFS(node);
        Console.WriteLine();
    }

}
