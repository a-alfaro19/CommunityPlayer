package com.example.communityplayer.ds.iterator;

import com.example.communityplayer.ds.DoubleNode;

/**
 * An iterator over a collection.
 *
 * @param <T> the type of elements returned by this iterator
 */
public interface Iterator<T> {
    /**
     * Returns {@code true} if the iteration has more elements.
     *
     * @return {@code true} if the iteration has more elements, otherwise {@code false}
     */
    boolean hasNext();

    /**
     * Returns the next element in the iteration.
     *
     * @return the next element in the iteration
     */
    DoubleNode<T> next();
    DoubleNode<T> prev();
}
