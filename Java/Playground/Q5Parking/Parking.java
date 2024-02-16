public class Parking {
    public String id;
    public MyTime in;
    public MyTime out;

    public int total() {
        return in.diff(out);
    }
}