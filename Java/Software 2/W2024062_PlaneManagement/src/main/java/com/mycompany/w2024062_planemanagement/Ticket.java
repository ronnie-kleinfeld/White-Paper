package com.mycompany.w2024062_planemanagement;

// seat 12B - seat 12, row B
// row A,B,C,D
// seat 1-12
public class Ticket {
    private int seat;
    private int row;
    private PriceLevelEnum priceLevel;
    private Person person;

    public int getSeat() {
        return seat;
    }

    public void setSeat(int seat) {
        this.seat = seat;
    }

    public int getRow() {
        return row;
    }

    public char getRowLetter() {
        switch (getRow()) {
            case 0:
                return 'A';
            case 1:
                return 'B';
            case 2:
                return 'C';
            case 3:
                return 'D';
            default:
                return ' ';
        }
    }

    public void setRow(int row) {
        this.row = row;
    }

    public PriceLevelEnum getPriceLevel() {
        return priceLevel;
    }

    public int getPrice() {
        switch (getPriceLevel()) {
            case PriceLevelEnum.firstClass:
                return 200;
            case PriceLevelEnum.business:
                return 180;
            case PriceLevelEnum.tourist:
                return 150;
        }
        return -1;
    }

    public void setPriceLevel(PriceLevelEnum priceLevel) {
        this.priceLevel = priceLevel;
    }

    public Person getPerson() {
        return person;
    }

    public void setPerson(Person person) {
        this.person = person;
    }

    public Ticket() {
    }

    public String toString() {
        String message = String.format("Ticket seat: %1, row: %2, price: %3, person: %4", (seat + 1), getRowLetter(),
                getPrice(), person.toString());
        ConsoleHelper.println(message);
        return message;
    }
}