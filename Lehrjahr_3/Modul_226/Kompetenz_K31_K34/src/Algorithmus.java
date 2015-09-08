
public class Algorithmus {

	public static void main(String[] args) {
		System.out.println(ggt(81, 9));

	}
	
	public static int ggt(int a, int b) {
		if(b == 0) {
			return a;
		} else {
			return ggt(b, a % b);
		}
	}

}
