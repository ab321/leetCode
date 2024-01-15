package org.example;

public class Main {
    public static void main(String[] args) {
        lengthOfLastWord("   fly me   to   the moon  ");
    }

    public static int lengthOfLastWord(String s) {
        s = s.trim();

        if(s.length() == 1){
            return 1;
        }

        int counter = 0;

        for (int i = s.toCharArray().length - 1; i < s.toCharArray().length ; i-- ){
            if(s.toCharArray()[i] == ' '){
                break;
            }else{
                counter++;
            }
        }

        System.out.println(counter);
        return counter;
    }
}

//2:32 min