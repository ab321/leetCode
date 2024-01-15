package org.example;

public class Main {
    public static void main(String[] args) {

        var input = new int[]{
                1,2,3,4,5,6,7
        };

        int k = 3;
        rotate(input, k);
    }

    public static void rotate(int[] nums, int k) {

        int temp[] = new int[nums.length];

        for(int i = 0; i < nums.length; i++){
            temp[(i + k) % nums.length] = nums[i];
        }

        for(int i = 0; i < nums.length; i++){
            nums[i] = temp[i];
        }
    }
}