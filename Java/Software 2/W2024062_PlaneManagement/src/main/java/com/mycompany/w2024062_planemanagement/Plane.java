/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.w2024062_planemanagement;

import java.util.Scanner;

/**
 *
 * @author ronniekleinfeld
 */
public class Plane {
    private Seat[][] seats;

    public Plane() throws Exception {
        seats = new Seat[14][4];

        for (int col = 0; col < 4; col++) {
            for (int row = 0; row < 14; row++) {
                PriceEnum priceEnum;
                switch (row) {
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
                if ((col == 1 || col == 2) && row > 11) {
                    existsEnum = ExistsEnum.notExists;
                }

                seats[row][col] = new Seat(row, col, priceEnum, false, existsEnum);
            }
        }
    }

    public void buy_seat() {
        ConsoleHelper.println("Buy a Seat:");
        ConsoleHelper.println("===========");

        Seat seat = ask_for_seat();
        if (seat == null) {
            ConsoleHelper.printlnRed("Invalid seat");
        } else {
            try {
                seat.setSold(true);
                ConsoleHelper.printlnGreen(seat.toString() + " sold to you");
            } catch (Exception ex) {
                ConsoleHelper.printlnRed(ex.getMessage());
            }
        }
    }

    public void cancel_seat() {
        ConsoleHelper.println("Cancel a Seat:");
        ConsoleHelper.println("==============");

        Seat seat = ask_for_seat();
        if (seat == null) {
            ConsoleHelper.printlnRed("Invalid seat");
        } else {
            try {
                seat.setSold(false);
                ConsoleHelper.printlnGreen(seat.toString() + " set as available");
            } catch (Exception ex) {
                ConsoleHelper.printlnRed(ex.getMessage());
            }
        }
    }

    public void show_seating_plan() {
        ConsoleHelper.println("Seating Plan:");
        ConsoleHelper.println("=============");

        for (int col = 0; col < 4; col++) {
            for (int row = 0; row < 14; row++) {
                Seat seat = seats[row][col];
                if (seat.getExists() == ExistsEnum.exists) {
                    String str = seat.getSold() ? "X" : "O";

                    switch (seat.getPrice()) {
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

    private Seat ask_for_seat() {
        Scanner scanner = new Scanner(System.in);

        ConsoleHelper.printBlue("Enter a Row: ");
        int row = scanner.nextInt();
        if (row < 1 || row > 14) {
            return null;
        }

        ConsoleHelper.printBlue("Enter a Column (A,B,C,D): ");
        String letter = scanner.next();
        int col;
        switch (letter) {
            case "A":
                col = 0;
                break;
            case "B":
                col = 1;
                break;
            case "C":
                col = 2;
                break;
            case "D":
                col = 3;
                break;
            default:
                return null;
        }

        return seats[row - 1][col];
    }
}