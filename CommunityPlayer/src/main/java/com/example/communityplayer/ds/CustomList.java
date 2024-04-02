package com.example.communityplayer.ds;

import java.util.Arrays;

public class CustomList<E> {
    private Object[] elements;
    private int size;
    private static final int DEFAULT_CAPACITY = 10;

    public CustomList() {
        elements = new Object[DEFAULT_CAPACITY];
        size = 0;
    }

    public void add(E element) {
        ensureCapacity();
        elements[size++] = element;
    }

    public E get(int index) {
        if (index < 0 || index >= size) {
            throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + size);
        }
        return (E) elements[index];
    }

    public int size() {
        return size;
    }

    public boolean contains(E element) {
        for (int i = 0; i < size; i++) {
            if (elements[i].equals(element)) {
                return true;
            }
        }
        return false;
    }

    public boolean remove(E element) {
        for (int i = 0; i < size; i++) {
            if (elements[i].equals(element)) {
                removeAt(i);
                return true;
            }
        }
        return false;
    }

    public void removeAt(int index) {
        if (index < 0 || index >= size) {
            throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + size);
        }
        System.arraycopy(elements, index + 1, elements, index, size - index - 1);
        elements[--size] = null;
    }

    public void clear() {
        Arrays.fill(elements, null);
        size = 0;
    }

    private void ensureCapacity() {
        if (size == elements.length) {
            int newSize = elements.length * 2;
            Object[] newElements = new Object[newSize];
            System.arraycopy(elements, 0, newElements, 0, size);
            elements = newElements;
        }
    }
}

