/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */
package com.mycompany.exercise4;

/**
 *
 * @author ronniekleinfeld
 */
public class Exercise4 {

    public static void main(String[] args) {
        System.out.println("Hello World!");

        int[] array = {10, 20, 30, 40, 50, 60};

        for (int elem : array) {
            System.out.println(elem);
        }

        array[0] = 5;
        for (int elem : array) {
            System.out.println(elem);
        }

        array[0] = 5;
        for (int elem : array) {
            System.out.println(elem);
        }

    }
}
