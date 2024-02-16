public class Q5 {
    public static void main(String[] args) {

    }

    public static void first(Parking[] cars) {
        Parking first = cars[0];

        if (cars.length > 1) {
            for (int i = 1; i < cars.length - 1; i++) {
                if (cars[i].in.before(first.in)) {
                    first = cars[i];
                }
            }
        }

        System.out.println(first.id);
    }

    public static int sumMoney(Parking[] cars) {
        int sum = 0;

        for (int i = 0; i < cars.length; i++) {
            if (cars[i].total() > 120) {
                sum += (cars[i].total() - 120) * 1;
            }
        }

        return sum;
    }
}