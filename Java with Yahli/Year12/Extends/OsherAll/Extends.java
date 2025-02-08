package Extends.OsherAll;

public class Extends {
    public static void main(String[] args) {
        Company company = new Company();
        Employee employee1 = new Employee(5);
        employee1.setYears(4);
        Employee employee2 = new Employee(10);

        UnionMember unionMember = new UnionMember(7, 8);

        Technician technician = new Technician(3, 4);

        Supervisior supervisior = new Supervisior(9);

        company.addEmployee(employee1);
        company.addEmployee(employee2);
        company.addEmployee(unionMember);
        company.addEmployee(technician);
        company.addEmployee(supervisior);

        System.out.println(company.totalSalary());
        System.out.println(Company.isAccepted(company.employees));
    }
}
