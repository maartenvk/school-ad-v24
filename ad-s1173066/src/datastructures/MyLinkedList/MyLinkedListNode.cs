﻿namespace AD
{
    public partial class MyLinkedListNode<T>
    {
        public T data;
        public MyLinkedListNode<T>? next;

        public MyLinkedListNode(T data, MyLinkedListNode<T>? next = null)
        {
            this.data = data;
            this.next = next;
        }
    }
}
