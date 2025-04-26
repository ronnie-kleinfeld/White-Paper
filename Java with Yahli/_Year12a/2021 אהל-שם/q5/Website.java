public class Website {
    private Node<Member> members;

    public Website() {
        this.members = null;
    }

    public void AddMember(String un) {
        Member m = new Member(un);
        Node<Member> newNode = new Node<>(m);
        newNode.setNext(members);
        members = newNode;
    }

    public Member FindMember(String un) {
        Node<Member> curr = members;
        while (curr != null) {
            if (curr.getInfo().GetUserName().equals(un)) {
                return curr.getInfo();
            }
            curr = curr.getNext();
        }
        return null;
    }

    public void Swap(String A, String B, String p1, String p2) {
        Member mA = FindMember(A);
        Member mB = FindMember(B);

        if (mA != null) {
            mA.Change(p1, p2, p1);
        }
        if (mB != null) {
            mB.Change(p2, p1, p2);
        }
    }
}
