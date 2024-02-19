import java.lang.invoke.StringConcatException;

public class Forecast {
    public static void main(String[] args) {
        Forecast forecast = new Forecast(
                "Valnord",
                new int[] { 1, 5, 4, 5, 8, 5, 6, 1, -5, 2 },
                true);
        System.out.println(forecast.Q2(5, 3));
        System.out.println(forecast.Q3());
    }

    private String name;
    private int[] dailyTemp;
    private boolean hasSnow;

    public Forecast(String name, int[] dailyTemp, boolean hasSnow) {
        this.name = name;
        this.dailyTemp = dailyTemp;
        this.hasSnow = hasSnow;
    }

    public boolean Q2(int minTemp, int num) {
        boolean result = false;

        int counter = 0;
        for (int i = 0; i < dailyTemp.length; i++) {
            int currentTemp = dailyTemp[i];
            if (currentTemp >= minTemp) {
                counter++;
                if (counter > num)
                    return true;
            } else {
                counter = 0;
            }
        }

        return result;
    }

    public boolean Q3() {
        boolean result = false;

        result = Q2(-10, 4);
        result = result & hasSnow;

        return result;
    }
}