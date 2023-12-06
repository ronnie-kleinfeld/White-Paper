public class PencilCup {
    int numPencils;
    int numPens;
    boolean scisssors;

    public PencilCup() {
        numPencils = 0;
        numPens = 0;
        scisssors = false;
    }

    public PencilCup(int numPencils, int numPens, boolean scisssors) {
        this.numPencils = numPencils;
        this.numPens = numPens;
        this.scisssors = scisssors;
    }

    public PencilCup(PencilCup p1, PencilCup p2) {
        this.numPencils = p1.numPencils = p1.numPencils;
        this.numPens = p1.numPens + p1.numPens;
        this.scisssors = p1.scisssors || p1.scisssors;
        p1.empty();
        p2.empty();
    }

    public int getNumPencils() {
        return this.numPencils;
    }

    public void setNumPencils(int numPencils) {
        this.numPencils = numPencils;
    }

    public int getNumPens() {
        return this.numPens;
    }

    public void setNumPens(int numPens) {
        this.numPens = numPens;
    }

    public boolean hasScissors() {
        return this.scisssors;
    }

    public void setScissors(boolean scisssors) {
        this.scisssors = scisssors;
    }

    public int value(int price) {
        int pencilsPrice = this.getNumPencils() * price;
        int pensPrice = this.getNumPens() * price * 3;
        int scissorsPrice = 0;
        if (this.hasScissors()) {
            scissorsPrice = price * 10;
        }
        return pencilsPrice + pensPrice + scissorsPrice;
    }

    public static void toSame(PencilCup p1, PencilCup p2) {
        int pencils = p1.getNumPencils() + p2.getNumPencils();
        int pens = p1.getNumPens() + p2.getNumPens();
        boolean scissors = p1.hasScissors() || p2.hasScissors();
        p1.setNumPencils((pencils / 2));
        p2.setNumPencils((pencils / 2));
        p1.setNumPens((pens / 2));
        p2.setNumPens((pens / 2));
        if (pencils / 2 == 1 && pens / 2 == 1) {
            p1.setNumPencils(p2.getNumPencils() + 1);
            p1.setNumPens(p2.getNumPens() + 1);
        }
        p1.setScissors(scissors);
        p2.setScissors(scissors);
    }

    public void empty() {
        numPencils = 0;
        numPens = 0;
        scisssors = false;
    }

    public String toString() {
        return "PencilCup [numPencils=" + numPencils + ", numPens=" + numPens + ", scisssors=" + scisssors + "]";
    }
}