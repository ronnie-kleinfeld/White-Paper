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
    private int column;
    private PriceEnum price;
    private StatusEnum status;
    private ExistsEnum exists;

    public PriceEnum getPrice() {
        return price;
    }

    public StatusEnum getStatus() {
        return status;
    }

    public ExistsEnum getExists() {
        return exists;
    }

    public Seat(int row, int column, PriceEnum price, StatusEnum status, ExistsEnum exists) {
        this.row = row;
        this.column = column;
        this.price = price;
        this.status = status;
        this.exists = exists;
    }
}
