package Extends.OsherAll;

public class UnionMember extends Employee {
    int yearsAsUnionMember;

    public UnionMember(int years, int yearsAsUnionMember) {
        super(years);
        this.yearsAsUnionMember = yearsAsUnionMember;
    }

    public String toString() {
        return "UnionMember " + years + " years";
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