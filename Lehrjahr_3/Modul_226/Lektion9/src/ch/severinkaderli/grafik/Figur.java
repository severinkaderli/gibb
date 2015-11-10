package ch.severinkaderli.grafik;

import java.awt.Graphics;

import javax.naming.directory.InvalidAttributesException;

/**
 * Die Klasse Figur dient als Erbgrundlage für alle anderen Figuren.
 * Sie wird nie selber initalisiert.
 * 
 * @author Severin Kaderli
 */
abstract public class Figur {
	/**
	 * X-Position der Figur
	 */
	protected int x;
	
	/**
	 * Y-Position der Figur
	 */
	protected int y;
	
	/**
	 * @param x X-Position der Figur
	 * @param y Y-Position der Figur
	 */
	public Figur(int x, int y) {
		this.x = x;
		this.y = y;
	}

	/**
	 * Bewegt die Figur um dx und dy
	 * 
	 * @param dx
	 * @param dy
	 */
	public void move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	
	/**
	 * Zeichnet die Figur mithilfe der Graphics-Klasse
	 * 
	 * @param g
	 */
	abstract public void zeichne(Graphics g);

}
