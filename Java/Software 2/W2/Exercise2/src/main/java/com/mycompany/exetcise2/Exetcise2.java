/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */
package com.mycompany.exetcise2;

/**
 *
 * @author ronniekleinfeld
 */
import java.util.Random;
import java.util.Scanner;

public class Exetcise2 {

    public static void main(String[] args) {
        Exercise3();
    }

    private static void Challenge() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter user’s choice (0 == Rock, 1 == Paper or 2 == Scissors):");
        int user = scanner.nextInt();

        int computer = new Random().nextInt(3);

        String result = "";
        if (user == computer) {
            result = "It's a tie.";
        } else if (user == 0 && computer == 2
                || user == 2 && computer == 1
                || user == 1 && computer == 0) {
            result = "User won.";
        } else {
            result = "Computer won.";
        }

        System.out.println("User:" + user + " Computer:" + computer + " " + result);
    }

    private static void Exercise5() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter 1st number:");
        double number1 = scanner.nextDouble();

        System.out.println("Enter 2nd number:");
        double number2 = scanner.nextDouble();

        System.out.println("Enter operation:");
        String operation = scanner.next();

        switch (operation) {
            case "+":
                System.out.println(number1 + number2);
                break;
            case "-":
                System.out.println(number1 - number2);
                break;
            case "*":
                System.out.println(number1 * number2);
                break;
            case "/":
                System.out.println(number1 / number2);
                break;
            default:
                System.out.println("Invalid operation");
        }
    }

    private static void Exercise4() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter grade:");
        double grade = scanner.nextDouble();

        if (grade > 100) {
            System.out.println("Invalid value");
        } else if (grade >= 70) {
            System.out.println("1st Class Honours (1)");
        } else if (grade >= 60) {
            System.out.println("2st Class Honours Upper Division (2:i)");
        } else if (grade >= 50) {
            System.out.println("2st Class Honours (2:ii)");
        } else if (grade >= 40) {
            System.out.println("3st Class Honours (3)");
        } else {
            System.out.println("Invalid value");
        }
    }

    private static void Exercise3() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter 1st grade:");
        double ictGrade = scanner.nextDouble();

        System.out.println("Enter 2nd grade:");
        double cwGrade = scanner.nextDouble();

        if (ictGrade < 30 || cwGrade < 30) {
            System.out.println("Failed.");
        } else {
            double grade = (ictGrade + cwGrade) / 2;
            if (grade < 40) {
                System.out.println("Failed.");
            } else {
                System.out.println(grade);
            }
        }
    }

    private static void Exercise2() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter an age:");
        double age = scanner.nextDouble();

        if (age >= 18) {
            System.out.println("Over 18");
        } else if (age >= 0) {
            System.out.println("Under 18");
        } else {
            System.out.println("The age entered is incorrect");
        }
    }

    private static void Exercise1() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter a number:");
        double first_number = scanner.nextDouble();

        System.out.println("Enter another number:");
        double second_number = scanner.nextDouble();

        double sum = first_number + second_number;

        System.out.println("The sum is " + sum);
    }
}
