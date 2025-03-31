package Extends.OsherAll;

public class Supervisior extends Employee {
    private Employee[] employees;

    public Supervisior(int years) {
        super(years);
        this.employees = new Employee[15];
    }

    public Employee[] getEmployees() {
        return employees;
    }

    public void setEmployees(Employee[] employees) {
        this.employees = employees;
    }

    public String toString() {
        return "Supervisior " + getYears() + " years, " + employees.length + " employees";
    }

    public int getScore() {
        int score = super.getScore();
        for (Employee employee : employees) {
            score += employee.getScore();
        }
        return score;
    }

    public int getSalary() {
        int salary = super.getSalary();
        for (Employee employee : employees) {
            if (employee instanceof Technician) {
                salary += 100;
            } else if (employee instanceof UnionMember) {
                salary += 50;
            }
        }
        return salary;
    }

    @Override
    public Boolean yearlyBonus() {
        return false;
    }
}