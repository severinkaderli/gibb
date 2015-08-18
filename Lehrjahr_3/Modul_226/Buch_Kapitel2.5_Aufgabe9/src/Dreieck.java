//Author: Severin Kaderli
//Date: 18. August 2015
//Description: Prints out a triangle
public class Dreieck {

	private static final int triangleSize = 8;
	
	public static void main(String[] args) {
		for(int i=1;i<=triangleSize;i++){
			printTriangle(i);
		}
	}
	
	public static void printTriangle(int size) {
		for(int i=0;i<size;i++){
			System.out.print("*");
		}
		System.out.println("");
	}
}
