using System.Collections;

namespace DeweyDecimalLibrary.LinkedList
{
    public class CLinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        #region Properties
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Size { get; set; }
        #endregion
        public CLinkedList()
        {
            // head and tail should already be null, and ints should default to 0, but whatever
            Head = null;
            Tail = null;
            Size = 0;
        }

        // returns true if the list is empty
        public bool IsEmpty()
        {
            return Size < 1;
        }

        // returns an item from a specified position in the collection
        public T this[int index]
        {
            get
            {
                //if the index comes in is not in range of the list or the list is empty
                if (index < 0 || index > Size - 1 || Size == 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {

                    if (index == 0)
                    {
                        //if index is 0, return head
                        return Head.Data;
                    }
                    else
                    {
                        //if the index is the tail
                        if (index == Size - 1)
                        {
                            return Tail.Data;
                        }
                        else
                        {
                            //find the middle of the list
                            int middle = Size / 2;

                            //if the index < middle, start at the top
                            if (index < middle)
                            {
                                //We already checked the head, so we start with the next one
                                Node<T> current = Head.Next;

                                //start at the second node
                                for (int i = 1; i < index; i++)
                                {
                                    //updates the current node for the next iteration of the loop
                                    current = current.Next;
                                }

                                return current.Data;
                            }
                            else
                            {
                                //we already checked the tail, so start with the previous one
                                Node<T> current = Tail.Previous;

                                //start at the second last node
                                for (int i = Size - 2; i > index; i--)
                                {
                                    current = current.Previous;
                                }

                                return current.Data;
                            }
                        }
                    }

                }
            }
        }

        // add Data to the start of the list
        public void Prepend(T data)
        {
            Node<T> n = new Node<T>(data);

            // if the collection is empty, set the head and tail to the incoming node
            if (Size == 0)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                //set previous to null - There's nothing before the head
                n.Previous = null;

                //set the next value of the new node to the current head
                n.Next = Head;

                //set the previous of the head to the new node
                Head.Previous = n;

                //set the head to the new node
                Head = n;
            }
            Size++;
        }

        // add Data to the end of the list
        public void Append(T data)
        {
            Node<T> n = new Node<T>(data);

            // if the collection is empty, set the head and tail to the incoming node
            if (Size == 0)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                //set next to null - There's nothing after the tail
                n.Next = null;

                //set the previous value of the new node to the current tail
                n.Previous = Tail;

                //set the next of the tail to the new node
                Tail.Next = n;

                //set the tail to the new node
                Tail = n;
            }
            Size++;
        }


        // writes the ToString of each node to the console
        public void Traverse(Node<T> n)
        {
            //if node is null, end
            if (n == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(n.Data.ToString());
                Traverse(n.Next);
            }
        }

        public List<T> ToList()
        {
            List<T> list = new List<T>();

            foreach (T item in this)
            {
                list.Add(item);
            }

            return list;
        }

        #region SORTING
        // quicksort used - utility function to find the last node of linked list
        private Node<T> LastNode(Node<T> node)
        {
            while (node.Next != null)
                node = node.Next;
            return node;
        }

        //  considers last element as pivot, places the pivot element at its correct position in a sorted array,
         // and places all smaller (smaller than pivot) to left of pivot and all greater elements to right of pivot 
        
        private Node<T> Partition(Node<T> last, Node<T> head)
        {
            // set pivot as h element
            T pivot = head.Data;

            // similar to i = l-1 for array implementation
            Node<T> i = last.Previous;
            T temp;

            // Similar to "for (int j = l; j <= h- 1; j++)"
            for (Node<T> j = last; j != head; j = j.Next)
            {
                //< 0 = less than, == 0 = equal, > 0 == greater than
                //comparing generics 
                if (j.Data.CompareTo(pivot) <= 0)
                {
                    // Similar to i++ for array
                    i = i == null ? last : i.Next;
                    temp = i.Data;
                    i.Data = j.Data;
                    j.Data = temp;
                }
            }
            i = i == null ? last : i.Next; // Similar to i++
            temp = i.Data;
            i.Data = head.Data;
            head.Data = temp;
            return i;
        }

        /* A recursive implementation of
        quicksort for linked list */
        private void RecursiveQuickSort(Node<T> last, Node<T> head)
        {
            if (head != null && last != head && last != head.Next)
            {
                Node<T> temp = Partition(last, head);
                RecursiveQuickSort(last, temp.Previous);
                RecursiveQuickSort(temp.Next, head);
            }
        }

        // The main function to sort a linked list.
        // It mainly calls _quickSort()
        public void QuickSort(Node<T> node)
        {
            // Find last node
            Node<T> head = LastNode(node);

            // Call the recursive QuickSort
            RecursiveQuickSort(node, head);
        }

        #endregion

        #region ENUMERATOR
        // code pulled from
        // Author : daramasala :
        // Topic: EnumerableLinkedList.cs :
        // Link : https://gist.github.com/daramasala/3c1052f189c14759597cf4667670af72
        public class LinkedListEnumerator : IEnumerator<T>
        {
            private Node<T> current;

            public LinkedListEnumerator(Node<T> current)
            {
                this.current = current;
            }

            public T Current => current.Data;

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (current == null)
                {
                    return false;
                }
                else
                {
                    if (current.Next == null)
                    {
                        return false;
                    }
                    current = current.Next;
                    return true;
                }
            }

            public void Dispose()
            {

            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            // enumerator basically starts off by saying current.next, so toss in a "starter" node
            // with the next set to the Head. Sketchy fix, but it works, size and max are set to hopefully beat the circular link
            return new LinkedListEnumerator(new Node<T> { Next = Head });
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

    }
}

/*
 Code Attribution
 Author : geeksforgeeks
 Topic : QuickSort on Doubly Linked List
 Link : https://www.geeksforgeeks.org/quicksort-for-linked-list/

 Author : faester
 Topic : How to compare values of generic types?
 Link :https://stackoverflow.com/questions/6480577/how-to-compare-values-of-generic-types
 */