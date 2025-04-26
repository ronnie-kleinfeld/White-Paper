public class Wizard {
    private String name;
    private Wand wizWand;
    private int strength;

    public Wizard(String name, Wand wizWand, int strength) {
        this.name = name;
        this.wizWand = wizWand;
        this.strength = strength;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Wand getWizWand() {
        return wizWand;
    }

    public void setWizWand(Wand wizWand) {
        this.wizWand = wizWand;
    }

    public int getStrength() {
        return strength;
    }

    public void setStrength(int strength) {
        this.strength = strength;
    }

    public boolean checkCompatibility() {
        return wizWand.getMaterial().equals(name);
    }

    public boolean isPowerful() {
        return strength > 5 && checkCompatibility();
    }
}