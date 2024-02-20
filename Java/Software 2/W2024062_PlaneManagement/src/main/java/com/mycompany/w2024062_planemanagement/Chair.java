package com.mycompany.w2024062_planemanagement;

// seat 12B - seat 12, row B
// row A,B,C,D
// seat 1-12
public class Chair {
    private int seat;
    private int row;
    private PriceEnum price;
    private boolean sold;
    private ExistsEnum exists;

    public PriceEnum getPrice() {
        return price;
    }

    public char getRow() {
        switch (row) {
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

    public void setAsSold() throws Exception {
        if (getExists() == ExistsEnum.notExists) {
            throw new Exception("Invalid seat");
        } else if (getSold()) {
            throw new Exception("Seat is not available");
        } else {
            this.sold = true;
        }
    }

    public void setAsAvailable() throws Exception {
        if (getExists() == ExistsEnum.notExists) {
            throw new Exception("Invalid seat");
        } else if (!getSold()) {
            throw new Exception("Seat is available");
        } else {
            this.sold = false;
        }
    }

    public boolean getSold() {
        return sold;
    }

    public ExistsEnum getExists() {
        return exists;
    }

    public Chair(int seat, int row, PriceEnum price, boolean sold, ExistsEnum exists) {
        this.seat = seat;
        this.row = row;
        this.price = price;
        this.sold = sold;
        this.exists = exists;
    }

    public String toString() {
        return "Chair " + (seat + 1) + getRow();
    }
}