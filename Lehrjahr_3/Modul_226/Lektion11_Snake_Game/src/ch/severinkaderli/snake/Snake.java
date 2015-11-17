package ch.severinkaderli.snake;

import java.awt.Color;
import java.awt.Graphics;


public class Snake extends Entity {
	
	/**
	 * Die Richtung in die sich die Schlange momentan bewegt.
	 */
	private Direction direction = Direction.LEFT;
	

	enum Direction {
		UP,
		DOWN,
		LEFT,
		RIGHT
	}
	
	/**
	 * 
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 */
    public Snake(int x, int y, int width, int height) {
    	super(x, y, width, height);
    }
    
    /**
     * Zeichnet die Schlange auf das Feld.
     */
    public void draw(Graphics g) {
    	g.setColor(Color.BLACK);
    	g.fillRect(position.x, position.y, position.width, position.height);
    }
    
    /**
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
    	//Move in direction
    	switch (direction) {
    	
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
    	
    	//Check boundaries
    }
}
