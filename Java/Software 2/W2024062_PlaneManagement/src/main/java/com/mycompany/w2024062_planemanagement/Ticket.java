package com.mycompany.w2024062_planemanagement;

import java.io.FileWriter;
import java.io.IOException;

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

    public Ticket(int seat, int row, PriceLevelEnum priceLevel, Person person) {
        this.seat = seat;
        this.row = row;
        this.priceLevel = priceLevel;
        this.person = person;
    }

    public String toString() {
        String message = String.format(
                "Ticket seat: " + (seat + 1) +
                        ", row: " + getRowLetter() +
                        ", price: " + getPrice() +
                        ", person: " + person.toString());
        return message;
    }

    public String toCSV() {
        // row,seat,priceLevel,name,surname,email
        return getRowLetter() + "," + (getSeat() + 1) + "," + getPrice() + "," + person.getName() + ","
                + person.getSurname() + "," + person.getEmail();
    }

    public void save() throws IOException {
        // convert the char to string, without this the concatenation below will convert
        // the char to ascii code A2->65+1=66.txt
        String rowLetter = getRowLetter() + "";

        String filename = rowLetter + (getSeat() + 1) + ".txt";

        try {
            FileWriter fileWriter = new FileWriter(filename);
            fileWriter.write(toCSV());
            fileWriter.close();
        } catch (IOException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
    }
}