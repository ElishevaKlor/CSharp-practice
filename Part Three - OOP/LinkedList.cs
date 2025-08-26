using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Part_Three___OOP
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Node Max { get; set; }
        public Node Min { get; set; }
        public void Prepend(int number)
        {
            Node tmp = new Node{ Value = number ,Next= Head };
            Head = tmp;
            if (Tail == null)
                Tail = Head;
            if (Max==null||number > Max.Value)
                Max = Head;
            if (Min==null||number < Min.Value)
                Min = Head;
        }
        public int Pop()
        {
            if(Head==null)
                throw new InvalidOperationException("Cannot pop from empty list.");
            if (Head.Next == null)
            {
                int val = Head.Value;
                ClearList();
                return val;
            }
            Node current = Head;
            while (current.Next.Next!=null)
            {
                current = current.Next;
            }
            int num = current.Next.Value;
            current.Next = null;
            Tail = current;
            if (num == Max?.Value)
                UpdateMax();
            else if (num == Min?.Value)
                UpdateMin();

            return num;
        }
        public override string ToString()
        {
            if (Head == null)
                return "no list";

            Node current = Head;
            StringBuilder content = new();
            HashSet<Node> visited = new(); 

            while (current != null && !visited.Contains(current))
            {
                visited.Add(current);
                content.Append(current.Value + "->");
                current = current.Next;
            }
            if (content.Length >= 2)
                content.Length -= 2;
            if (current == Head)
                content.Append("(back to head)");
            else if (current != null)
                content.Append("(cycle)");
            return content.ToString();
        }

        public void Append(int number)
        {
            Node tmp = new Node { Value = number };
            if (Max == null || number > Max.Value)
                Max = tmp;
            if (Min == null || number < Min.Value)
                Min = tmp;
            if (Head == null)
            {
                Head = tmp;
                Tail = tmp;
            }
            else
            {
                Tail.Next = tmp;
                Tail = tmp;
            }
                
        }
        public int Unqueue()
        {
            if (Head == null)
                throw new InvalidOperationException("Cannot unqueue from empty list.");
            int num = Head.Value;
            Head = Head.Next;
            if (Head == null)
            {
                ClearList();
                return num;
            }
            if (num == Max?.Value)
                UpdateMax();
            else if (num == Min?.Value)
                UpdateMin();
            return num;
        }

        public IEnumerable<int> ToList()
        {
            Node current = Head;

            if (current == null)
                yield break; 

            do
            {
                yield return current.Value;
                current = current.Next;
            }
            while (current != null && current != Head);
        }


        public bool IsCircular()
        {
            Node tmp = Head;
            while (tmp != null && tmp.Next != Head)
            {
                tmp = tmp.Next;
            }
            if (tmp == null)
                return false;
            return true;
        }
        //public bool IsCircular()
        //{
        //    Node slow = Head, fast = Head;
        //    while (fast != null && fast.Next != null)
        //    {
        //        slow = slow.Next;
        //        fast = fast.Next.Next;
        //        if (slow == fast)
        //            return true;
        //    }
        //    return false;
        //}
        public void Sort()
        {
            bool iscircle = IsCircular();
            List<int> tmp=ToList().ToList();
            tmp.Sort();
            ClearList();
            foreach (int item in tmp)
            {
                Append(item);
            }
            if (iscircle&&Tail!=null)
                Tail.Next = Head;
        }
        public Node GetMaxNode()
        {
            //return new Node { Value=Max.Value };
            return Max;
        }
        public Node GetMinNode()
        {
            //return new Node { Value = Min.Value };
            return Min;
        }
        private Node FindNodeByComparison(Func<int, int, bool> compare)
        {
            Node result = null;
            Node tmp = Head;
            HashSet<Node> visited = new();

            while (tmp != null && !visited.Contains(tmp))
            {
                visited.Add(tmp);

                if (result == null || compare(tmp.Value, result.Value))
                {
                    result = tmp;
                }

                tmp = tmp.Next;
            }
            return result;
        }

        private void UpdateMax()
        {
            Max = FindNodeByComparison((a, b) => a > b);
        }

        private void UpdateMin()
        {
            Min = FindNodeByComparison((a, b) => a < b);
        }
        private void ClearList()
        {
            Head = Tail = Max = Min = null;
        }
    }
}
