package com.example.communityplayer.ds;


public class DoubleNode<T> {
    public T data;
    public DoubleNode<T> prev;
    public DoubleNode<T> next;

    /**
     * Constructs a new node with the specified data.
     * @param data The data to be stored in the node.
     */
    public DoubleNode(T data) {
        this.data = data;
        this.prev = null;
        this.next = null;
    }
}
