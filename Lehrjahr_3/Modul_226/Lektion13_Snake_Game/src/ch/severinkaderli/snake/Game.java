package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

/**
 * 
 * @author Severin Kaderli
 */
public class Game {

	/**
	 * Die Schlange, die man Steuert.
	 */
	public Snake snake;

	/**
	 * Der Rahmen des Spielfeldes
	 */
	public Border border;

	/**
	 * Das Spielfeld
	 */
	public GUI gui;

	/**
	 * Aktueller Zustand, ob das Spiel am laufen ist.
	 */
	private boolean isRunning = true;

	/**
	 * Die aktuelle Punktzahl
	 */
	private int score = 0;

	/**
	 * Liste, welche alle Diamanten enth�lt
	 */
	private static List<Diamond> diamonds = new ArrayList<Diamond>();

	/**
	 * Anzahl der Diamanten, die auf dem Feld erschienen sollen.
	 */
	final private int NUMBER_OF_DIAMONDS = 10;

	/**
	 * Radius der Diamanten
	 */
	final private int DIAMOND_RADIUS = 20;


	/**
	 * L�nge eines Ticks
	 */
	final private int TICK_LENGTH = 100;

	/**
	 * Abstand vom Border zum Fensterrand.
	 */
	final private int AREA_PADDING = 10;

	/**
	 * Delegiert das zeichnen an die einzelnen Elemente
	 * 
	 * @param g
	 */
	public void draw(Graphics g) {
		border.draw(g);
		snake.draw(g);

		diamonds.forEach((diamond) -> {
			if (diamond.isAlive) {
				diamond.draw(g);
			}
		});

		g.drawString(String.valueOf(score), 10, 10);
	}

	/**
	 * Erstellt die Elemente, die f�r das Spiel n�tig sind und zeigt am Schluss
	 * das Feld an.
	 */
	public Game() {

		// Das Spielbrett initialisieren
		gui = new GUI(this);

		// Spielbegrenzung einf�gen
		int borderWidth = gui.getBreite() - 2 * AREA_PADDING;
		int borderHeight = gui.getHoehe() - 2 * AREA_PADDING;
		border = new Border(AREA_PADDING, AREA_PADDING, borderWidth,
				borderHeight);

		// Diamanten an zuf�lliger Position auf dem Feld erscheinen lassen.
		for (int i = 0; i < NUMBER_OF_DIAMONDS; i++) {
			int value = Zufallsgenerator.zufallszahl(1, 5);
			int x = Zufallsgenerator.zufallszahl(AREA_PADDING, AREA_PADDING
					+ borderWidth - DIAMOND_RADIUS);
			int y = Zufallsgenerator.zufallszahl(AREA_PADDING, AREA_PADDING
					+ borderHeight - DIAMOND_RADIUS);
			diamonds.add(new Diamond(x, y, DIAMOND_RADIUS, DIAMOND_RADIUS,
					value));
		}

		// Add snake
		snake = new Snake(300, 100, this);

		// Main Game Loop
		while (isRunning) {
			loop();
			gui.repaint();
		}

	}

	/**
	 * Main loop-Funktion f�r das Spiel, hier werden die einzelnen Ticks des
	 * Spieles durchgef�hrt und dabei wird immer die Schlange bewegt.
	 */
	public void loop() {
		try {
			Thread.sleep(TICK_LENGTH);
			snake.move(); //=> Sequenzdiagramm hier
			checkCollision();

			// Read key strokes and change direction of snake
		} catch (InterruptedException e) {

		}
	}

	/**
	 * �berpr�ft, ob es irgendwelche Kollisionen gibt.
	 */
	public void checkCollision() {
		snake.checkCollision();
	}

	/**
	 * Beendet die aktuelle Spielpartie und zeigt den Status in der Titelleiste
	 * an.
	 */
	public void end() {
		isRunning = false;
		gui.setTitle("End of game");

	}

	/**
	 * Gibt die Liste der aktuellen Diamanten zur�ck.
	 * 
	 * @return
	 */
	public List<Diamond> getDiamonds() {
		return diamonds;
	}

	public void removeDiamond(Diamond diamond) {
		diamonds.remove(diamond);
	}

	public void setScore(int score) {
		this.score = score;
	}

	public int getScore() {
		return score;
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
