using System;

namespace ToneLab1
{
    public class Node
    {
        private Node prevPtr;
        public int item;
        private Node nextPtr;

        public Node(int item)
        {
            this.item = item;
        }

        public Object getPrev(){
            return prevPtr;
        }
        public Object getNext(){
            return nextPtr;
        }

        public void setPrev(Node node){
            prevPtr = node;
        }
        public void setNext(Node node){
            nextPtr = node;
        }

    }
}