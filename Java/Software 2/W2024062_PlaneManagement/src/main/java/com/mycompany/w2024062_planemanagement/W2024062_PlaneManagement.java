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
        System.out.println("Welcome to the Plane Management application");

        try {
            plane = new Plane();
            showMenuAndGetOption();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    private static void showMenuAndGetOption() {
        Scanner scanner = new Scanner(System.in);

        int choice;
        do {
            System.out.println("*************************************************");
            System.out.println("*                MENU OPTIONS                   *");
            System.out.println("*************************************************");
            System.out.println("     1) Buy a seat");
            System.out.println("     2) Cancel a seat");
            System.out.println("     3) Find first available seat");
            System.out.println("     4) Show seating plan");
            System.out.println("     5) Print tickets information and total sales");
            System.out.println("     6) Search ticket");
            System.out.println("     0) Quit");
            System.out.println("*************************************************");
            System.out.println("Please select an option:");

            choice = scanner.nextInt();
            switch (choice) {
                case 1:
                    buyASeat();
                    break;
                case 2:
                    cancelASeat();
                    break;
                case 3:
                    findFirstAvailableSeat();
                    break;
                case 4:
                    plane.printSeatingPlan();
                    break;
                case 5:
                    printTickets();
                    break;
                case 6:
                    searchTicket();
                    break;
                default:
                    System.out.println("Please enter a valid option from the list.");
            }
        } while (choice != 0);

        scanner.close();
    }

    private static void buyASeat() {
    }

    private static void cancelASeat() {
    }

    private static void findFirstAvailableSeat() {
    }

    private static void printTickets() {
    }

    private static void searchTicket() {
    }
}
