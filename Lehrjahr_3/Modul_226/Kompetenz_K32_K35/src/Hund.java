
public class Hund {
	private int alter;
	private String rasse;
	
	public Hund(int alter, String rasse) {
		this.alter = alter;
		this.rasse = rasse;
	}
	
	public void bellen() {
		System.out.println("Wuff! Ich bin ein Hund der Rasse " + rasse + " und bin " + alter + " Jahre alt.");
	}
}
