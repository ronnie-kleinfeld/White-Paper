package Q32018;

public class Time {
    public int hour;
    public int minute;

    public Time(int hour, int minute) {
        if (hour < 0 || hour > 23)
            this.hour = 0;
        else
            this.hour = hour;

        if (minute < 0 || minute > 59)
            this.minute = minute;
        else
            this.minute = minute;
    }
}