package Extends.OsherAll;

public class Company {
    Employee[] employees;
    int current;
    final static int MAX = 100;

    public Company() {
        employees = new Employee[MAX];
        current = 0;
    }

    public Boolean addEmployee(Employee employee) {
        if (current < MAX) {
            employees[current] = employee;
            current++;
            return true;
        }
        return false;
    }

    public int totalSalary() {
        int total = 0;
        for (int i = 0; i < current; i++) {
            total += employees[i].getSalary();
        }
        return total;
    }

    public static Boolean isAccepted(Employee[] employees) {
        int yay = 0;
        for (Employee employee : employees) {
            if (employee instanceof Employee || employee instanceof Technician) {
                yay++;
            }
        }
        return yay > employees.length / 2;
    }
}