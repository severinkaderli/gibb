package ch.severinkaderli.snake;

import java.awt.Graphics;

public class Border extends Entity {

	/**
	 * 
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 */
	public Border(int x, int y, int width, int height) {
		super(x, y, width, height);
	}

	/**
	 * Zeichnet die Schlange auf das Feld.
	 */
	public void draw(Graphics g) {
		g.drawRect(position.x, position.y, position.width, position.height);
	}

}
