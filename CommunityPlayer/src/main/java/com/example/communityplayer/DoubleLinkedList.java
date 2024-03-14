package com.example.communityplayer;

/**
 * The DoubleLinkedList class represents a doubly linked list data structure.
 * @param <T> The type of elements stored in the list.
 */
public class DoubleLinkedList<T> {
    // Reference to the first node in the list
    private Node<T> head;
    // Reference to the last node in the list
    private Node<T> tail;
    // Size of the list
    private int size;

    /**
     * Inner class representing a node in the doubly linked list.
     * @param <T> The type of data stored in the node.
     */
    private static class Node<T> {
        T data;
        Node<T> prev;
        Node<T> next;

        /**
         * Constructs a new node with the specified data.
         * @param data The data to be stored in the node.
         */
        Node(T data) {
            this.data = data;
            this.prev = null;
            this.next = null;
        }
    }

    /**
     * Constructs an empty doubly linked list.
     */
    public DoubleLinkedList() {
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    /**
     * Adds an element to the end of the list.
     * @param data The data to be added to the list.
     */
    public void add(T data) {
        Node<T> newNode = new Node<>(data);
        if (head == null) {
            head = newNode;
        } else {
            tail.next = newNode;
            newNode.prev = tail;
        }
        tail = newNode;
        size++;
    }

    /**
     * Removes the first node containing the specified data from the doubly linked list.
     * If there are multiple nodes with the same data, only the first one found will be deleted.
     *
     * @param data The data to be removed from the list.
     */
    public void delete(T data) {
        if (head == null) {
            // The list is empty, nothing to delete
            return;
        }

        Node<T> current = head;
        while (current != null) {
            if (current.equals(data)) {

                if (current == head && current == tail) {
                    // If there is only one node in the list
                    head = tail = null;

                } else if (current == head) {
                    // If the node to delete is the first one
                    head = current.next;
                    head.prev = null;

                } else if (current == tail) {
                    // If the node to delete is the last one
                    tail = tail.prev;
                    tail.next = null;

                } else {
                    // If the node to delete is in the middle
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                }

                size--;
                return;
            }

            current = current.next;
        }
    }

    /**
     * Retrieves the element at the specified index in the list.
     * @param index The index of the element to retrieve.
     * @return The data stored at the specified index.
     * @throws IndexOutOfBoundsException If the index is out of the bounds of the list.
     */
    public T get(int index) {
        if (index < 0 || index >= size) {
            throw new IndexOutOfBoundsException("Índice fuera de los límites de la lista");
        }

        Node<T> current = head;
        for (int i = 0; i < index; i++) {
            current = current.next;
        }

        return current.data;
    }

    /**
     * Prints all elements of the doubly linked list.
     */
    public void printList() {
        Node<T> current = head;
        System.out.print("List: ");
        while (current != null) {
            System.out.print(current.data + " ");
            current = current.next;
        }
        System.out.println();
    }

}
