using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _io = FastIO.Output;

namespace Tree;

public class TreeNode<T>
{
    public T Data { get; set; }
    private List<TreeNode<T>> _children = new();

    public TreeNode()
    {
       
    }
    public TreeNode(T data)
    {
        Data = data;
    }
    public TreeNode(T data,List<TreeNode<T>> children)
    {
        Data = data;
        _children = children;
    }
    public void AddChild(TreeNode<T>child)
    {
        this._children.Add(child);
    }
    public void RemoveChild(TreeNode<T> child)
    {
        this._children.Remove(child);
    }
    public void PrintChildren()
    {
        _io.Debug(this._children);
    }
    public List<TreeNode<T>> GetChildrenNodes() => this._children;
    public bool HasChildren() => this._children.Count > 0;
}
