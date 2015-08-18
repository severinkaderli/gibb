//Author: Severin Kaderli
//Date: 18. August 2015
//Description: Calculator

public class Main {

	public static void main(String[] args) {

		try {
			System.out.println(calc(2, 4, 1));
			System.out.println(calc(5, 4, 2));
			System.out.println(calc(10, 4, 3));
			System.out.println(calc(30, 5, 4));
			System.out.println(calc(45, 7, 5));
			System.out.println(calc(2, 4, 6));
		} catch (IllegalArgumentException e) {
			System.out.println(e);
		}

	}

	public static int calc(int x, int y, int operator) throws IllegalArgumentException {

		switch (operator) {
		case 1:
			return x + y;
		case 2:
			return x - y;
		case 3:
			return x * y;
		case 4:
			return x / y;
		case 5:
			return x % y;

		default:
			throw new IllegalArgumentException("Ungültiger Operator angegeben");
		}
	}

}
