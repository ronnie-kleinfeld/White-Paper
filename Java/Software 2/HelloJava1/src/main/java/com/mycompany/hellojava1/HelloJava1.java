/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.hellojava1;

/**
 *
 * @author ronniekleinfeld
 */
import java.util.*;
public class HelloJava1 {

    public static void main(String[] args) {
        Challenge();
    }
    
    private static void Challenge() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Please enter a name:");
        String name = scanner.next();
        System.out.println("Please enter a surname:");
        String surName = scanner.next();
        System.out.println(name.substring(0,1) + surName.substring(0,1));
    }
    
    private static void Exercise2() {
        System.out.println("********");
        System.out.println("* MENU *");
        System.out.println("********");
    }
    
    private static void Exercise1() {
        System.out.println("Hello Ronnie!");
        System.out.println("This is my furst JAVA program.");
        Scanner scanner = new Scanner(System.in);
        System.out.println("Please enter your name:");
        String name = scanner.next();
        System.out.println("Hello " + name);
    }
}
