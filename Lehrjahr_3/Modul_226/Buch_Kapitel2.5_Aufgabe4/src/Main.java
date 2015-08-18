/**
 * Author: Severin Kaderli
 * Date: 11. August 2015
 */
public class Main {
	public static void calculateBoxes(int bottles, int bottlesPerBox) {
		int boxes = bottles / bottlesPerBox;
		int leftBottles = bottles % bottlesPerBox;
		
		System.out.println("Anzahl Kartons: " + boxes);
		System.out.println("Übrige Flaschen: " + leftBottles);
	}
	
	public static void main(String[] args) {
		calculateBoxes(45, 6);
	}
}
