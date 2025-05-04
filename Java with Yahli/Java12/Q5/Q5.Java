public class Q5 {
    public static void main(String[] args) {
        public static Node<Student> q5(School school) {
            Node<Student>[] result = new Node<Student>[12];

            School temp = school.Clone();

            for (int i = 0; i < temp.length; i++) {
                Node<Student> level = temp[i];

                while (level != null) {
                    Node<Student> student = level.getValue();
                    Birth birth = student.getBirthDay();
                    int month = birth.getMonth();

                    insertAtTail(result[month - 1], student);

                    level = level.getNext();
                }
            }

            return result;
        }

        private static <T> Node<T> insertAtTail(Node<T> head, T value) {
            Node<T> newNode = new Node<>(value);
            if (head == null) {
                return newNode;
            }
            Node<T> current = head;
            while (current.getNext() != null) {
                current = current.getNext();
            }
            current.setNext(newNode);
            return head;
        }
    }
}