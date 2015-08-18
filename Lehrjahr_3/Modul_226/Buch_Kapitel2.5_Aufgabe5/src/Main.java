//Author: Severin Kaderli
//Date: 11. August 2015
//Description: Checks if x is divisible with y

public class Main {

	public static boolean isDevisible(int x, int y) {

		if (x % y == 0) {
			return true;
		}

		return false;
	}

	public static void main(String[] args) {
		System.out.println(isDevisible(50, 10));
		System.out.println(isDevisible(100, 9));
		System.out.println(isDevisible(25, 5));
		System.out.println(isDevisible(37, 3));
	}
}
