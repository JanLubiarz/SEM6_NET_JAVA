package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Collections;

public class Problem {
    public List<Item> items;
    public int n;

    public Problem(int n, int seed) {
        this.n = n;
        items = createListOfItems(seed);
    }

    public List<Item> createListOfItems(int seed)
    {
        List<Item> items = new ArrayList<Item>();
        Random random = new Random(seed);

        int price;
        int weight;

        for (int i = 0; i < n; i++)
        {
            weight = random.nextInt(1, 11);
            price = random.nextInt(1, 11);
            items.add(new Item(weight, price, i));
        }

        return items;
    }

    public ProblemResult solve(int capacity)
    {
        List<Integer> numbersOfItemsPacked = new ArrayList<>();
        int totalWeight = 0;
        int totalPrice = 0;


        items.sort((item1, item2) -> {
            float ratio1 = (float) item1.price / item1.weight;
            float ratio2 = (float) item2.price / item2.weight;
            return Float.compare(ratio2, ratio1);
        });

        for (Item item : items)
        {
            while (totalWeight + item.weight <= capacity)
            {
                numbersOfItemsPacked.add(item.id);
                totalWeight += item.weight;
                totalPrice += item.price;
            }
        }

        return new ProblemResult(numbersOfItemsPacked, totalPrice, totalWeight);
    }

    @Override
    public String toString() {
        StringBuilder itemsText = new StringBuilder();
        for (Item item : items) {
            itemsText.append(item.toString()).append("\n");
        }
        return itemsText.toString();
    }

}

