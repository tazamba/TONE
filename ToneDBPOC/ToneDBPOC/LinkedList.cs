using System;

namespace ToneLab1
{

    public class LinkedList
    {
        private Node start;
        private Node end;
        private int count;

        public LinkedList()
        {
            start = null;
            end = null;
            count = 0;
        }

        //add
        public void add(int item)
        {
            Node newNode = new Node(item);
            if (start == null && end == null)
            {
                start = newNode;
                end = newNode;
                count++;
            }
            else
            {
                end.setNext(newNode);
                newNode.setPrev(end);
                end = newNode;
                count++;
            }

        }
        //remove
        public void remove()
        {
            if (end == null)
            {
                Console.WriteLine("Cannot remove from empty linked list.");
            }
            else
            {
                end = (Node)end.getPrev();
                end.setNext(null);
                count--;
            }
        }

        
        //sort
        //i used a slection sort algorithm for this linked list
        public void sort()
        {
            Node currPtr = start;
            Node incPtr = (Node)currPtr.getNext();


            int temp = 0;

            while (currPtr.getNext() != null)
            {
                Node minPtr = null;
                Node tempPtr = currPtr;
                while (tempPtr != null)
                {
                    int min = currPtr.item;
                    if (tempPtr.item < min)
                    {
                        min = tempPtr.item;
                        minPtr = tempPtr;
                    }
                    tempPtr = (Node)tempPtr.getNext();
                }

                temp = currPtr.item;
                currPtr.item = minPtr.item;
                currPtr = (Node)currPtr.getNext();
            }
        }
        //first
        public Object getFirst()
        {
            return start.item;
        }
        //last
        public Object getLast()
        {
            return end.item;
        }

    }
}