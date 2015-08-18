//Author: Severin Kaderli
//Date: 18. August 2015
//Description: Prints out a stair with h height and b width
public class Stair {

	public static void main(String[] args) {
		int b = 3;
		int h = 10;

		for (int i = 1; i <= h; i++) {

			// Print spaces
			for (int j = 0; j < b * h - b * i; j++) {
				System.out.print(" ");
			}

			// Print stair
			for (int k = 0; k < b * i; k++) {
				System.out.print("*");
			}
			System.out.println("");
		}
	}
}