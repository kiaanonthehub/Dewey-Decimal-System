using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.Tree_Structure
{
    public class TreeNode<T>
    {
        // property
        public T Data { get; set; }

        // list
        public List<TreeNode<T>> Children { get; set; }

        // constructor
        public TreeNode() { }

        // overloade constructor
        public TreeNode(T data)
        {
            Data = data;
            Children = new List<TreeNode<T>>();
        }

        // method to add data to the list
        public void AddChild(T Data)
        {
            this.Children.Add(new TreeNode<T>(Data));
        }
    }
}
