package org.example;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {

    @Test
    public void NumberCountTest() {
        Problem problem = new Problem(5, 1);
        Assertions.assertEquals(5, problem.n);
    }

    @Test
    public void FinalResultCorrectnessTest() {
        Problem problem = new Problem(3, 1);
        ProblemResult result = problem.solve(23);
        List<Integer> listOfNumbers = new ArrayList<>(Arrays.asList(0, 0, 0, 2));
        ProblemResult correctResult = new ProblemResult(listOfNumbers, 32, 23);

        String resultText = result.toString();
        String correctResultText = correctResult.toString();
        Assertions.assertEquals(correctResultText, resultText);
    }

    @Test
    public void EmptyResultTest() {
        Problem problem = new Problem(3, 1);
        ProblemResult result = problem.solve(0);
        List<Integer> listOfNumbers = new ArrayList<>();
        ProblemResult correctResult = new ProblemResult(listOfNumbers, 0, 0);

        String resultText = result.toString();
        String correctResultText = correctResult.toString();
        Assertions.assertEquals(correctResultText, resultText);
    }

    @Test
    public void NoItemsToAddToTheBagTest() {
        Problem problem = new Problem(0, 1);
        ProblemResult result = problem.solve(10);
        List<Integer> listOfNumbers = new ArrayList<>();
        ProblemResult correctResult = new ProblemResult(listOfNumbers, 0, 0);

        String resultText = result.toString();
        String correctResultText = correctResult.toString();
        Assertions.assertEquals(correctResultText, resultText);
    }

}