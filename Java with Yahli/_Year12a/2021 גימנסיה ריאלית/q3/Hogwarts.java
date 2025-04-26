public class Hogwarts {
    public static String getHouseByIndex(int index) {
        switch (index) {
            case 0:
                return "Ravenclaw";
            case 1:
                return "Hufflepuff";
            case 2:
                return "Gryffindor";
            case 3:
                return "Slytherin";
            default:
                return "Unknown";
        }
    }
}