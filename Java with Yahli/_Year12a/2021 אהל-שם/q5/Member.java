public class Member {
    private String userName;
    private Node<String> pets;

    public Member(String userName) {
        this.userName = userName;
        this.pets = null;
    }

    public String GetUserName() {
        return userName;
    }

    public void AddPetName(String pn) {
        Node<String> newNode = new Node<>(pn);
        newNode.setNext(pets);
        pets = newNode;
    }

    public void Change(String pn, String p1, String p2) {
        int count = 0;
        Node<String> curr = pets;

        while (curr != null) {
            if (curr.getInfo().equals(pn)) {
                count++;
            }
            curr = curr.getNext();
        }

        curr = pets;
        while (curr != null) {
            if (curr.getInfo().equals(pn)) {
                if (count % 2 == 0) {
                    curr.setInfo(p1);
                } else {
                    curr.setInfo(p2);
                }
            }
            curr = curr.getNext();
        }
    }
}
