package IDG.O1;

import java.util.*;

public class RandomizedSet {
    private List<Integer> map;
    Random random = new Random();

    public RandomizedSet(){
        this.map = new ArrayList<>();
        this.random = new Random();
    }

    public boolean insert(int val) {
        if(map.contains(val))
            return false;

        map.add(val);
        return true;
    }

    public boolean remove(int val) {
        if(!map.contains(val))
            return false;

        map.remove(Integer.valueOf(val));
        return true;
    }

    public int getRandom() {
        return map.get(random.nextInt(map.size()));
    }
}
