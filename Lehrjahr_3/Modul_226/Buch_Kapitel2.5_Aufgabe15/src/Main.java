//Author: Severin Kaderli
//Date: 18. August 2015
public class Main {

	public static void main(String[] args) {
		int p = 16;
		int q = 40;

		if (p < q) {
			int temp = p;
			p = q;
			q = temp;
		}

		while (q != 0) {
			int r = p % q;
			p = q;
			q = r;
		}

		System.out.println(p);

	}

}
