package Extend;

class GuardDog extends Dog {
    private String dutyArea;
    private boolean isOnDuty;

    public GuardDog(String name, int age, String dutyArea, boolean isOnDuty) {
        super(name, age);
        this.dutyArea = dutyArea;
        this.isOnDuty = isOnDuty;
    }

    public void guard() {
        System.out.println(getName() + " is guarding the " + dutyArea + ".");
    }

    public String getDutyArea() {
        return dutyArea;
    }

    public boolean isOnDuty() {
        return isOnDuty;
    }
}
