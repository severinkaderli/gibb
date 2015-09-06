/**
 * 
 * @author Severin Kaderli
 *
 */
public class TestKonto {

	public static void main(String[] args) {
		Konto k1 = new Konto();
		Konto k2 = new Konto();
		
		k1.einzahlen(2.50);
		k1.einzahlen(5);
		System.out.println(k1.getSaldo());
		k1.verzinsen(365);
		System.out.println(k1.getSaldo());

		k2.einzahlen(5.50);
		k2.einzahlen(25);
		System.out.println(k2.getSaldo());
		k2.verzinsen(200);
		System.out.println(k2.getSaldo());
	}
}
