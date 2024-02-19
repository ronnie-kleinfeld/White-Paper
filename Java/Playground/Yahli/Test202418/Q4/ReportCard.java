package Test202418.Q4;

public class ReportCard {
    public String stuName;
    public Subject[] subArray;

    public ReportCard(String name, int num) {
        this.stuName = name;
        this.subArray = new Subject[num];
    }

    public double average() {
        double sum = 0;
        for (int i = 0; i < subArray.length; i++) {
            sum += subArray[i].grade;
        }
        return sum / subArray.length;
    }

    public Boolean isExcellent() {
        return average() >= 85;
    }

    public static void printExcellent(ReportCard[] array) {
        for (int i = 0; i < array.length; i++) {
            if (array[i].isExcellent()) {
                System.out.println(array[i].stuName);
            }
        }
    }
}