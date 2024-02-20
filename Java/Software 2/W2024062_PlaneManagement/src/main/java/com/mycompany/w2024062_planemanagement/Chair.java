package com.mycompany.w2024062_planemanagement;

// seat 12B - seat 12, row B
// row A,B,C,D
// seat 1-12
public class Chair {
    private int seat;
    private int row;
    private PriceLevelEnum priceLevel;
    private boolean sold;
    private ExistsEnum exists;

    public PriceLevelEnum getPriceLevel() {
        return priceLevel;
    }

    public int getPrice() {
        switch (getPriceLevel()) {
            case PriceLevelEnum.firstClass:
                return 200;
            case PriceLevelEnum.business:
                return 180;
            case PriceLevelEnum.tourist:
                return 150;
        }
        return -1;
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
            throw new Exception("Seat is not available, can not buy a sold seat.");
        } else {
            this.sold = true;
        }
    }

    public void setAsAvailable() throws Exception {
        if (getExists() == ExistsEnum.notExists) {
            throw new Exception("Invalid seat");
        } else if (!getSold()) {
            throw new Exception("Seat is available, can not cancel an available seat.");
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

    public Chair(int seat, int row, PriceLevelEnum price, boolean sold, ExistsEnum exists) {
        this.seat = seat;
        this.row = row;
        this.priceLevel = price;
        this.sold = sold;
        this.exists = exists;
    }

    public String toString() {
        return "Chair " + (seat + 1) + getRow();
    }
}