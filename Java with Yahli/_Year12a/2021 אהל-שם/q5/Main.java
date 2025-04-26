public class Main {
    public static void main(String[] args) {
        Website site = new Website();

        site.AddMember("Alice");
        site.AddMember("Bob");

        Member alice = site.FindMember("Alice");
        Member bob = site.FindMember("Bob");

        // Add pets to Alice
        alice.AddPetName("Fluffy");
        alice.AddPetName("Fluffy");
        alice.AddPetName("Max");

        // Add pets to Bob
        bob.AddPetName("Max");
        bob.AddPetName("Max");
        bob.AddPetName("Fluffy");

        System.out.println("Before Swap:");
        printMemberPets(alice);
        printMemberPets(bob);

        // Perform Swap
        site.Swap("Alice", "Bob", "Fluffy", "Coco");

        System.out.println("\nAfter Swap:");
        printMemberPets(alice);
        printMemberPets(bob);
    }

    public static void printMemberPets(Member member) {
        System.out.print(member.GetUserName() + "'s pets: ");
        Node<String> current = member.pets;
        while (current != null) {
            System.out.print(current.getInfo() + " ");
            current = current.getNext();
        }
        System.out.println();
    }
}
