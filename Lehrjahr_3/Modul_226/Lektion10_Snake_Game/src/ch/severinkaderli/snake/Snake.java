package ch.severinkaderli.snake;

import java.awt.Color;
import java.awt.Graphics;


public class Snake extends Entity {
    public Snake(int x, int y, int width, int height) {
    	super(x, y, width, height);
    }

    public void draw(Graphics g) {
    	g.setColor(Color.BLACK);
    	g.fillRect(position.x, position.y, position.width, position.height);
    }

}
