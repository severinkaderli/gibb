package ch.severinkaderli.snake;

import java.awt.Color;
import java.awt.Graphics;

/**
 * 
 * @author Severin Kaderli
 */
public class Snake extends Entity {

	/**
	 * Die Richtung in die sich die Schlange momentan bewegt.
	 */
	private Direction direction = Direction.LEFT;

	/**
	 * Game Objekt zu welchem die Schlange dazu gehört.
	 */
	private Game game;

	/**
	 * Enum für die verschiedenen Richtungen, in die sich die Schlange bewegen
	 * kann.
	 */
	enum Direction {
		UP, DOWN, LEFT, RIGHT
	}

	/**
	 * 
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 */
	public Snake(int x, int y, int width, int height, Game game) {
		super(x, y, width, height);
		this.game = game;
	}

	/**
	 * Zeichnet die Schlange auf das Feld.
	 */
	public void draw(Graphics g) {
		g.setColor(Color.BLACK);
		g.fillRect(position.x, position.y, position.width, position.height);
	}

	/**
	 * Setzt die aktuelle Richtung der Schlange.
	 * 
	 * @param direction
	 */
	public void setDirection(Direction direction) {
		this.direction = direction;
	}

	/**
	 * Returns the current direction
	 * 
	 * @return
	 */
	public Direction getDirection() {

		return this.direction;
	}

	/**
	 * Bewegt die Schlange über das Feld
	 * 
	 * @param steps
	 */
	public void move(int stepSize) {
		// Move in direction
		switch (direction) {

		// TODO: Realise moving with single body parts, to get correct movements
		// around edges
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

	/**
	 * Überprüft Kollisionen
	 */
	public void checkCollision() {

		// Collision detection with the Snake
		game.getDiamonds().forEach((diamond) -> {
			if (diamond.isAlive) {
				if (position.intersects(diamond.position)) {

					game.setScore(game.getScore() + diamond.value);

					// Remove diamond
					diamond.destroy();
				}
			}
		});
		
		//Collision with the border
		if(!position.intersects(game.border.position)) {
			game.end();
			System.out.println("Out of area");
		}
	}
}
