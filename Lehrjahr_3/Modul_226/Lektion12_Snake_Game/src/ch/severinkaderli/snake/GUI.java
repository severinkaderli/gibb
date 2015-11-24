package ch.severinkaderli.snake;

import java.awt.Graphics;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

import javax.swing.JFrame;
import javax.swing.JPanel;

/**
 * Die Klasse GUI stellt das Fenster (JFrame) und das Spielfeld (JPanel) des
 * Snake-Spiels zur Verfügung.
 * 
 * @author A. Scheidegger, M.Frieden
 * @version 4.0
 */

@SuppressWarnings("serial")
public class GUI extends JFrame {

	/** Referenz auf das Game-Objekt. */
	private Game game;

	/** Das JPanel, welches als Spielfeld dient. Anonyme innere Klasse. */
	private JPanel spielfeld = new JPanel() {
		/**
		 * Wird automatisch aufgerufen, wenn das Fenster neu gezeichnet werden
		 * muss. Delegiert das Zeichnen des Spiels an das Game-Objekt.
		 * 
		 * @param g
		 *            Graphics-Objekt zum Zeichnen
		 */
		@Override
		public void paintComponent(Graphics g) {
			game.draw(g);
		}
	};

	/**
	 * Konstruktor. Initialisiert den Frame. Registriert das Game-Objekt als
	 * KeyListener.
	 */
	public GUI(Game game) {
		this.game = game;
		setSize(600, 400);
		setTitle("Snake Game - Severin Kaderli");
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setContentPane(spielfeld);
		setVisible(true);
		setResizable(false);
		setFocusable(true);
		addKeyListener(new GUIKeyListener());
	}

	/**
	 * Gibt die Breite des Spielfeldes zurück.
	 * 
	 * @return Breite des Spielfeldes.
	 */
	public int getBreite() {
		return spielfeld.getWidth();
	}

	/**
	 * Gibt die Höhe des Spielfeldes zurück.
	 * 
	 * @return Höhe des Spielfeldes
	 */
	public int getHoehe() {
		return spielfeld.getHeight();
	}

	private class GUIKeyListener extends KeyAdapter {
		public void keyPressed(KeyEvent e) {

			// Change the direction of the snake
			switch (e.getKeyCode()) {
			
			case KeyEvent.VK_UP:
				game.snake.setDirection(Direction.UP);
				break;
			case KeyEvent.VK_DOWN:
				game.snake.setDirection(Direction.DOWN);
				break;
			case KeyEvent.VK_LEFT:
				game.snake.setDirection(Direction.LEFT);
				break;
			case KeyEvent.VK_RIGHT:
				game.snake.setDirection(Direction.RIGHT);
				break;
			
			default:
				break;
			}
			
			
		}
	}
}
