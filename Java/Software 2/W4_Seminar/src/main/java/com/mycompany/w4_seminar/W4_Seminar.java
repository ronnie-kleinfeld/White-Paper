/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.w4_seminar;

import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author ronniekleinfeld
 */
public class W4_Seminar {

    public static void main(String[] args) {
//        Ex1();
//        Ex2();
//        Ex3();
//        Ex4();
//        Ex5();
        Challenge();
    }

    public static void Ex1() {
        int[] array = {10, 20, 30, 40, 50, 60};

        for (int elem : array) {
            System.out.println(elem);
        }

        array[0] = 5;
        for (int elem : array) {
            System.out.println(elem);
        }

        array[5] = 120;
        for (int elem : array) {
            System.out.println(elem);
        }
    }

    public static void Ex2() {
        double[] array = new double[10];
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i < 10; i++) {
            System.out.println("Please enter a number:");
            array[i] = scanner.nextDouble();
        }

        double sum = 0;
        for (double elem : array) {
            sum += elem;
            System.out.println(elem);
        }

        System.out.println("The average is: " + sum / 10);
    }

    public static void Ex3() {
        String[] array = {"Alex", "Max", "Charlie", "Bob", "Ada", "Jim"};

        System.out.println(Arrays.toString(array));

        Ex3Swap(array, 2, 4);

        System.out.println(Arrays.toString(array));
    }

    public static void Ex3Swap(String[] array, int index1, int index2) {
        String temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static void Ex4() {
        double[][] marks = new double[5][3];
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i < 5; i++) {
            System.out.println("Student #" + (i + 1));

            double sum = 0;
            for (int j = 0; j < 3; j++) {
                System.out.println("Enter grade #" + (j + 1) + " for student #" + (i + 1) + ":");
                marks[i][j] = scanner.nextDouble();
                sum += marks[i][j];
            }

            System.out.println("Average for student #" + (i + 1) + " is: " + sum / 3);
        }
    }

    public static void Ex5() {
        int[] array = {2, 3, 4, 5, 6, 7, 8, 9};

        System.out.println(Arrays.toString(array));

        for (int elem : array) {
            if (elem % 2 == 0) {
                System.out.println("Element " + elem + " is even");
            }
        }

        for (int elem : array) {
            if (contains(array, elem * 2)) {
                System.out.println(elem + " * 2 = " + elem * 2 + " is also in the array");
            }
        }
    }

    public static boolean contains(int[] array, int value) {
        for (double elem : array) {
            if (elem == value) {
                return true;
            }
        }

        return false;
    }

    public static void Challenge() {
        int count = 12000000;
        int[] x = roll(count);
        int[] y = roll(count);

        System.out.println(Arrays.toString(x));
        System.out.println(Arrays.toString(y));

        System.out.println("x=4 : " + (x[3] / (double) count));
        System.out.println("y=4 : " + (y[3] / (double) count));

        System.out.println("x=4 and y=4 : " + (y[3] / (double) count) * (x[3] / (double) count));
    }

    public static int[] roll(int count) {
        int[] result = new int[6];

        Random generator = new Random();

        for (int i = 0; i < count; i++) {
            int roll = generator.nextInt(6);

            result[roll]++;
        }

        return result;
    }
}
