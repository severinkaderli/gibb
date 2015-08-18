//Author: Severin Kaderli
//Date: 18. August 2015
//Description: Calculator with input
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		// Open scanner
		Scanner scanner = new Scanner(System.in);

		// Get user inputs
		System.out.println("Please enter the first number:");
		int x = scanner.nextInt();

		System.out.println("Please enter the second number:");
		int y = scanner.nextInt();

		System.out.println("Please enter the operator.");
		System.out.println("1 = Addition");
		System.out.println("2 = Subtraction");
		System.out.println("3 = Multiplication");
		System.out.println("4 = Division");
		System.out.println("5 = Modulo");
		int operator = scanner.nextInt();

		// Close scanner
		scanner.close();

		// Calculate the result
		try {
			System.out.println("Die Lösung der Rechnung ist: "
					+ calc(x, y, operator));
		} catch (IllegalArgumentException e) {
			System.out.println(e);
		}
	}

	private static int calc(int x, int y, int operator)
			throws IllegalArgumentException {

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
