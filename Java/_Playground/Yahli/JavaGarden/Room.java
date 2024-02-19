package JavaGarden;

public class Room {
    public int roomNumber;
    public int roomType;
    public int nightsReserved;

    public Room(int roomNumber, int roomType, int nightsReserved) {
        this.roomNumber = roomNumber;
        this.roomType = roomType;
        this.nightsReserved = nightsReserved;
    }

    public int totalPrice() {
        int totalPrice = 0;

        if (roomNumber / 100 == 4)
            totalPrice += 40;

        if (roomType == 1)
            totalPrice += 100;
        else
            totalPrice += 160;

        totalPrice *= nightsReserved;

        return totalPrice;
    }
}