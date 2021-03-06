package ch.severinkaderli.snake;

import java.awt.Graphics;

/**
 * Diese Klasse stellt einen Diamant dar, welcher als Sammelobjekt von der
 * Schlange aufgefressen werden kann.
 * 
 * @author Severin Kaderli
 */
public class Diamond extends Entity {

	/**
	 * Wert des Diamanten
	 */
	protected int value;

	/**
	 * 
	 * @param x X-Position
	 * @param y Y-Position
	 * @param width Breite des Diamanten
	 * @param height H�he des Diamanten
	 * @param value Wert des Diamanten
	 */
	public Diamond(int x, int y, int width, int height, int value) {
		super(x, y, width, height);
		this.value = value;
	}

	/**
	 * Zeichnet den Diamanten und dessen Wert
	 * 
	 * @param g
	 *            Referenz auf Graphics object
	 */
	public void draw(Graphics g) {
		g.drawOval(position.x, position.y, position.width, position.height);
		// TODO: Get string drawing to the correct position.
		g.drawString(String.valueOf(value), position.x + 7, position.y + 15);
	}

}
