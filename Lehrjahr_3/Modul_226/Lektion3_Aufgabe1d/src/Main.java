
//Author: Severin Kaderli
//Date: 25. August 2015
//Description: Calculates pi
public class Main {
	
	public static void main(String[] args) {
		
		//Create array and calculate difference to Math.PI
		double[][] results = new double[8][2];	
		for(int i=1;i<=8;i++) {
			results[i-1][0] = calculatePi((int) Math.pow(10, i));
			results[i-1][1] = Math.PI - calculatePi((int) Math.pow(10, i));
		}
		
		//Print out array
		System.out.println("Schritte \t| PI\t\t\t| Differenz zu Math.PI");
		for(int i = 0;i<results.length;i++) {
			System.out.println("10^" + (i+1) + "\t\t| " + results[i][0] + "\t| " + results[i][1]);
		}
	}
	
	private static double calculatePi(int steps) {
		double pi = 0;
		double divider = 1;
		
		//Pi/4 = 1/1 - 1/3 + 1/5...
		for(int i = 0; i<steps;i++){
			if(i % 2 == 0){
				pi = pi + (1/divider);
			} else {
				pi = pi - (1/divider);
			}
			divider = divider + 2;
		}
		pi = pi*4;
		return pi;
	}
}
