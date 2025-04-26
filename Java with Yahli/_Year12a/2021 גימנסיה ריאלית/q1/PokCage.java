public class PokCage {
    private Pokemon[] pokArr;
    private int current;

    public PokCage() {
        pokArr = new Pokemon[100];
        current = 0;
    }

    public void showAll() {
        for (int i = 0; i < current; i++) {
            pokArr[i].show();
        }
    }

    public void showRare() {
        for (int i = 0; i < current; i++) {
            if (pokArr[i].getRare() % 5 == 0) {
                pokArr[i].show();
            }
        }
    }

    public void showRare(int rareLevel) {
        for (int i = 0; i < current; i++) {
            if (pokArr[i].getRare() == rareLevel) {
                pokArr[i].show();
            }
        }
    }

    public void showRare(int rareLevel, int minRare) {
        for (int i = 0; i < current; i++) {
            if (pokArr[i].getRare() == rareLevel && pokArr[i].getRare() > minRare) {
                pokArr[i].show();
            }
        }
    }

    public boolean insertPokemon(Pokemon p) {
        if (current < pokArr.length && p.getRare() % 5 == 0) {
            pokArr[current++] = p;
            return true;
        }
        return false;
    }

    public int countRarePokemons(int rareLevel) {
        int count = 0;
        for (int i = 0; i < current; i++) {
            if (pokArr[i].getRare() == rareLevel) {
                count++;
            }
        }
        return count;
    }
}
