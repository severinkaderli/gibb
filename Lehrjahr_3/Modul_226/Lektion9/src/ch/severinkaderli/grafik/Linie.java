package ch.severinkaderli.grafik;

import java.awt.Graphics;

/**
 * Eine Linie ist eine Grafik die zwischen zwei Punkten verbunden ist.
 * 
 * @author Severin Kaderli
 */
public class Linie extends Figur {

	/**
	 * Endposition der Linie auf der X-Achse
	 */
	private int x2;
	
	/**
	 * Endposition der Linie auf der Y-Achse
	 */
	private int y2;
	
	/**
	 * @param x
	 * @param y
	 * @param x2
	 * @param y2
	 */
	public Linie(int x, int y, int x2, int y2) {
		super(x, y);
		this.x2 = x2;
		this.y2 = y2;
	}
	
	/**
	 * Bewegt die Linie um dx und dy
	 * 
	 * @param dx Verschiebung auf der X-Achse
	 * @param dy Verschiebung auf der Y-Achse
	 */
	public void move(int dx, int dy) {
		x += dx;
		y += dy;
	}
	
	
	/* (non-Javadoc)
	 * @see ch.severinkaderli.grafik.Figur#zeichne(java.awt.Graphics)
	 */
	public void zeichne(Graphics g) {
		g.drawLine(this.x, this.y, this.x2, this.y2);
	}
}
