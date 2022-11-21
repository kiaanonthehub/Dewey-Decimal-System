namespace DeweyDecimalLibrary.Tree_Structure
{
    public class Tree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; set; }
        public int Size { get; set; }

        public Tree() { }

        public Tree(T Data)
        {
            Root = new TreeNode<T>(Data);
            Size++;
        }

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
        // gets a lstPath to a random node at a specified level
        public List<T> GetPathToRandom(TreeNode<T> Start, int limit)
        {
            List<T> lstPath = new List<T>();
            return PathToRandom(Start, 0, lstPath, limit);
        }

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


        // picks a Random value from a specified level
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

        // gets the children of a specified parent
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
