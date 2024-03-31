package Risk;

public class RiskCountry {
    private String cname;
    private int soldiers;

    public String getCname() {
        return cname;
    }

    public int getSoldiers() {
        return soldiers;
    }

    public RiskCountry(String cname, int soldiers) {
        this.cname = cname;
        this.soldiers = soldiers;
    }

    public RiskPlayer getOwner(RiskPlayer[] pl) {
        for (int i = 0; i < pl.length; i++) {
            RiskPlayer currentPlayer = pl[i];
            for (int j = 0; j < currentPlayer.getCountries().length; j++) {
                if (currentPlayer.getCountries()[j] != null && currentPlayer.getCountries()[j].getCname() == cname) {
                    return currentPlayer;
                }
            }
        }
        return null;
    }
}