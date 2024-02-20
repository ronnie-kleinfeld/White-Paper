/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */
package com.mycompany.w2024062_planemanagement;

import java.util.Scanner;

/**
 *
 * @author ronniekleinfeld
 */
public class W2024062_PlaneManagement {
    private static Plane plane;

    public static void main(String[] args) {
        try {
            plane = new Plane();
            showMenuAndGetOption();
        } catch (Exception e) {
            ConsoleHelper.printlnRed(e.getMessage());
        }
    }

    private static void showMenuAndGetOption() {
        Scanner scanner = new Scanner(System.in);

        int choice;
        do {
            ConsoleHelper.println();
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
            ConsoleHelper.printlnBlue("Please select an option:");

            choice = scanner.nextInt();
            ConsoleHelper.println();
            switch (choice) {
                case 1:
                    plane.buy_seat();
                    break;
                case 2:
                    plane.cancel_seat();
                    break;
                case 3:
                    findFirstAvailableSeat();
                    break;
                case 4:
                    plane.show_seating_plan();
                    break;
                case 5:
                    printTickets();
                    break;
                case 6:
                    searchTicket();
                    break;
                default:
                    ConsoleHelper.println();
                    ConsoleHelper.printlnRed("Please enter a valid option from the list.");

                    ConsoleHelper.println();
            }

            ConsoleHelper.println();
        } while (choice != 0);

        scanner.close();
    }

    private static void findFirstAvailableSeat() {
    }

    private static void printTickets() {
    }

    private static void searchTicket() {
    }
}
