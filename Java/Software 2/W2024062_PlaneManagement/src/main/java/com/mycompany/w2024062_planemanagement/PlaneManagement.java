package com.mycompany.w2024062_planemanagement;

import java.util.Scanner;

public class PlaneManagement {

    private Chair[][] chairs; // [row][seat] row-A,B,C,D seat-1..14 char 5A
    private static Ticket[] tickets;

    public PlaneManagement() throws Exception {
        chairs = new Chair[4][14];
        tickets = new Ticket[0];

        initChairs();
    }

    private void initChairs() throws Exception {
        for (int row = 0; row < chairs.length; row++) {
            for (int seat = 0; seat < chairs[row].length; seat++) {
                PriceLevelEnum priceEnum;
                switch (seat) {
                    case 0, 1, 2, 3, 4:
                        priceEnum = PriceLevelEnum.firstClass;
                        break;
                    case 5, 6, 7, 8:
                        priceEnum = PriceLevelEnum.business;
                        break;
                    case 9, 10, 11, 12, 13:
                        priceEnum = PriceLevelEnum.tourist;
                        break;
                    default:
                        throw new Exception("Index out of bound");
                }

                ExistsEnum existsEnum = ExistsEnum.exists;
                if ((row == 1 || row == 2) && seat > 11) {
                    existsEnum = ExistsEnum.notExists;
                }

                chairs[row][seat] = new Chair(seat, row, priceEnum, false, existsEnum);
            }
        }
    }

    public void start() {
        ConsoleHelper.println();
        ConsoleHelper.printlnGreen("Welcome to the Plane Management application");

        askForOption();

        ConsoleHelper.printlnGreen("Thank you for using the Plane Management application");
    }

    private void showMenu() {
        ConsoleHelper.println();
        ConsoleHelper.println("*************************************************");
        ConsoleHelper.println("*                MENU OPTIONS                   *");
        ConsoleHelper.println("*************************************************");
        ConsoleHelper.println("     1) Buy a seat");
        ConsoleHelper.println("     2) Cancel a seat");
        ConsoleHelper.println("     3) Find first available seat");
        ConsoleHelper.println("     4) Show seating plan");
        ConsoleHelper.println("     5) Print tickets information and total sales");
        ConsoleHelper.println("     6) Search ticket");
        ConsoleHelper.println("     0) Quit");
        ConsoleHelper.println("*************************************************");
    }

    private void askForOption() {
        Scanner scanner = new Scanner(System.in);

        int choice = -1;
        do {
            showMenu();
            ConsoleHelper.printBlue("Please select an option: ");
            String input = scanner.next();
            try {
                choice = Integer.parseInt(input);

                ConsoleHelper.println();

                switch (choice) {
                    case 1:
                        buy_seat();
                        break;
                    case 2:
                        cancel_seat();
                        break;
                    case 3:
                        find_first_available();
                        break;
                    case 4:
                        show_seating_plan();
                        break;
                    case 5:
                        print_tickets_info();
                        break;
                    case 6:
                        search_ticket();
                        break;
                    case 0:
                        break;
                    default:
                        ConsoleHelper.println();
                        ConsoleHelper.printlnRed("Please enter a valid option from the list.");

                        ConsoleHelper.println();
                }

                ConsoleHelper.println();
            } catch (Exception e) {
                ConsoleHelper.printlnRed("Please enter a valid option from the list.");
            }
        } while (choice != 0);
    }

    private void buy_seat() {
        ConsoleHelper.println("Buy a Seat:");
        ConsoleHelper.println("===========");

        Chair chair = ask_for_seat();
        Ticket ticket = ask_for_ticket(chair.getSeat(), chair.getRow(), chair.getPriceLevel());

        try {
            chair.setAsSold();
            tickets = TicketsHelper.addTicket(tickets, ticket);
            ticket.save();
            ConsoleHelper.printlnGreen("Ticket information saved to " + ticket.fileName());
            ConsoleHelper.printlnGreen(chair.toString() + " sold to " + ticket.getPerson().toString());
        } catch (Exception ex) {
            ConsoleHelper.printlnRed(ex.getMessage());
        }
    }

    private void cancel_seat() {
        ConsoleHelper.println("Cancel a Seat:");
        ConsoleHelper.println("==============");

        Chair chair = ask_for_seat();
        TicketsHelper.removeTicketByRowSeat(tickets, chair.getRow(), chair.getSeat());

        try {
            chair.setAsAvailable();
            tickets = TicketsHelper.removeTicketByRowSeat(tickets, chair.getRow(), chair.getSeat());
            ConsoleHelper.printlnGreen(chair.toString() + " set as available");
        } catch (Exception ex) {
            ConsoleHelper.printlnRed(ex.getMessage());
        }
    }

    private void show_seating_plan() {
        ConsoleHelper.println("Seating Plan:");
        ConsoleHelper.println("=============");

        for (int row = 0; row < chairs.length; row++) {
            for (int seat = 0; seat < chairs[row].length; seat++) {
                Chair chair = chairs[row][seat];
                if (chair.getExists() == ExistsEnum.exists) {
                    String str = chair.getIsSold() ? "X" : "O";

                    switch (chair.getPriceLevel()) {
                        case firstClass:
                            ConsoleHelper.printYellow(str);
                            break;
                        case business:
                            ConsoleHelper.printBlue(str);
                            break;
                        case tourist:
                            ConsoleHelper.printGreen(str);
                            break;
                    }
                } else {
                    ConsoleHelper.print(' ');
                }
            }
            ConsoleHelper.println();
        }
    }

    private void find_first_available() {
        ConsoleHelper.println("Find first available:");
        ConsoleHelper.println("=====================");

        for (int row = 0; row < chairs.length; row++) {
            for (int seat = 0; seat < chairs[row].length; seat++) {
                Chair chair = chairs[row][seat];
                if (chair.getExists() == ExistsEnum.exists && !chair.getIsSold()) {
                    try {
                        ConsoleHelper.printlnGreen(chair.toString() + " is available");
                        if (ask_y_n("Do you want to purchase this ticket (Y,N)?")) {
                            Ticket ticket = ask_for_ticket(chair.getSeat(), chair.getRow(), chair.getPriceLevel());
                            chair.setAsSold();
                            tickets = TicketsHelper.addTicket(tickets, ticket);
                            ticket.save();
                            ConsoleHelper.printlnGreen(chair.toString() + " sold to " + ticket.getPerson().toString());
                        }
                        return;
                    } catch (Exception e) {
                        // try catch is not needed here, I validate the exception cause in the
                        // preceeding if to validate the it is a valid chair
                    }
                }
            }
        }

        ConsoleHelper.printlnRed("This plane is fully sold out");
        ConsoleHelper.println();
    }

    private void print_tickets_info() {
        ConsoleHelper.println("Tickets:");
        ConsoleHelper.println("========");

        if (tickets == null || tickets.length == 0) {
            ConsoleHelper.printlnRed("No tickets");
        } else {
            int sum = 0;

            for (int i = 0; i < tickets.length; i++) {
                ConsoleHelper.println(tickets[i].toString());
                sum += tickets[i].getPrice();
            }

            ConsoleHelper.println("Total amount:" + sum);
        }

        ConsoleHelper.println();
    }

    private void search_ticket() {
        ConsoleHelper.println("Search Tickets:");
        ConsoleHelper.println("===============");

        Chair chair = ask_for_seat();
        if (chair.getIsSold()) {
            int index = TicketsHelper.findTicketByRowSeat(tickets, chair.getRow(), chair.getSeat());
            if (index == -1) {
                ConsoleHelper.printlnRed("Error: seat " + chair.toString() + " without a ticket.");
            } else {
                ConsoleHelper.println(tickets[index].toString());
            }
        } else {
            ConsoleHelper.printGreen("Seat " + chair.toString() + " is available");
        }

        ConsoleHelper.println();
    }

    private Chair ask_for_seat() {
        Scanner scanner = new Scanner(System.in);

        int row = -1;
        int maxAvaliableSeats = 14;
        while (row == -1) {
            ConsoleHelper.printBlue("Enter a Row (A,B,C,D): ");
            String input = scanner.next();
            switch (input.toUpperCase()) {
                case "A":
                    row = 0;
                    maxAvaliableSeats = 14;
                    break;
                case "B":
                    row = 1;
                    maxAvaliableSeats = 12;
                    break;
                case "C":
                    row = 2;
                    maxAvaliableSeats = 12;
                    break;
                case "D":
                    row = 3;
                    maxAvaliableSeats = 14;
                    break;
                default:
                    ConsoleHelper.printlnRed("Invalid Row, Please enter (A,B,C,D)");
            }
        }

        int seat = -1;
        while (seat == -1) {
            ConsoleHelper.printBlue("Enter a Seat (1-" + maxAvaliableSeats + "): ");
            String input = scanner.next();
            try {
                int s = Integer.parseInt(input);
                if (s >= 1 && s <= maxAvaliableSeats) {
                    seat = s;
                } else {
                    ConsoleHelper.printlnRed("Invalid Seat, Please enter (1-" + maxAvaliableSeats + ")");
                }
            } catch (Exception e) {
                ConsoleHelper.printlnRed("Invalid Seat, Please enter (1-" + maxAvaliableSeats + ")");
            }
        }

        Chair chair = chairs[row][seat - 1];
        ConsoleHelper.printlnGreen("You have chosen seat " + chair.toString());

        return chair;
    }

    private Ticket ask_for_ticket(int seat, int row, PriceLevelEnum priceLevel) {
        Scanner scanner = new Scanner(System.in);

        ConsoleHelper.printBlue("Enter Name: ");
        String name = scanner.next();

        ConsoleHelper.printBlue("Enter Surname: ");
        String surname = scanner.next();

        ConsoleHelper.printBlue("Enter eMail: ");
        String email = scanner.next();

        Person person = new Person(name, surname, email);

        Ticket ticket = new Ticket(seat, row, priceLevel, person);

        return ticket;
    }

    // ask yes or no question
    // message = Do you want to purchase this ticket (Y,N)?
    private boolean ask_y_n(String message) {
        Scanner scanner = new Scanner(System.in);

        while (true) {
            ConsoleHelper.printBlue(message);
            String input = scanner.next();
            switch (input.toUpperCase()) {
                case "Y":
                    return true;
                case "N":
                    return false;
                default:
                    ConsoleHelper.printlnRed("Invalid input");
            }
        }
    }
}