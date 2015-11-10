package ch.severinkaderli.snake;

import java.awt.Graphics;

public class Diamond extends Entity {
    protected int value;

    public Diamond(int x, int y, int value) {
    	super(x, y, 20, 20);
    	this.value = value;
    }
    public void draw(Graphics g) {
    	g.drawOval(position.x, position.y, position.width, position.height);
    	g.drawString(String.valueOf(value), position.x+10, position.y+10);
    }

}
