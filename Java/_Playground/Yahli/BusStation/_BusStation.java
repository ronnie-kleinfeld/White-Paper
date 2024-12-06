public class _BusStation {
    private int num;
    private int[] arr;
    private int amount;

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }

    public int[] getArr() {
        return arr;
    }

    public void setArr(int[] arr) {
        this.arr = arr;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public _BusStation() {
    }

    public _BusStation(int num, int amount) {
        this.num = num;
        this.arr = new int[10];
        this.amount = amount;
    }

    public _BusStation(int num, int[] arr, int amount) {
        this.num = num;
        this.arr = arr;
        this.amount = amount;
    }

    public boolean IsStopping(int n) {
        return false;
    }
}