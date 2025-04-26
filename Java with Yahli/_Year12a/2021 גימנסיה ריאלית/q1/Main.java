public class Main {
    public static void main(String[] args) {
        PokCage cage = new PokCage();
        Pokemon p1 = new Pokemon("p1", 5);
        Pokemon p2 = new Pokemon("p2", 4);
        Pokemon p3 = new Pokemon("p3", 10);

        cage.insertPokemon(p1); // true
        cage.insertPokemon(p2); // false
        cage.insertPokemon(p3); // true

        System.out.println("Count of rare level 5: " + cage.countRarePokemons(5));
        System.out.println("Count of rare level 10: " + cage.countRarePokemons(10));
    }
}