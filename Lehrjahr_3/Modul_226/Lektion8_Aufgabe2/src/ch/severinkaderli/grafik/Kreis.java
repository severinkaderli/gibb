package ch.severinkaderli.grafik;

import java.awt.Graphics;

/**
 * Diese Klasse stellt einen Kreis dar. Dazu wird der Radius
 * benötigt.
 * 
 * @author Severin Kaderli
 */

public class Kreis extends Figur {
	
	/**
	 * Radius des Kreises
	 */
	private int radius;
	
	/**
	 * @param x
	 * @param y
	 * @param radius
	 */
	public Kreis(int x, int y, int radius) {
		super(x, y);
		this.radius = radius;
	}
	
	/**
	 * @return
	 */
	public int getRadius() {
		return radius;
	}
	
	/* (non-Javadoc)
	 * @see ch.severinkaderli.grafik.Figur#zeichne(java.awt.Graphics)
	 */
	public void zeichne(Graphics g) {
		g.drawOval(x-radius, y-radius, radius*2, radius*2);
	}
}
