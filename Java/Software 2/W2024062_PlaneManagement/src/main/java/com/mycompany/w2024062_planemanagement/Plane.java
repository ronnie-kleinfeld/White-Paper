package com.mycompany.w2024062_planemanagement;

import java.util.Scanner;

// seat 12B - seat 12, row B
// row A,B,C,D
// seat 1-12
public class Plane {
    private Chair[][] chairs;

    public Plane() throws Exception {
        chairs = new Chair[4][14];

        for (int row = 0; row < 4; row++) {
            for (int seat = 0; seat < 14; seat++) {
                PriceEnum priceEnum;
                switch (seat) {
                    case 0, 1, 2, 3, 4:
                        priceEnum = PriceEnum.firstClass;
                        break;
                    case 5, 6, 7, 8:
                        priceEnum = PriceEnum.business;
                        break;
                    case 9, 10, 11, 12, 13:
                        priceEnum = PriceEnum.tourist;
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

    public void buy_seat() {
        ConsoleHelper.println("Buy a Seat:");
        ConsoleHelper.println("===========");

        Chair chair = ask_for_seat();
        if (chair == null) {
            ConsoleHelper.printlnRed("Invalid seat");
        } else {
            try {
                chair.setAsSold();
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

        for (int row = 0; row < 4; row++) {
            for (int seat = 0; seat < 14; seat++) {
                Chair chair = chairs[row][seat];
                if (chair.getExists() == ExistsEnum.exists) {
                    String str = chair.getSold() ? "X" : "O";

                    switch (chair.getPrice()) {
                        case PriceEnum.firstClass:
                            ConsoleHelper.printYellow(str);
                            break;
                        case PriceEnum.business:
                            ConsoleHelper.printBlue(str);
                            break;
                        case PriceEnum.tourist:
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
}