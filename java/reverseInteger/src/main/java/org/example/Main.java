package org.example;

public class Main {
    public static void main(String[] args) {
        int result = reverse(1534236469);
        System.out.println(result);
    }

    public static int reverse(int x) {
        long result = 0;

        while (x != 0) {
            long number = x % 10;
            result = result * 10 + number;
            x = x / 10;
        }

        if (result > Integer.MAX_VALUE || result < Integer.MIN_VALUE)
            return 0;

        return (int) result;
    }
}