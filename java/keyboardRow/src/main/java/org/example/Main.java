package org.example;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        String[] words = new String[]{"Hello","Alaska","Dad","Peace"};
        findWords(words);
    }

    public static String[] findWords(String[] words) {

        String first = "qwertyuiopQWERTYUIOP";
        String second = "asdfghjklASDFGHJKL";
        String third = "zxcvbnmZXCVBNM";

        ArrayList<String> list = new ArrayList<>();

        for(int i=0;i<words.length;i++){

            int count1=0,count2=0,count3=0,len=words[i].length();

            for(int j = 0 ; j < len ; j++){

                if(first.contains(Character.toString(words[i].charAt(j))))
                    count1++;

                else if(second.contains(Character.toString(words[i].charAt(j))))
                    count2++;

                else if(third.contains(Character.toString(words[i].charAt(j))))
                    count3++;

                if(count1==len || count2==len || count3==len)
                    list.add(words[i]);
            }
        }

        String result[] = new String[list.size()];
        list.toArray(result);
        return result;
    }
}