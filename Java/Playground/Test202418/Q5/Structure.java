package Test202418.Q5;

public class Structure {
    public Pixel[][] arr;

    public boolean isBalanced() {
        int countRed = 0;
        int countGreen = 0;
        int countBlue = 0;

        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                if (arr[i][j].isRed())
                    countRed++;
                if (arr[i][j].isGreen())
                    countGreen++;
                if (arr[i][j].isBlue())
                    countBlue++;
            }
        }

        return countRed == countGreen && countGreen == countBlue;
    }

    public boolean allOthers() {
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                Pixel item = arr[i][j];
                if (item.isRed() || item.isGreen() || item.isBlue()) {
                    return false;
                }
            }
        }

        return true;
    }
}