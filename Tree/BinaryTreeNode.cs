using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public class BinaryTreeNode<T>
{
    public T Data { get; set; }
    public BinaryTreeNode<T> Left = null;
    public BinaryTreeNode<T> Right = null;
    public BinaryTreeNode(T data)
    {
        Data = data;
    }
    public BinaryTreeNode(T data,T left, T right)
    {
        Data = data;
        Left = new(left);
        Right = new(right);
    }
}
