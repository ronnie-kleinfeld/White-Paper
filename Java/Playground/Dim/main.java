package clockProject;

import java.util.Random;

public class main {

	public static void main(String[] args) {
		/*Clock c1 = new Clock(5,10);
		Clock c2 = new Clock(5,30);
		c1.setMinutes(15);
		c1.setHours(3);
		c1.add(35);
		c2.subtract(10);
		System.out.println(c1.equals(c2));
		System.out.println(c1.minutesToMidNights());
		System.out.println(c1.isEarlierThan(c2));
		System.out.println(c1.toString());
		System.out.println(c2.toString());*/
	
		
		Clock[] clock2 = buildArray(8,12,45,15);
		print(clock2);
	}
	public static void print(Clock[] arr) {
		System.out.print("[");
		for (int i = 0; i < arr.length-1;i++)
			System.out.print(arr[i] + ", ");
		if(arr.length > 0)
			System.out.print(arr[arr.length-1]);
		System.out.print("]");
	}
	static Clock[] buildRandomArray(int len) {
		Random rnd = new Random();
		Clock[] clocks = new Clock[len];
		for(int i=0;i<clocks.length;i++) {
			int hours=rnd.nextInt(24);
			int minutes=rnd.nextInt(60);
			clocks[i] = new Clock(hours, minutes);
		}
		return clocks;
	}
	static Clock[] buildArray(int len,int hours,int minutes,int add) {
		Clock[] arr = new Clock[len];
		arr[0] = new Clock(hours,minutes);
		for(int i=1; i<arr.length;i++) {
			arr[i] = new Clock(arr[i-1]);
			arr[i].add(add);
			}
		return arr;
	}

}