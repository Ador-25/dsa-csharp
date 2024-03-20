using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList;

public class SinglyLinkedList<T>
{
    public Node<T> Head;
    public void AddFirst(T data)
    {
        Node<T> node = new Node<T>
        { 
            Data = data,
            Next = Head == null? null:Head 
        };
        this.Head = node;
    }
    public void RemoveFirst()
    {
        if(Head is null)
        {
            return;
        }
        Head = Head.Next;
    }
    public void AddLast(T data)
    {
        Node<T> iterator = Head;
        Node<T> temp = iterator;
        while (iterator.Next != null)
        {
            iterator = iterator.Next;
        }
        Node<T> newNode = new Node<T>
        {
            Data = data,
            Next = null
        };
        iterator.Next = newNode;
        this.Head = temp;
    }
    public void RemoveLast()
    {
        Node<T> iterator = this.Head;
        Node<T> temp = iterator;
        if(Head is null)
        {
            return;
        }
        if(Head.Next is null)
        {
            Head.Next = null;
        }
        while(iterator.Next.Next is not null)
        {
            iterator = iterator.Next;
        }
        iterator.Next = null;
        this.Head = temp;
    }
    public void PrintList()
    {
        StringBuilder sb = new StringBuilder();
        Node<T> iterator = Head;
        while (iterator != null)
        {
            sb.Append(iterator.Data+" ");
            iterator = iterator.Next;
        }
        Console.WriteLine(sb.ToString());
    }

}
