namespace DeweyDecimalLibrary.Tree_Structure
{
    public class Tree<T> where T : IComparable<T>
    {
        // class properties
        public TreeNode<T> Root { get; set; }
        public int Size { get; set; }

        // constructor
        public Tree() { }

        // overloaded constructor
        public Tree(T Data)
        {
            Root = new TreeNode<T>(Data);
            Size++;
        }

        /*
         *  Inorder traversal gives nodes in non-decreasing order. 
         *  To get nodes of BST in non-increasing order, a variation of Inorder traversal where Inorder traversal is reversed can be used. 
         *  https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
         */
        public void OrderTraversal(TreeNode<T> Start)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

            queue.Enqueue(Start);

            while (queue.Count != 0)
            {
                TreeNode<T> current = queue.Dequeue();


                foreach (TreeNode<T> child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        /*
         *Given a Binary tree and a node. 
         *This method is used to search and check if the given node exists in the binary tree or not.
         *https://www.geeksforgeeks.org/search-a-node-in-binary-tree/
         */
        public TreeNode<T> SearchThrough(T Data)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.Root);

            while (queue.Count != 0)
            {
                TreeNode<T> current = queue.Dequeue();

                if (current.Data.Equals(Data))
                {
                    return current;
                }

                foreach (TreeNode<T> child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return null;
        }

        /*
         * This method used to add a list of children to the binary tree stucture
         */
        public void AddChildren(List<T> lstChildren, T ParentData)
        {
            TreeNode<T> Parent = SearchThrough(ParentData);

            if (Parent == null)
            {
                return;
            }
            else
            {
                foreach (T item in lstChildren)
                {
                    Parent.AddChild(item);
                    Size++;
                }
            }
        }
        /*
         * gets a lstPath to a random node at a specified level
         */
        public List<T> GetPathToRandom(TreeNode<T> Start, int limit)
        {
            List<T> lstPath = new List<T>();
            return PathToRandom(Start, 0, lstPath, limit);
        }

        /*
         * Gets the path to the randomly generated answer for level 3 ,2 and 1 
         * This is used to check if the users answer is correct for each stage of the game 
         * https://www.geeksforgeeks.org/print-path-between-any-two-nodes-in-a-binary-tree/
         */
        private List<T> PathToRandom(TreeNode<T> Start, int count, List<T> path, int limit)
        {
            if (Start.Children.Count < 1)
            {
                return path;
            }
            if (count >= limit)
            {
                return path;
            }
            else
            {
                TreeNode<T> current = Start;

                Random r = new Random();

                int index = r.Next(current.Children.Count);

                path.Add(current.Children[index].Data);

                current = current.Children[index];

                count++;

                return PathToRandom(current, count, path, limit);
            }
        }


        /* 
         * picks a Random value from a specified level
         * similar source code : Select a Random Node from a tree with equal probability
         * https://www.geeksforgeeks.org/select-random-node-tree-equal-probability/
         */
        public T GetRandom(int level)
        {
            TreeNode<T> current = Root;

            for (int i = 0; i < level; i++)
            {
                Random r = new Random();

                int index = r.Next(current.Children.Count);

                current = current.Children[index];
            }
            return current.Data;
        }

        /* 
         * gets the children of a specified parent
         * https://stackoverflow.com/questions/43774655/how-can-i-get-the-parent-in-binary-tree
         */
        public List<T> GetChildren(T Parent)
        {
            TreeNode<T> p = SearchThrough(Parent);

            if (p != null)
            {
                List<T> response = new List<T>();

                p.Children.ForEach(x => response.Add(x.Data));

                return response;
            }
            else
            {
                return null;
            }
        }
    }
}
