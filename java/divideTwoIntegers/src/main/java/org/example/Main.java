package org.example;

public class Main {
    public static void main(String[] args){
        System.out.println(divide(10, 3));
    }

    public static int divide(int dividend, int divisor) {
        double result = (double) dividend /divisor;

        return (int) result;
    }
}