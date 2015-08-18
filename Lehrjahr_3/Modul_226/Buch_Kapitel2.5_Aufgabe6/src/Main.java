//Author: Severin Kaderli
//Date: 11. August 2015
//Description: Calculates the time from now in x hours
public class Main {

	public static void calculateTime(int now, int hours) {

		int newTime;

		if (now + hours > 24) {
			newTime = now + hours - 24;
		} else {
			newTime = now + hours;
		}

		System.out.println("Aktuelle Zeit: " + now + "Uhr");
		System.out.println("Zeit in " + hours + "h: " + newTime + "Uhr");
		System.out.println("");
	}

	public static void main(String[] args) {
		calculateTime(12, 6);
		calculateTime(6, 3);
		calculateTime(18, 7);

	}

}
