/**
 * Name: Kaderli Severin
 * Klasse: 2013.5k
 * Datum: 8. September 2015
 * Serie A
 *
 */
public class MusterMaster {

	public static void main(String[] args) {
		muster(4, 3);
		System.out.println("");
		muster(3, 4);

	}

	public static void muster(int breite, int hoehe) {

		for (int i = 0; i < hoehe; i++) {

			// Print plusminus
			if (i > 0) {

				for (int j = 0; j < breite; j++) {
					if (j > 0) {
						System.out.print("+");
					}
					System.out.print("-");
				}
				System.out.println("");
			}

			// Print pipes
			for (int j = 0; j < breite; j++) {
				if (j > 0) {
					System.out.print("|");
				}
				System.out.print(" ");
			}

			System.out.println("");
		}
	}

}
