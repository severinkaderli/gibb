/**
 * 
 * @author Severin Kaderli
 *
 */
public class Kunde {
	private String name;
	private String vorname;
	private int kundennr;
	
	public Kunde(String name, String vorname, int kundennr) {
		this.name = name;
		this.vorname = vorname;
		this.kundennr = kundennr;
	}
	
	public String getName() {
		return name;
	}
	
	public String getVorname() {
		return vorname;
	}
	
	public int getKundennr() {
		return kundennr;
	}
}
