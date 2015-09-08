public class TestTier {

	public static void main(String[] args) {
		Tier elephant = new Tier("Eli", 70);
		elephant.greet();
		
		Vogel vogel = new Vogel("Bird", 10, 2);
		vogel.greet();
		vogel.fly();
		
		Fisch fisch = new Fisch("Fisch", 5, 4);
		fisch.greet();
		fisch.swim();
	}
}
