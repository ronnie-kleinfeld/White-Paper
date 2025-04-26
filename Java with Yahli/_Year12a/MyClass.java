public class MyClass {
    private int number;
    private String text;
    private int[] numbers;
    private char letter;
    private short smallNumber;

    // Constructor
    public MyClass(int number, String text, int[] numbers, char letter, short smallNumber) {
        this.number = number;
        this.text = text;
        this.numbers = numbers;
        this.letter = letter;
        this.smallNumber = smallNumber;
    }

    // Getters
    public int getNumber() {
        return number;
    }

    public String getText() {
        return text;
    }

    public int[] getNumbers() {
        return numbers;
    }

    public char getLetter() {
        return letter;
    }

    public short getSmallNumber() {
        return smallNumber;
    }

    // Setters
    public void setNumber(int number) {
        this.number = number;
    }

    public void setText(String text) {
        this.text = text;
    }

    public void setNumbers(int[] numbers) {
        this.numbers = numbers;
    }

    public void setLetter(char letter) {
        this.letter = letter;
    }

    public void setSmallNumber(short smallNumber) {
        this.smallNumber = smallNumber;
    }

    // Method to display all properties
    public void display() {
        System.out.println("Number: " + number);
        System.out.println("Text: " + text);
        System.out.print("Numbers array: ");
        for (int num : numbers) {
            System.out.print(num + " ");
        }
        System.out.println();
        System.out.println("Letter: " + letter);
        System.out.println("Small Number: " + smallNumber);
    }
}
