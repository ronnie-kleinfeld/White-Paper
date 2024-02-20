package com.mycompany.w2024062_planemanagement;

import java.util.Scanner;

public class PlaneManagement {
    private Chair[][] chairs; // [row][seat] row-A,B,C,D seat-1..14 char 5A
    private static Ticket[] tickets;

    public PlaneManagement() throws Exception {
        chairs = new Chair[4][14];
        tickets = new Ticket[0];

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
        showMenu();
        askForOption();
    }

    private void showMenu() {
        ConsoleHelper.println();
        ConsoleHelper.printlnGreen("Welcome to the Plane Management application");
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
        int choice;
        do {
            ConsoleHelper.printBlue("Please select an option: ");
            choice = scanner.nextInt();
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
                    // searchTicket();
                    break;
                default:
                    ConsoleHelper.println();
                    ConsoleHelper.printlnRed("Please enter a valid option from the list.");

                    ConsoleHelper.println();
            }

            ConsoleHelper.println();
        } while (choice != 0);
    }

    public void buy_seat() {
        ConsoleHelper.println("Buy a Seat:");
        ConsoleHelper.println("===========");

        Chair chair = ask_for_seat();
        if (chair == null) {
            ConsoleHelper.printlnRed("Invalid seat");
        } else {
            Ticket ticket = ask_for_ticket(chair.getSeat(), chair.getRow(), chair.getPriceLevel());

            try {
                chair.setAsSold();
                tickets = Ticket.addTicket(tickets, ticket);
                ConsoleHelper.printlnGreen(chair.toString() + " sold to you");
            } catch (Exception ex) {
                ConsoleHelper.printlnRed(ex.getMessage());
            }
        }
    }

    public void cancel_seat() {
        ConsoleHelper.println("Cancel a Seat:");
        ConsoleHelper.println("==============");

        Chair chair = ask_for_seat();
        if (chair == null) {
            ConsoleHelper.printlnRed("Invalid seat");
        } else {
            Ticket.removeTicketByRowSeat(tickets, chair.getRow(), chair.getSeat());

            try {
                chair.setAsAvailable();
                ConsoleHelper.printlnGreen(chair.toString() + " set as available");
            } catch (Exception ex) {
                ConsoleHelper.printlnRed(ex.getMessage());
            }
        }
    }

    public void show_seating_plan() {
        ConsoleHelper.println("Seating Plan:");
        ConsoleHelper.println("=============");

        for (int row = 0; row < chairs.length; row++) {
            for (int seat = 0; seat < chairs[row].length; seat++) {
                Chair chair = chairs[row][seat];
                if (chair.getExists() == ExistsEnum.exists) {
                    String str = chair.getSold() ? "X" : "O";

                    switch (chair.getPriceLevel()) {
                        case PriceLevelEnum.firstClass:
                            ConsoleHelper.printYellow(str);
                            break;
                        case PriceLevelEnum.business:
                            ConsoleHelper.printBlue(str);
                            break;
                        case PriceLevelEnum.tourist:
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

    public void find_first_available() {
        ConsoleHelper.println("Find first available:");
        ConsoleHelper.println("=====================");

        for (int row = 0; row < chairs.length; row++) {
            for (int seat = 0; seat < chairs[row].length; seat++) {
                Chair chair = chairs[row][seat];
                if (chair.getExists() == ExistsEnum.exists && !chair.getSold()) {
                    try {
                        ConsoleHelper.printlnGreen(chair.toString() + " is available");
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

    private Chair ask_for_seat() {
        Scanner scanner = new Scanner(System.in);

        ConsoleHelper.printBlue("Enter a Row (A,B,C,D): ");
        String letter = scanner.next();
        int row;
        switch (letter) {
            case "A":
                row = 0;
                break;
            case "B":
                row = 1;
                break;
            case "C":
                row = 2;
                break;
            case "D":
                row = 3;
                break;
            default:
                return null;
        }

        ConsoleHelper.printBlue("Enter a Seat (1-14): ");
        int seat = scanner.nextInt();
        if (seat < 1 || seat > 14) {
            return null;
        }

        return chairs[row][seat - 1];
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
}