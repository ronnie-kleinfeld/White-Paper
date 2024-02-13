public class BusStation {
    private int stationId;
    private String streetName;
    private int[] busNumbers;
    private static int stationsCount = 0;

    public BusStation(String streetName, int[] busNumbers) {
        this.stationId = stationsCount;
        this.streetName = streetName;
        this.busNumbers = busNumbers;
        stationsCount++;
    }
}