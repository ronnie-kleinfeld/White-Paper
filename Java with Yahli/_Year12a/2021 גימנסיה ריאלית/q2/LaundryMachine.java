public class LaundryMachine {
    public static boolean start(Cloth[] arr, Program p) {
        if (arr == null)
            return false;

        int totalGrams = 0;
        for (Cloth cloth : arr) {
            if (cloth == null)
                return false;
            int kind = cloth.getKind();
            if (kind < 0 || kind >= p.getProperKinds().length || !p.getProperKinds()[kind]) {
                return false;
            }
            totalGrams += cloth.getGrams();
        }

        return totalGrams <= p.getMaxGrams();
    }
}
