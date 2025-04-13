package Extends.Q8;

public class Q8 {
    public static void main(String[] args) {
        Dish dish1 = new MainCourse(56, true, new NutFacts(120, 15), 42);
        Dish dish2 = new MainCourse(42, false, new NutFacts(200, 35), 33);
        Dessert desert1 = new Dessert(39, true, new NutFacts(280, 65), true);
        IOrderable order1 = new IOrderable();// ->line 1 - Cannot instantiate the type IOrderable
        IResizable size1 = desert1; // Type mismatch: cannot convert from Dessert to IResizable
        IOrderable order2 = dish1;// line 2 - Type mismatch: cannot convert from Dish to
        order2 = (IOrderable) dish2;
        size1.SetPrice(31);// line 3 - The method SetPrice(int) is undefined for the type IResizable
        order2.OrderNow();// line 4 - The method OrderNow() is undefined for the type IOrderable
        order2.Increase();// line 5 - The method Increase() is undefined for the type IOrderable
        ((MainCourse) dish2).getIsVeg();// line 6 - The method GetIsVeg() is undefined for the type MainCourse
        dish1 = dish2; // line 7
        desert1..GetCalories();// line 8 - The method GetCalories() is undefined for the type Dessert
        desert1.getNuFacts().getCalories();

        MainCourse mc3 = new MainCourse(56, true, new NutFacts(120, 15), 42);

        IOrderable o1 = dish1;
        IOrderable o2 = (IOrderable)dish1;
        IOrderable o3 = mc3;
        IOrderable o4 = (IOrderable)mc3;

        int i1 = mc3.getPrice();
        mc3.setPrice(5);
        
        boolean b1 = mc3.getIsVeg();
        mc3.setIsVeg(true);
        
        NutFacts nf = mc3.getNuFacts();
        mc3.setNuFacts(nf);
        mc3.setNuFacts(new NutFacts(10, 20));

        int k1 = mc3.getKidPrice();
        mc3.setKidPrice(11);

        Dish mc4 = new MainCourse(56, true, new NutFacts(120, 15), 42);
        int i4 = mc4.getPrice();
        mc3.setPrice(5);
        
        boolean b4 = mc4.getIsVeg();
        mc3.setIsVeg(true);
        
        NutFacts nf4 = mc4.getNuFacts();
        mc4.setNuFacts(nf4);
        mc4.setNuFacts(new NutFacts(10, 20));

        int k4 = mc4.getKidPrice();
        int k5 = ((MainCourse)mc4).getKidPrice();

        mc4.setKidPrice(11);
        ((MainCourse)mc4).setKidPrice(11);
    }
}