package Extends.OsherAll;

public class Employee {
    private int years;

    public Employee(int years) {
        this.years = years;
    }

    public int getYears() {
        return years;
    }

    public void setYears(int years) {
        this.years = years;
    }

    public String toString() {
        return "Employee " + years + " years";
    }

    public int getScore() {
        return years + 4;
    }

    public int getSalary() {
        return years * 500 + 5000;
    }

    public Boolean yearlyBonus() {
        if (years > 5) {
            return true;
        }
        return false;
    }
}