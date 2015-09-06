/**
 * 
 * @author Severin Kaderli
 *
 */
public class Konto {
	private double saldo = 0;
	private double zinssatz;
	private Kunde inhaber;
	
	public Konto(double zinssatz, Kunde inhaber) {
		this.zinssatz = zinssatz;
		this.inhaber = inhaber;
	}
	
	public void einzahlen(double betrag) {
		saldo += betrag;
	}
	
	public void verzinsen(int timeInDays) {
		saldo += saldo * zinssatz * timeInDays / 365;
	}
	
	public double getSaldo() {
		
		return saldo;
	}
}
