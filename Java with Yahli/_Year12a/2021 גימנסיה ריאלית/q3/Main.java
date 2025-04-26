public class Main {
    public static void main(String[] args) {
        Wand wand1 = new Wand("Harry", "Harry");
        Wand wand2 = new Wand("Draco", "Ash");

        Wizard wizard1 = new Wizard("Harry", wand1, 7);
        Wizard wizard2 = new Wizard("Draco", wand2, 4);

        Wizard[] wizards = { wizard1, wizard2 };
        String[] powerfulMaterials = Utils.getMaterialsOfPowerfulWizards(wizards);

        for (String material : powerfulMaterials) {
            System.out.println("Powerful wand material: " + material);
        }

        System.out.println("House 2 is: " + Hogwarts.getHouseByIndex(2));
    }
}