using System;

namespace LinkedList
{
    public class Node
    {
        public int val;
        public Node next;
        public Node()
        {
            val = -1;
            next = null;
        }

        public Node(int dt)
        {
            val = dt;
            next = null;
        }
    }
    public class MyLinkedList
    {

        Node node;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            this.node = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (node == null)
                return -1;
            Node temp = node;
            int i = 0;
            while (temp != null && i < index)
            {
                temp = temp.next;
                i++;
            }
            if (temp == null)
                return -1;
            return temp.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node head = new Node(val);
            head.next = node;
            node = head;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node current = node;
            Node previous = null;

            while (current != null)
            {
                previous = current;
                current = current.next;
            }

            if (previous == null)
            {
                node = new Node(val);
            }
            else
            {
                previous.next = new Node(val);
            }

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            Node temp = node;
            Node prev = null;
            int i = 0;

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            while (temp != null && i < index)
            {
                prev = temp;
                temp = temp.next;
                i++;
            }


            if (i == index)
            {
                var next = temp;
                prev.next = new Node(val);
                prev.next.next = next;
            }

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0)
                return;
            if (index == 0)
            {
                node = node.next;
                return;
            }

            Node tmp = node, pre = null;
            int i = 0;
            while (tmp != null && i < index)
            {
                pre = tmp;
                tmp = tmp.next;
                i++;
            }

            if (i == index)
                pre.next = tmp?.next;
        }

        internal void Print()
        {
            Node temp = node;

            while (temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }
    }

    /**
     * Your Node object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList obj = new MyLinkedList();
            obj.AddAtIndex(0, 10);
            obj.AddAtIndex(0, 20);
            obj.AddAtIndex(1, 30);
            obj.AddAtTail(25);
            obj.Get(0);


            obj.Print();
        }
    }
}
