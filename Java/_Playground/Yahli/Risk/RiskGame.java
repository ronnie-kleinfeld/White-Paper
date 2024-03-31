package Risk;

public class RiskGame {
    public static void main(String[] args) {

    }

    private RiskPlayer[] players;
    private RiskCountry[] countries;

    public RiskGame(int playersCount) {
        players = new RiskPlayer[playersCount];
        countries = new RiskCountry[50];
    }

}