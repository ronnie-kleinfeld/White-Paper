package Extends.OsherAll;

public class Technician extends Employee {
    int computers;

    public Technician(int years, int computers) {
        super(years);
        this.computers = computers;
    }

    public int getComputers() {
        return computers;
    }

    public void setComputers(int computers) {
        this.computers = computers;
    }

    public String toString() {
        return "Technician " + years + " years, " + computers + " computers";
    }

    public int getScore() {
        return super.getScore() + computers * 4;
    }

    public int getSalary() {
        return super.getSalary() + (computers / 10) * 250;
    }

    @Override
    public Boolean yearlyBonus() {
        return super.yearlyBonus() && computers > 100;
    }
}