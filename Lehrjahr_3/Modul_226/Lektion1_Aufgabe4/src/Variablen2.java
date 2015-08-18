/**
 * Author: Severin Kaderli
 * Date: 11. August 2015
 */
public class Variablen2 {

	public static void main(String[] args) {

		int a = 10, b = 3;
		double c = 3.0;
		float f = 9f;
		boolean x = true;
		byte n = 3;

		System.out.println(a * n);
		System.out.println(b * c);
		System.out.println(a / b);
		System.out.println(a / c);
		System.out.println((double) a / b);
		System.out.println((double) (a / b));
		System.out.println((int) (a / c));
		System.out.println(n * b == f);
		System.out.println((n << 1) + c > f);
		System.out.println(a / c * b == f);
		System.out.println(a / b * c == f);
		System.out.println(a & n * n);
		System.out.println(f > 9 && !x == true);
		System.out.println((a & n) <= c | x);
	}
}
