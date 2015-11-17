package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Game {

	/**
	 * Die Schlange, die man Steuert.
	 */
	public Snake snake;
	
	/**
	 * Liste, welche alle Spielelemente, wie Diamanten enthält
	 */
	private static List<Entity> entities = new ArrayList<Entity>();
	
	/**
	 * Anzahl der Diamante, die auf dem Feld erschienen sollen.
	 */
	final private int NUMBER_OF_DIAMONDS = 10;
	
	/**
	 * Schrittweite, um die sich die Schlange bei jedem Tick bewegt.
	 */
	final private int STEP_SIZE = 2;
	
	/**
	 * Anzahl der Ticks pro Sekunde
	 */
	final private int FRAMES_PER_SECOND = 16;
	
	
	/**
	 * Delegiert das zeichnen an die einzelnen Elemente
	 * @param g
	 */
	public void draw(Graphics g) {
		snake.draw(g);
		entities.forEach(entity -> entity.draw(g));
	}
	
	/**
	 * Erstellt die Elemente, die für das Spiel nötig sind und zeigt am
	 * Schluss das Feld an.
	 */
	public Game() {
		GUI gui = new GUI(this);

		//Create random diamonds
		for(int i=0;i<NUMBER_OF_DIAMONDS;i++) {
			int value = Zufallsgenerator.zufallszahl(1, 5);
			int x = Zufallsgenerator.zufallszahl(0, gui.getBreite()-20);
			int y = Zufallsgenerator.zufallszahl(0, gui.getHoehe()-20);
			entities.add(new Diamond(x, y, value));
		}
		
		//Add snake
		snake = new Snake(10, 10, 10, 10);
		
		//Main Game Loop
		while(true) {
			loop();
			gui.repaint();	
		}
		
	}
	
	public void loop() {
		try {
			Thread.sleep(FRAMES_PER_SECOND);
			snake.move(STEP_SIZE);
			
			//Read key strokes and change direction of snake
		} catch(InterruptedException e) {
			
		}
	}
	
	/**
	 * Create game object to start the game
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		Game game = new Game();
	}

}
