using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public interface ITree<T>
{
    public void AddRoot(TreeNode<T> node);
    public void PrintBFS();
    public void PrintDFS();
}
