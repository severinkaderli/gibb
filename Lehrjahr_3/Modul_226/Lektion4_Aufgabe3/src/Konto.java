/**
 * 
 * @author Severin Kaderli
 *
 */
public class Konto {
	private double saldo = 0;
	private double zinssatz;
	
	public Konto(double zinssatz) {
		this.zinssatz = zinssatz;
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
