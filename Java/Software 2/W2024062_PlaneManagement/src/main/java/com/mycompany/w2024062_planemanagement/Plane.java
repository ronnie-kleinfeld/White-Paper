/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.w2024062_planemanagement;

/**
 *
 * @author ronniekleinfeld
 */
public class Plane {
    private Seat[][] seats;

    public Plane() throws Exception {
        seats = new Seat[4][14];

        for (int row = 0; row < 4; row++) {
            for (int column = 0; column < 14; column++) {
                PriceEnum priceEnum;
                switch (column) {
                    case 0, 1, 2, 3, 4, 5:
                        priceEnum = PriceEnum.firstClass;
                        break;
                    case 6, 7, 8, 9:
                        priceEnum = PriceEnum.business;
                        break;
                    case 10, 11, 12, 13:
                        priceEnum = PriceEnum.business;
                        break;
                    default:
                        throw new Exception("Index out of bound");
                }

                ExistsEnum existsEnum = ExistsEnum.exists;
                if ((row == 1 || row == 2) && column > 11) {
                    existsEnum = ExistsEnum.notExists;
                }

                seats[row][column] = new Seat(row, column, priceEnum, StatusEnum.available, existsEnum);
            }
        }
    }

    public void printSeatingPlan() {
        System.out.println("Seating Plan:");
        System.out.println("=============");
        System.out.println();

        for (int row = 0; row < 4; row++) {
            for (int column = 0; column < 14; column++) {
                Seat seat = seats[row][column];
                if (seat.getExists() == ExistsEnum.exists) {
                    if (seat.getStatus() == StatusEnum.available) {
                        System.out.print('O');
                    } else {
                        System.out.print('X');
                    }
                } else {
                    System.out.print(' ');
                }
            }
            System.out.println();
        }

        System.out.println();
    }
}