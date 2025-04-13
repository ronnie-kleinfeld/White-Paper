package Extends.Q8;

public class NutFacts {
    private int calories;
    private int carbs;

    public NutFacts(int calories, int carbs) {
        this.calories = calories;
        this.carbs = carbs;
    }

    public int getCalories() {
        return calories;
    }

    public int getCarbs() {
        return carbs;
    }

    public void setCalories(int calories) {
        this.calories = calories;
    }

    public void setCarbs(int carbs) {
        this.carbs = carbs;
    }
}