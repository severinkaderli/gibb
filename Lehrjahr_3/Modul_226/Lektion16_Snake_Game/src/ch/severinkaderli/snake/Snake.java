package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

/**
 * 
 * @author Severin Kaderli
 */
public class Snake {

	/**
	 * Breite und Höhe der einzelnen Schlangenteile.
	 */
	private final int BODY_SIZE = 10;

	/**
	 * Liste, die die einzelnen Teile der Schlange enthält
	 */
	public List<SnakePart> body = new ArrayList<SnakePart>();

	/**
	 * Kopf der Schlange
	 */
	public SnakePart head;

	/**
	 * Game Objekt zu welchem die Schlange dazu gehört.
	 */
	private Game game;

	/**
	 * 
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 */
	public Snake(int x, int y, Game game) {

		// Add first (head) part
		head = new SnakePart(x, y, BODY_SIZE, BODY_SIZE, Direction.LEFT);
		body.add(new SnakePart(x + BODY_SIZE, y, BODY_SIZE, BODY_SIZE, Direction.LEFT));

		this.game = game;
	}

	/**
	 * Zeichnet die Schlange auf das Feld.
	 */
	public void draw(Graphics g) {
		head.draw(g);
		body.forEach(part -> part.draw(g));
	}

	/**
	 * Setzt die aktuelle Richtung der Schlange.
	 * 
	 * @param direction
	 */
	public void changeDirection(Direction direction) {

		// Check if you're allowed to go in the direction, i.e. turning left
		// while you move right
		if (!(head.direction == Direction.LEFT && direction == Direction.RIGHT)
				&& !(head.direction == Direction.RIGHT && direction == Direction.LEFT)
				&& !(head.direction == Direction.UP && direction == Direction.DOWN)
				&& !(head.direction == Direction.DOWN && direction == Direction.UP)) {
			head.direction = direction;
		}

	}

	/**
	 * Bewegt die Schlange über das Feld
	 * 
	 */
	public void move() {

		// Put last body part to head position
		SnakePart oldHead = head;
		head = body.remove(body.size() - 1);
		body.add(0, oldHead);
		head.direction = oldHead.direction;

		switch (head.direction) {
		default:
		case LEFT:
			head.position.x = oldHead.position.x - BODY_SIZE;
			head.position.y = oldHead.position.y;
			break;
		case RIGHT:
			head.position.x = oldHead.position.x + BODY_SIZE;
			head.position.y = oldHead.position.y;
			break;
		case UP:
			head.position.x = oldHead.position.x;
			head.position.y = oldHead.position.y - BODY_SIZE;
			break;
		case DOWN:
			head.position.x = oldHead.position.x;
			head.position.y = oldHead.position.y + BODY_SIZE;
			break;
		}

	}

	/**
	 * Lässt die Schlange um ein Teil wachsen
	 * 
	 * @param size
	 */
	public void grow() {
		// Put x new body parts at the end of the snake
		SnakePart lastPart = body.get(body.size() - 1);
		SnakePart newPart;
		switch (lastPart.direction) {
		default:
		case LEFT:
			newPart = new SnakePart(lastPart.position.x + BODY_SIZE, lastPart.position.y, BODY_SIZE, BODY_SIZE,
					Direction.LEFT);
			break;
		case RIGHT:
			newPart = new SnakePart(lastPart.position.x - BODY_SIZE, lastPart.position.y, BODY_SIZE, BODY_SIZE,
					Direction.RIGHT);
			break;
		case UP:
			newPart = new SnakePart(lastPart.position.x, lastPart.position.y + BODY_SIZE, BODY_SIZE, BODY_SIZE,
					Direction.UP);
			break;
		case DOWN:
			newPart = new SnakePart(lastPart.position.x, lastPart.position.y - BODY_SIZE, BODY_SIZE, BODY_SIZE,
					Direction.DOWN);
			break;
		}

		body.add(newPart);
	}

	/**
	 * Überprüft Kollisionen
	 */
	public void checkCollision() {

		// Collision with diamonds
		game.getDiamonds().forEach((diamond) -> {
			if (diamond.isAlive) {
				if (head.position.intersects(diamond.position)) {

					game.setScore(game.getScore() + diamond.value);
					for (int i = 0; i < diamond.value; i++) {
						grow();
					}
					// Remove diamond
					diamond.destroy();
				}
			}
		});

		// Collision with snakes
		// TODO: Make this code better
		game.snake.body.forEach((part) -> {
			if (this.head.position.intersects(part.position)) {
				game.end();
			}
		});
		
		game.snake2.body.forEach((part) -> {
			if (this.head.position.intersects(part.position)) {
				game.end();
			}
		});

		// Collision with the border
		if (!head.position.intersects(game.border.position)) {
			game.end();
			System.out.println("Out of area");
		}

	}
}
