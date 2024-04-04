package com.example.communityplayer.ds;

import com.example.communityplayer.Song;
import com.example.communityplayer.ds.iterator.Aggregate;
import com.example.communityplayer.ds.iterator.Iterator;

import java.util.NoSuchElementException;

/**
 * The DoubleLinkedList class represents a doubly linked list data structure.
 * @param <T> The type of elements stored in the list.
 */
public class DoubleLinkedList<T> implements Aggregate<T> {
    // Reference to the first node in the list
    private DoubleNode<T> head;
    // Reference to the last node in the list
    private DoubleNode<T> tail;
    // Size of the list
    private int size;

    /**
     * Represents an iterator for traversing the elements of the list.
     */
    private class DoubleLinkedListIterator implements Iterator<T> {
        private DoubleNode<T> current;

        public DoubleLinkedListIterator(DoubleNode<T> head) {
            current = head;
        }

        @Override
        public boolean hasNext() {
            return current != null;
        }

        @Override
        public DoubleNode<T> next() {
            if (!hasNext()) {
                throw new NoSuchElementException();
            }
            DoubleNode<T> currentNode = current;
            current = current.next;
            return currentNode;
        }

        public DoubleNode<T> prev() {
            if (!hasNext()) {
                throw new NoSuchElementException();
            }
            DoubleNode<T> currentNode = current;
            current = current.prev;
            return currentNode;
        }
    }

    /**
     * Checks if the list is empty.
     *
     * @return true if the list is empty, false otherwise
     */
    private boolean isEmpty() {
        return head == null;
    }

    public int getSize() {
        return size;
    }

    /**
     * Inserts a new node with the given data at the end of the list.
     *
     * @param data the data to be inserted
     */
    public void insert(T data) {
        DoubleNode<T> newNode =  new DoubleNode<>(data);
        if (isEmpty()) {
            head = newNode;

        } else {
            DoubleNode<T> current = tail;
            current.next = newNode;
            newNode.prev = current;

        }
        tail = newNode;
        size++;

    }

    /**
     * Inserts a new node with the given data at the beginning of the list.
     *
     * @param data the data to be inserted
     */
    public void insertFirst(T data) {
        DoubleNode<T> newNode =  new DoubleNode<T>(data);
        if (!isEmpty()) {
            newNode.next = head;
            head.prev = newNode;
        } else {
            tail = newNode;
        }
        head = newNode;
        size++;
    }

    @Override
    public Iterator<T> createIterator() {
        return new DoubleLinkedListIterator(head);
    }


}
