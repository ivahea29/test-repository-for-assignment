using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
    public class DLLNode
    {
        public int num; // data stored in the node
        public DLLNode next; // pointer to the next node
        public DLLNode previous; // pointer to the previous node

        public DLLNode(int num)
        {
            this.num = num;
            this.next = null;
            this.previous = null;
        }
    }

    public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list

        public DLList()
        {
            head = null;
            tail = null;
        }

        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your task is to write
        * unit tests to discover these errors. During delivery, the tutor may
        * add or remove errors to adjust the scale of the effort required.
        */
        public void addToTail(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                p.previous = tail;
                tail = p;
            }
        }

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head.previous = p;
                head = p;
            }
        }

        public void removeHead()
        {
            if (head == null)
                return;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.previous = null;
            }
        }

        public void removeTail()
        {
            if (tail == null)
                return;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.previous;
                tail.next = null;
            }
        }

        /*-------------------------------------------------
         * Return null if the node with the given number does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            DLLNode p = head;
            while (p != null)
            {
                if (p.num == num)
                    return p;

                p = p.next;
            }
            return null;
        }

        public void removeNode(DLLNode p)
        {
            if (p == null)
                return;

            if (p == head)
                removeHead();
            else if (p == tail)
                removeTail();
            else
            {
                p.previous.next = p.next;
                p.next.previous = p.previous;
                p.next = null;
                p.previous = null;
            }
        }

        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next;
            }
            return tot;
        }
    }
}
