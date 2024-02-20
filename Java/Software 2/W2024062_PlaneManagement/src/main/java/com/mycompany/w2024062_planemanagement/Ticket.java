package com.mycompany.w2024062_planemanagement;

import java.util.Arrays;

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

    public static Ticket[] addTicket(Ticket[] old, Ticket add) {
        Ticket[] newTickets;

        if (old == null) {
            newTickets = new Ticket[1];
        } else {
            newTickets = Arrays.copyOf(old, old.length + 1);
        }
        newTickets[newTickets.length - 1] = add;

        return newTickets;
    }

    public static Ticket[] removeTicketByRowSeat(Ticket[] tickets, int row, int seat) {
        for (int i = 0; i < tickets.length; i++) {
            if (tickets[i].row == row && tickets[i].seat == seat) {
                return Ticket.removeByIndex(tickets, i);
            }
        }

        return null;
    }

    public static Ticket[] removeByIndex(Ticket[] arr, int removeIndex) {
        Ticket[] newArr = new Ticket[arr.length - 1];
        int newIndex = 0;

        for (int i = 0; i < arr.length; i++) {
            if (i != removeIndex) {
                newArr[newIndex++] = arr[i];
            }
        }

        return newArr;
    }
}