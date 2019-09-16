using System;

namespace ToneLab1
{
    public class Queue
    {
        private int start;
        private int end;
        private int[] array;

        public Queue(int size)
        {
            array = new int[size];
            start = 0;
            end = size - 1;
        }
        public Queue()
        {

        }

        //clone
        public Queue clone()
        {
            Queue newQueue = new Queue();
            newQueue.array = this.array;
            newQueue.start = this.start;
            newQueue.end = this.end;

            return newQueue;
        }

        //peek
        public int peek()
        {
            return array[start];
        }

        //enqueue
        public void enqueue(int item)
        {
            if(!isFull()){
                int index = (end+1)%array.Length;
                array[index]=item;
            }
        }

        //dequeue
        public int dequeue()
        {
            if (!isEmpty() )
            {
                int item = array[start];
                start = (start + 1) % array.Length;
                return item;
            }else
            {
                return -1;
            }

        }
        //is full
        public bool isFull()
        {
            return (start == (end + 1) % array.Length);
        }
        //is empty
        public bool isEmpty()
        {
            return (start == end);
        }
    }
}