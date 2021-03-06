/**
 * 
 * @author Severin Kaderli
 *
 */
public class Konto {
	private double saldo = 0;
	private double zinssatz = 0.01;
	
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
