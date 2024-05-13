package org.example;

public class Item {
    public int weight;
    public int price;
    public int id;

    public Item(int weight, int price, int id)
    {
        this.weight = weight;
        this.price = price;
        this.id = id;
    }

    @Override
    public String toString()
    {
        return String.format("no. %d v: %d w: %d", id, price, weight);
    }
}

