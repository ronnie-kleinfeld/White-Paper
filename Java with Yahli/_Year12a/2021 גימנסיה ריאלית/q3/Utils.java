public class Utils {
    public static String[] getMaterialsOfPowerfulWizards(Wizard[] wizards) {
        int count = 0;
        for (Wizard w : wizards) {
            if (w.isPowerful()) {
                count++;
            }
        }

        String[] result = new String[count];
        int i = 0;
        for (Wizard w : wizards) {
            if (w.isPowerful()) {
                result[i++] = w.getWizWand().getMaterial();
            }
        }

        return result;
    }
}