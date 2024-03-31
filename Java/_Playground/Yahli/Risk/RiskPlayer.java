package Risk;

public class RiskPlayer {
    private String pname;
    private RiskCountry[] countries = new RiskCountry[10];

    public String getPname() {
        return pname;
    }

    public RiskCountry[] getCountries() {
        return countries;
    }

    public RiskPlayer(String pname, RiskCountry[] countries) {
        this.pname = pname;
        this.countries = countries;
    }

    public boolean hasCountry(String cname) {
        for (int i = 0; i < countries.length; i++) {
            if (countries[i] != null && countries[i].getCname() == cname) {
                return true;
            }
        }
        return false;
    }
}