package com.mycompany.w2024062_planemanagement;

public class W2024062_PlaneManagement {
    public static void main(String[] args) {
        try {
            PlaneManagement planeManagement = new PlaneManagement();
            planeManagement.start();
        } catch (Exception e) {
            ConsoleHelper.printlnRed(e.getMessage());
        }
    }
}