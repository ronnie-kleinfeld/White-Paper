import java.util.Scanner;

public class Progam {
	public static Scanner input = new Scanner(System.in); 
	
	// Q1a
	public static double sum2max(double price1, double price2, double price3) {
		return 0;
	}
	public static double booksInSale(double price1, double price2) {
		return Math.max(price2, price1) + 0.5 * Math.min(price1, price2);
	}
	// Q1b
	public static double totalPay(int numBooks) {
		double p1, p2;
		System.out.println("Enter first book full price:");
		p1 = input.nextDouble();
		System.out.println("Enter second book full price:");
		p2 = input.nextDouble();
		if (numBooks == 2)
			return booksInSale(p1, p2);
		else {
			double p3;
			System.out.println("Enter third book full price:");
			p3 = input.nextDouble();
			return sum2max(p1, p2, p3);
		}
			
	}
	// Q2a
	public static int mulDigits(int num) {
		int mul = 1, digit;
		while (num != 0) {
			digit = num % 10;
			if (digit != 0)
				mul = mul * digit;
			num = num / 10;
		}
		return mul;
	}
	// Q2b
	public static boolean isSpecial(int num) {
		return mulDigits(num) * 2 + num % 10 == num;
	}
	// Q2c
	public static void printSpecials() {
		int counter = 0;
		for(int num = 10; num < 1000; num++) {
			if (isSpecial(num))
				counter++;
		}
		System.out.println(counter);
	}
	// Q3a
	public static int newNum(int num, int digit) {
		return num * 10 + digit;
	}
	// Q3b
	public static int createNewNum(int firstDigit) {
		int digit, num = firstDigit;
		System.out.println("Enter a digit:");
		digit = input.nextInt();
		while (digit != 0 && digit != 9) {
			num = newNum(num, digit);
			System.out.println("Enter a digit:");
			digit = input.nextInt();
		}
		return newNum(num, digit);
	}
	public static void main(String[] args) {
		// Q1c
		int numBooks;
		for(int i = 0; i < 200; i++) {
			System.out.println("Enter number of books you want to buy:");
			numBooks = input.nextInt();
			System.out.println(totalPay(numBooks));
		}
		// Q3c
		int digit, num, counter = 0;
		for(int i = 0; i < 100; i++) {
			System.out.println("Enter a digit:");
			digit = input.nextInt();
			num = createNewNum(digit);
			System.out.println(num);
			if (num % 10 == 9)
				counter++;
		}
		System.out.println(counter);
	}

}
