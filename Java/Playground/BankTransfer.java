import java.io.IOException;

public class BankTransfer {
    private int fromAcct;
    private int toAcct;
    private double amount;

    public BankTransfer(int fromAcct, int toAcct, double amount) {
        this.fromAcct = fromAcct;
        this.toAcct = toAcct;
        this.amount = amount;
    }

    public static void Q2(BankTransfer bankTransfer, int[] balances) {
        balances[bankTransfer.fromAcct] -= bankTransfer.amount;
        balances[bankTransfer.toAcct] += bankTransfer.amount;
    }

    public static void main(String[] args) throws IOException {
        BankTransfer.Q3();
    }

    static int[] balances = new int[1000];

    public static void Q3() throws IOException {
        int fromAcct = System.in.read();
        int toAcct = System.in.read();
        int amount = System.in.read();
        Q2(new BankTransfer(fromAcct, toAcct, amount), balances);
    }
}