package figuren;

public class Test {

	public static void main(String[] args) {
		Linie l = new Linie(10, 20, 30, 40);
		l.move(10, 10);
		Figur f = new Linie(10, 20, 30, 40);
		f.move(20, 20);
	}

}
