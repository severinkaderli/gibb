
public class Vogel extends Tier {
	
	private int anzahlFluegel;
	
	public Vogel(String name, int age, int anzahlFluegel) {
		super(name, age);
		this.anzahlFluegel = anzahlFluegel;
	}
	
	public void fly() {
		System.out.println("Hui... Ich habe " + anzahlFluegel + " Flügel!");
		
	}
}
