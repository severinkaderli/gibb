
public class Fisch extends Tier {
	
	private int anzahlFlossen;
	
	public Fisch(String name, int age, int anzahlFlossen) {
		super(name, age);
		this.anzahlFlossen = anzahlFlossen;
	}
	
	public void swim() {
		System.out.println("Blub. Ich schwimme mit meinen " + anzahlFlossen + " Flossen.");
	}
}
