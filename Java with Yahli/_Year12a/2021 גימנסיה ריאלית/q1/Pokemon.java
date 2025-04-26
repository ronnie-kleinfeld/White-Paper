public class Pokemon {
    private String name;
    private int rare;

    public Pokemon(String name, int rare) {
        this.name = name;
        this.rare = rare;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getRare() {
        return rare;
    }

    public void setRare(int rare) {
        this.rare = rare;
    }

    public void show() {
        System.out.println("Pokemon: " + name + ", Rare Level: " + rare);
    }
}
