package JavaGarden;

public class JavaGardern {
    public static void main(String[] args) {
        System.out.println(new Room(163, 1, 0).totalPrice());
        System.out.println(new Room(163, 1, 1).totalPrice());
        System.out.println(new Room(163, 1, 2).totalPrice());
        System.out.println(new Room(163, 2, 0).totalPrice());
        System.out.println(new Room(163, 2, 1).totalPrice());
        System.out.println(new Room(163, 2, 2).totalPrice());

        System.out.println(new Room(421, 1, 0).totalPrice());
        System.out.println(new Room(421, 1, 1).totalPrice());
        System.out.println(new Room(421, 1, 2).totalPrice());
        System.out.println(new Room(421, 2, 0).totalPrice());
        System.out.println(new Room(421, 2, 1).totalPrice());
        System.out.println(new Room(421, 2, 2).totalPrice());
    }

    public static Room[] getBookedRooms(Room[] rooms, int price, int floor) {
        Room[] temp = new Room[rooms.length];
        int counter = 0;
        for (int i = 0; i < rooms.length; i++) {
            Room room = rooms[i];
            if (room.roomNumber / 100 == floor && room.totalPrice() < price) {
                temp[counter] = room;
                counter++;
            }
        }

        Room[] result = new Room[counter];
        for (int i = 0; i < counter; i++) {
            result[i] = temp[i];
        }

        return result;
    }
}