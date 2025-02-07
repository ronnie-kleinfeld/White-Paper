import java.util.Scanner;
public class Exam3 {
	public static Scanner input = new Scanner(System.in);
	public static void q1() {
		int students, exam1, exam2, counter = 0, sum = 0;
		System.out.println("Enter number of students");
		students = input.nextInt();
		for(int i = 0; i < students; i++) {
			System.out.println("Enter first exam grade");
			exam1 = input.nextInt();
			System.out.println("Enter second exam grade");
			exam2 = input.nextInt();
			if (exam2 > exam1 * 1.1) {
				counter++;
				exam1 += 5;
			}
			sum += exam1;
		}
		System.out.println("Number of students exceeded the bouns: " + counter);
		System.out.println("First exam average is " + ((double)sum / students));
	}
	public static void q2() {
		int num, lsd, msd;
		System.out.println("Enter a number");
		num = input.nextInt();
		lsd = num % 10;
		msd = num;
		while(msd > 9)
			msd /= 10;
		if (lsd == msd)
			System.out.println(num + " is a friendly number");
		else
			System.out.println(num + " is NOT a friendly number");
		
	}
	public static void q4() {
		int maxScoutCamp = 0;	// max scouts number who are going to summer camp
		int maxAgeGroup = 0;
		int totalScoutCamp = 0;
		char answer;
		for(int ageGroup = 3; ageGroup <= 9; ageGroup++) {
			int counterScouts = 0;
			System.out.println("Enter acout answer:");
			answer = input.next().charAt(0);
			while(answer != 'F') {
				if (answer == 'Y')
					counterScouts++;
				System.out.println("Enter acout answer:");
				answer = input.next().charAt(0);				
			}
			totalScoutCamp += counterScouts;
			if (counterScouts > maxScoutCamp) {
				maxScoutCamp = counterScouts;
				maxAgeGroup = ageGroup;
			}
		}
		System.out.println("Total scouts attending summer camp is " + totalScoutCamp);
		System.out.println("Most attending to summer camp is from age group number " + maxAgeGroup);
	}

	
	public static void main(String[] args) {
		q1();
		q2();
		q4();
	}

}
