package ch.severinkaderli.snake;

import java.awt.Color;
import java.awt.Graphics;

public class Snake extends Entity {

	/**
	 * Die Richtung in die sich die Schlange momentan bewegt.
	 */
	private Direction direction = Direction.LEFT;

	/**
	 * Game Objekt zu welchem die Schlange dazu geh�rt.
	 */
	private Game game;

	/**
	 * Enum f�r die verschiedenen Richtungen, in die sich die Schlange bewegen
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
	 * Bewegt die Schlange �ber das Feld
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

		// Collision detection and score handling?
		game.getDiamonds().forEach((diamond) -> {
			if(position.intersects(diamond.position)) {
				game.setScore(game.getScore() + diamond.value);
				//Remove diamond
				System.out.println("Intersection");
			}
		});
	}
}
