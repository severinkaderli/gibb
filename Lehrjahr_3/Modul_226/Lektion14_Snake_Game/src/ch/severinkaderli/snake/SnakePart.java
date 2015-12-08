package ch.severinkaderli.snake;

import java.awt.Color;
import java.awt.Graphics;

public class SnakePart extends Entity {
	
	/**
	 * Richtung des Schlangenteils.
	 */
	public Direction direction;
	
	/**
	 * Erstellt einen neuen SnakePart
	 * 
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 */
	public SnakePart(int x, int y, int width, int height, Direction direction) {
		super(x, y, width, height);
		this.direction = direction;
	}
	
	/**
	 * 
	 */
	public void draw(Graphics g) {
		g.setColor(Color.BLACK);
		g.fillRect(position.x, position.y, position.width, position.height);
	}
	
	public void move(int stepSize) {
		switch(this.direction) {
			default:
			case LEFT:
				position.x -= stepSize;
				break;
		
			case RIGHT:
				position.x += stepSize;
				break;
		
			case UP:
				position.y -= stepSize;
				break;
		
			case DOWN:
				position.y += stepSize;
				break;
		}
	}
	
	
}
