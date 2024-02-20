/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.w2024062_planemanagement;

/**
 *
 * @author ronniekleinfeld
 */
public class Seat {
    private int row;
    private int col;
    private PriceEnum price;
    private boolean sold;
    private ExistsEnum exists;

    public PriceEnum getPrice() {
        return price;
    }

    public char getCol() {
        switch (col) {
            case 0:
                return 'A';
            case 1:
                return 'B';
            case 2:
                return 'C';
            case 3:
                return 'D';
            default:
                return ' ';
        }
    }

    public void setSold() throws Exception {
        if (getExists() == ExistsEnum.notExists) {
            throw new Exception("Invalid seat");
        } else if (getSold()) {
            throw new Exception("Seat is not available");
        } else {
            sold = true;
        }
    }

    public boolean getSold() {
        return sold;
    }

    public ExistsEnum getExists() {
        return exists;
    }

    public Seat(int row, int col, PriceEnum price, boolean sold, ExistsEnum exists) {
        this.row = row;
        this.col = col;
        this.price = price;
        this.sold = sold;
        this.exists = exists;
    }

    public String toString() {
        return "Seat " + (row + 1) + getCol();
    }
}