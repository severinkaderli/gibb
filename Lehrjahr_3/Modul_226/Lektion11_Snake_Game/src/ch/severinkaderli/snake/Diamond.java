package ch.severinkaderli.snake;

import java.awt.Graphics;

/**
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
     * @param x
     * @param y
     * @param width
     * @param height
     * @param value
     */
    public Diamond(int x, int y, int width, int height, int value) {
    	super(x, y, width, height);
    	this.value = value;
    }
    
    /**
     * Zeichnet den Diamanten und dessen Wert
     */
    public void draw(Graphics g) {
    	g.drawOval(position.x, position.y, position.width, position.height);
    	//TODO: Get string drawing to the correct position.
    	g.drawString(String.valueOf(value), position.x+7, position.y+15);
    }

}
