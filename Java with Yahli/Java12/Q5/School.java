package Q5;

public class School {
    private Node<Student>[] ar;

    public School() {
        ar = new Node[12];
    }

    public Node<Student>[] getAr() {
        return ar;
    }

    public void setAr(Node<Student>[] ar) {
        this.ar = ar;
    }
}
