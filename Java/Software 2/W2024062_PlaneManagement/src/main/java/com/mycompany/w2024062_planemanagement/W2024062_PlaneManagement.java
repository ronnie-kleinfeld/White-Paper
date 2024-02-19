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

    public static void main(String[] args) {
        System.out.println("Welcome to the Plane Management application");
    }

    public static int showMenuAndGetOption() {
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

        Scanner scanner = new Scanner(System.in);

        int option = scanner.nextInt();

        if (option < 0 || option > 6) {
            System.out.println("Please enter one of the options in the menu.");
            return showMenuAndGetOption();
        }

        return option;
    }
}
