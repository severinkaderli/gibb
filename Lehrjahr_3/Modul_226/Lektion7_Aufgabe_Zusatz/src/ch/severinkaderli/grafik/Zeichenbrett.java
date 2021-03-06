package ch.severinkaderli.grafik;

import java.awt.Color;
import java.awt.Container;
import java.awt.GridLayout;

import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;


@SuppressWarnings("serial")
public class Zeichenbrett extends JFrame{


	private final Papier papier = new Papier();	

	public Zeichenbrett() {
		super("Zeichenbrett f�r Figuren");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(800, 600);
		
		Container c = getContentPane();
		c.setBackground(Color.WHITE);
		c.add(papier);
		//Create MenuBar
		JMenuBar bar = new JMenuBar();
		setJMenuBar(bar);
		JMenu modus = new JMenu("Modus");
		bar.add(modus);
		JMenuItem circle = new JMenuItem("Kreis");
		modus.add(circle);
		
		setVisible(true);
	}
	
	public void zeige(Zeichnung zeichnung) {
		papier.setZeichnung(zeichnung);
		// Aufruf von repaint() bewirkt, dass das Fenster des Zeichenbrett
		// auf dem Dektop neu aufgebaut wird.
		repaint();
	}
}
