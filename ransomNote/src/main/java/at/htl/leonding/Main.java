package at.htl.leonding;

import java.util.HashMap;
import java.util.Map;

public class Main {
    public static void main(String[] args) {
        if (canConstruct("aa", "aab")){
            System.out.println("True");
        }else{
            System.out.println("False");
        }
    }

    public static boolean canConstruct(String ransomNote, String magazine) {
        if(ransomNote.length() > magazine.length())
            return false;

        Map<Character, Integer> dictionary = new HashMap<>();

        for (Character c: magazine.toCharArray()){
            if(!dictionary.containsKey(c)){
                dictionary.put(c, 1);
            }
            else{
                dictionary.put(c, dictionary.get(c) + 1);
            }
        }

        for (Character c : ransomNote.toCharArray()){
            if(dictionary.containsKey(c) && dictionary.get(c) > 0){
                dictionary.put(c, dictionary.get(c) - 1);
            }
            else{
                return false;
            }
        }

        return true;
    }
}