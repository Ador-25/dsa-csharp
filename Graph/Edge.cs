using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph;

public class Edge<T>
{
    public Node<T> Source;
    public Node<T> Destination;
    public double value = 0.0;
    public Edge(Node<T> source, Node<T> destination)
    {
        Source = source;
        Destination = destination;
    }
    public Edge(Node<T> source, Node<T> destination,double value)
    {
        Source = source;
        Destination = destination;
        this.value = value;
    }
}
