package com.mycompany.w2024062_planemanagement;

public class ConsoleHelper {
    public static String RESET = "\u001B[0m";
    public static String RED = "\u001B[31m";
    public static String GREEN = "\u001B[32m";
    public static String BLUE = "\u001B[34m";
    public static String YELLOW = "\u001B[33m";

    public static void print(String message) {
        System.out.print(message);
    }

    public static void print(char c) {
        System.out.print(c);
    }

    public static void printRed(String message) {
        System.out.print(RED + message + RESET);
    }

    public static void printGreen(String message) {
        System.out.print(GREEN + message + RESET);
    }

    public static void printBlue(String message) {
        System.out.print(BLUE + message + RESET);
    }

    public static void printYellow(String message) {
        System.out.print(YELLOW + message + RESET);
    }

    public static void println() {
        System.out.println();
    }

    public static void println(String message) {
        System.out.println(message);
    }

    public static void printlnRed(String message) {
        System.out.print(RED + message + RESET);
    }

    public static void printlnGreen(String message) {
        System.out.print(GREEN + message + RESET);
    }

    public static void printlnBlue(String message) {
        System.out.print(BLUE + message + RESET);
    }

    public static void printlnYellow(String message) {
        System.out.print(YELLOW + message + RESET);
    }
}