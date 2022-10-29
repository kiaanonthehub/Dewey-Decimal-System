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

        public void LevelOrderTraversal(TreeNode<T> Start)
        {
            Queue<TreeNode<T>> Q = new Queue<TreeNode<T>>();

            Q.Enqueue(Start);

            while (Q.Count != 0)
            {
                TreeNode<T> current = Q.Dequeue();

                Console.WriteLine($"NODE - {current.Data}");

                foreach (TreeNode<T> child in current.Children)
                {
                    Q.Enqueue(child);
                }
            }
        }

        // returns a List of T arranged by level
        public List<T> LevelOrderTraversalList(TreeNode<T> Start)
        {
            List<T> response = new List<T>();
            Queue<TreeNode<T>> Q = new Queue<TreeNode<T>>();

            Q.Enqueue(Start);

            while (Q.Count != 0)
            {
                TreeNode<T> current = Q.Dequeue();

                response.Add(current.Data);

                foreach (TreeNode<T> child in current.Children)
                {
                    Q.Enqueue(child);
                }
            }

            return response;
        }

        public TreeNode<T> Search(T Data)
        {
            Queue<TreeNode<T>> Q = new Queue<TreeNode<T>>();
            Q.Enqueue(this.Root);

            while (Q.Count != 0)
            {
                TreeNode<T> current = Q.Dequeue();

                if (current.Data.Equals(Data))
                {
                    return current;
                }

                foreach (TreeNode<T> child in current.Children)
                {
                    Q.Enqueue(child);
                }
            }
            return null;
        }

        public void AddChild(T Data, T ParentData)
        {
            TreeNode<T> Parent = Search(ParentData);

            if (Parent == null)
            {
                return;
            }
            else
            {
                Parent.AddChild(Data);
            }
        }

        public void AddChildren(List<T> Children, T ParentData)
        {
            TreeNode<T> Parent = Search(ParentData);

            if (Parent == null)
            {
                return;
            }
            else
            {
                foreach (T item in Children)
                {
                    Parent.AddChild(item);
                    Size++;
                }
            }
        }
        // gets a path to a random node at a specified level
        public List<T> GetPathToRandom(TreeNode<T> Start, int limit)
        {
            List<T> path = new List<T>();
            return PathToRandomRecursive(Start, 0, path, limit);
        }

        private List<T> PathToRandomRecursive(TreeNode<T> Start, int count, List<T> path, int limit)
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

                return PathToRandomRecursive(current, count, path, limit);
            }
        }


        // picks a Random value from a specified level
        public T PickRandom(int level)
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
            TreeNode<T> p = Search(Parent);

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
