public class ObserverTest {

	public static void main(String[] args) {
		Fernseher tv = new Fernseher("Sport-Kanal");
		Zuschauer bob = new Zuschauer("Bob");
		Zuschauer hans = new Zuschauer("Hans");

		tv.addObserver(bob);
		tv.addObserver(hans);

		tv.changeChannel("SRF1");
	}

}
