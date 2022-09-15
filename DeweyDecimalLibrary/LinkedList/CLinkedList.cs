using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalLibrary.LinkedList
{
    public class CLinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        #region FIELDS
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Size { get; set; }
        #endregion
        public CLinkedList()
        {
            //Head and tail should already be null, and ints should default to 0, but whatever
            Head = null;
            Tail = null;
            Size = 0;
        }

        /// <summary>
        /// Returns true if the list is empty
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsEmpty()
        {
            return Size < 1;
        }

        /// <summary>
        /// Returns an item from a specified position in the collection
        /// </summary>
        /// <param name="index">The position of the Item</param>
        public T this[int index]
        {
            get
            {
                //if the index comes in is not in range of the list or the list is empty
                if (index < 0 || index > Size - 1 || Size == 0)
                {
                    throw new IndexOutOfRangeException();
                }//if
                else
                {

                    if (index == 0)
                    {
                        return Head.Data; //if index is 0, return head
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
                                Node<T> current = Head.Next;//We already checked the head, so we start with the next one

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
                                Node<T> current = Tail.Previous;//we already checked the tail, so start with the previous one

                                //start at the second last node
                                for (int i = Size - 2; i > index; i--)
                                {
                                    current = current.Previous;
                                }

                                return current.Data;
                            }
                        }
                    }//else

                }//else
            }//get
        }//this[]

        /// <summary>
        /// Add Data to the start of the list
        /// </summary>
        /// <param name="data">Data to be Added</param>
        public void Prepend(T data)
        {
            Node<T> n = new Node<T>(data);

            //If the collection is empty, set the head and tail to the incoming node
            if (Size == 0)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                n.Previous = null; //set previous to null - There's nothing before the head
                n.Next = Head; //set the next value of the new node to the current head
                Head.Previous = n; //set the previous of the head to the new node
                Head = n; //set the head to the new node
            }
            Size++;
        }//Prepend


        /// <summary>
        /// Add Data to the end of the list
        /// </summary>
        /// <param name="data">Data to be Added</param>
        public void Append(T data)
        {
            Node<T> n = new Node<T>(data);

            //If the collection is empty, set the head and tail to the incoming node
            if (Size == 0)
            {
                Head = n;
                Tail = n;
            }
            else
            {
                n.Next = null; //set next to null - There's nothing after the tail
                n.Previous = Tail; //set the previous value of the new node to the current tail
                Tail.Next = n; //set the next of the tail to the new node
                Tail = n; //set the tail to the new node
            }
            Size++;
        }//Append

        /// <summary>
        /// Removes the Data stored at a specified Index
        /// </summary>
        /// <param name="index">The position of the node to be removed</param>
        public void Remove(int index)
        {
            //if the index comes in is not in range of the list or the list is empty
            if (index < 0 || index > Size - 1 || Size == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                //if the node to be removed is the head
                if (index == 0)
                {
                    Head = Head.Next; //set the head to the next node
                    Head.Previous = null; //heads do not have a previous node
                    Size--;
                    return;
                }

                //if the node to be removed is the tail
                if (index == Size - 1)
                {
                    Tail = Tail.Previous; //set the tail to the previous node
                    Tail.Next = null; //tails do not have a previous node
                    Size--;
                    return;
                }
                else
                {
                    Node<T> current = Head.Next;//we already checked the head, so we check the next one
                    Node<T> previous = Head;//since current is the node after head, previous becomes the head

                    //loop through each node, updating the current and previous values until they are set to the correct nodes
                    //i is set to one because we already checked the first Node
                    for (int i = 1; i < index; i++)
                    {
                        //updates the previous and current nodes for the next iteration of the loop
                        previous = current;
                        current = current.Next;
                    }

                    //sets the next node of the previous to the next node of the current
                    previous.Next = current.Next;

                    //sets the previous node of the next node to the previous node
                    current.Next.Previous = previous;

                    Size--;
                    return;

                }//else
            }//else
        }//Remove

        /// <summary>
        /// Writes the ToString of each node to the console
        /// </summary>
        /// <param name="n">The Node to start with</param>
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
        //Sorting methods adapted from https://www.geeksforgeeks.org/quicksort-for-linked-list/
        //Quicksort used

        // A utility function to find the last node of linked list
        private Node<T> LastNode(Node<T> node)
        {
            while (node.Next != null)
                node = node.Next;
            return node;
        }

        /* Considers last element as pivot,
        places the pivot element at its
        correct position in a sorted array,
        and places all smaller (smaller than
        pivot) to left of pivot and all
        greater elements to right of pivot */
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
                //comparing generics - https://stackoverflow.com/questions/6480577/how-to-compare-values-of-generic-types
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
        /// <summary>
        /// Sorts the Linked List in ascending order
        /// </summary>
        /// <param name="node"></param>
        public void QuickSort(Node<T> node)
        {
            // Find last node
            Node<T> head = LastNode(node);

            // Call the recursive QuickSort
            RecursiveQuickSort(node, head);
        }

        #endregion

        #region ENUMERATOR
        //yoinked from https://gist.github.com/daramasala/3c1052f189c14759597cf4667670af72
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
            //Enumerator basically starts off by saying current.next, so toss in a "starter" node
            //With the next set to the Head. Sketchy fix, but it works, size and max are set to hopefully beat the circular link
            return new LinkedListEnumerator(new Node<T> { Next = Head });
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

    }
}
