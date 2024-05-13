package org.example;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        int n = 0, seed = 0, capacity = 0;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Knapsack Problem\n");
        System.out.print("----------------\n");
        System.out.print("Type number of items:");
        n = scanner.nextInt();
        System.out.print("Type seed number:");
        seed = scanner.nextInt();
        System.out.print("Type capacity number:");
        capacity = scanner.nextInt();
        scanner.close();
        System.out.print("----------------\n");
        System.out.print("Generated objects:\n");
        Problem knapsackProblem = new Problem(n,seed);
        System.out.print(knapsackProblem);
        System.out.print("----------------\n");
        System.out.print(knapsackProblem.solve(capacity));

    }
}