//Author: Severin Kaderli
//Date: 18. August 2015
//Description: Find the next highest power of 2 of n
public class Potenz {
	
	public static void main(String[] args) {
		findPower(4);
		findPower(16);
		findPower(55);
		findPower(-4);
		findPower(849320324);
	}
	
	public static void findPower(int n) {
		int i = 0;
		while(true) {
			if(Math.pow(2, i) >= n) {
				System.out.println("X = " + n + "; Nächste Zweierpotenz: 2^" + i + " = " + (int)Math.pow(2, i));
				return;
			}
			i++;
		}
	}

}
