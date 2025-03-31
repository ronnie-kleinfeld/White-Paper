package Extends.OsherAll;

public class UnionMember extends Employee {
    private int yearsAsUnionMember;

    public UnionMember(int years, int yearsAsUnionMember) {
        super(years);
        this.yearsAsUnionMember = yearsAsUnionMember;
    }

    public String toString() {
        return "UnionMember " + getYears() + " years";
    }

    public int getScore() {
        return super.getScore() * 2 + yearsAsUnionMember * 2;
    }

    public int getSalary() {
        return super.getSalary();
    }

    @Override
    public Boolean yearlyBonus() {
        return false;
    }
}