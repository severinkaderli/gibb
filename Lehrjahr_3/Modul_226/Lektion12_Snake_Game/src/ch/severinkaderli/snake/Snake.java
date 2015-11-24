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
	 * Die Richtung in die sich die Schlange momentan bewegt.
	 */
	//private Direction direction = Direction.LEFT;
	
	/**
	 * Breite und Höhe der einzelnen Schlangenteile.
	 */
	private final int BODY_SIZE = 10;
	
	/**
	 * Liste, die die einzelnen Teile der Schlange enthält
	 */
	public List<SnakePart> body = new ArrayList<SnakePart>();
	
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
		
		//Add first (head) part
		head = new SnakePart(x, y, BODY_SIZE, BODY_SIZE, Direction.LEFT);
		body.add(new SnakePart(x+BODY_SIZE, y, BODY_SIZE, BODY_SIZE, Direction.LEFT));
		body.add(new SnakePart(x+BODY_SIZE*2, y, BODY_SIZE, BODY_SIZE, Direction.LEFT));
		body.add(new SnakePart(x+BODY_SIZE*3, y, BODY_SIZE, BODY_SIZE, Direction.LEFT));
		
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
	public void setDirection(Direction direction) {
		
		head.direction = direction;
		
		System.out.println("Changed direction");
	}


	/**
	 * Bewegt die Schlange über das Feld
	 * 
	 * @param steps
	 */
	public void move(int stepSize) {
		
		SnakePart oldHead = head;
		head = body.remove(body.size()-1);
		body.add(0, oldHead);
		head.direction = oldHead.direction;
		
		switch(head.direction) {
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
	 * Überprüft Kollisionen
	 */
	public void checkCollision() {

		/*// Collision detection with the Snake
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
		}*/
	}
}
