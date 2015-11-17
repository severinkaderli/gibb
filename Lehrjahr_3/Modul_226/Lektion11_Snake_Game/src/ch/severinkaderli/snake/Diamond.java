package ch.severinkaderli.snake;

import java.awt.Graphics;

public class Diamond extends Entity {
    protected int value;

    public Diamond(int x, int y, int width, int height, int value) {
    	super(x, y, width, height);
    	this.value = value;
    }
    public void draw(Graphics g) {
    	g.drawOval(position.x, position.y, position.width, position.height);
    	//TODO: Get string drawing to the correct position.
    	g.drawString(String.valueOf(value), position.x+7, position.y+15);
    }

}
