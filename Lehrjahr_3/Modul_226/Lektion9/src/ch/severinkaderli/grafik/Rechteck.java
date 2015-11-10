package ch.severinkaderli.grafik;

import java.awt.Graphics;

/**
 * @author vmadmin
 *
 */
public class Rechteck extends Figur {

	/**
	 * Breite des Rechtecks
	 */
	protected int width;
	
	/**
	 * Höhe des Rechtecks
	 */
	protected int height;
	
	/**
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 */
	public Rechteck(int x, int y, int width, int height) {
		super(x, y);
		this.width = width;
		this.height = height;
	}

	/**
	 * @return Breite des Rechtecks
	 */
	public int getWidth() {
		return width;
	}

	/**
	 * @return Höhe des Rechtecks
	 */
	public int getHeight() {
		return height;
	}

	/* (non-Javadoc)
	 * @see ch.severinkaderli.grafik.Figur#zeichne(java.awt.Graphics)
	 */
	public void zeichne(Graphics g) {
		
		g.drawRect(this.x, this.y, this.width, this.height);
	}
}
