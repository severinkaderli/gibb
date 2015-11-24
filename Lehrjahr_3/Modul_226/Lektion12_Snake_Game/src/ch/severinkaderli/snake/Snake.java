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
	 * Breite und H�he der einzelnen Schlangenteile.
	 */
	private final int BODY_SIZE = 10;
	
	/**
	 * Liste, die die einzelnen Teile der Schlange enth�lt
	 */
	public List<SnakePart> body = new ArrayList<SnakePart>();
	
	public SnakePart head;

	/**
	 * Game Objekt zu welchem die Schlange dazu geh�rt.
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
		body.add(new SnakePart(x+BODY_SIZE*4, y, BODY_SIZE, BODY_SIZE, Direction.LEFT));
		
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
		head.direction = direction;
	}


	/**
	 * Bewegt die Schlange �ber das Feld
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
	 * �berpr�ft Kollisionen
	 */
	public void checkCollision() {


			
			//Collision with diamonds
			game.getDiamonds().forEach((diamond) -> {
				if (diamond.isAlive) {
					if (head.position.intersects(diamond.position)) {

						game.setScore(game.getScore() + diamond.value);

						// Remove diamond
						diamond.destroy();
					}
				}
			});
			
			//Collision with itself
			body.forEach((part) -> {
				if(head.position.intersects(part.position)) {
					game.end();
					System.out.println("Touch itself");
				}
			
			});
				
			//Collision with the border
			if(!head.position.intersects(game.border.position)) {
				game.end();
				System.out.println("Out of area");
			}
		
		
		
	}
}
