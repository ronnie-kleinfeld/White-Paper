public class MyTime {
    public int myMinute;
    public int myHour;

    public boolean before(MyTime other) {
        return true;
    }

    public int diff(MyTime other) {
        return -1;
    }
}