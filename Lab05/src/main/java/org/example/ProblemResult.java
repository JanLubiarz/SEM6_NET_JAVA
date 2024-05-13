package org.example;
import java.util.ArrayList;
import java.util.List;

public class ProblemResult {
    public List<Integer> listOfNumbers;
    public int totalPrice;
    public int totalWeight;

    public ProblemResult(List<Integer> listOfNumbers, int totalPrice, int totalWeight) {
        this.listOfNumbers = listOfNumbers;
        this.totalPrice = totalPrice;
        this.totalWeight = totalWeight;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append("Numery Przedmiotów: ");

        for (Integer listOfNumber : listOfNumbers) {
            result.append(listOfNumber).append(" ");
        }

        result.append(System.lineSeparator());  // System.lineSeparator() zwraca odpowiedni znak nowej linii
        result.append("Total price: ").append(totalPrice);
        result.append(System.lineSeparator());
        result.append("Total weight: ").append(totalWeight);

        return result.toString();
    }
}
