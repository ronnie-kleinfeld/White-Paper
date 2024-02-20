package com.mycompany.w2024062_planemanagement;

import java.util.Arrays;

public class TicketsHelper {
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
            if (tickets[i].getRow() == row && tickets[i].getSeat() == seat) {
                return TicketsHelper.removeByIndex(tickets, i);
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