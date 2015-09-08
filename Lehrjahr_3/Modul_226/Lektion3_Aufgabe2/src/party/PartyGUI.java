package party;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

/**
 * ab226.03, Aufgabe 2
 * Klasse PartyGUI implementiert eine grafische Benutzerschnittstelle
 * f�r die Party-Applikation. Sie verwendet die Klasse PartyCore.
 * @author Andres Scheidegger
 */
public class PartyGUI extends JFrame {

  private final static long serialVersionUID = 1l;
	
  /** Klassenvariable f�r die Anzahl Teilnehmer, welche der Benutzer eingibt */
  private static int teilnehmer;
  
  /**
   * Hauptmethode f�r den Start der Party-Applikation. Liest die Anzahl G�ste ein
   * und stellt dann die Anzahl der erklingenden Gl�serpaare beim Anstossen in
   * einem Fenster dar.
   * 
   * @param args nicht verwendet
   */
  public static void main(String[] args) {
    teilnehmer = readNbOfGuests();
    Frame window = new PartyGUI();
    window.setVisible(true);
  }

  /**
   * �ffnet einen Dialog f�r die Eingabe der Anzahl G�ste durch den Benutzer.
   * 
   * @return Anzahl G�ste, welche der Benutzer eingegeben hat.
   */
  private static int readNbOfGuests() {
    String tn = JOptionPane.showInputDialog("Geben Sie die Anzahl Teilnehmer an");
    return Integer.parseInt(tn);
  }

  /**
   * Konstruktor. �ffnet ein neues Fenster auf dem Desktop.
   */
  private PartyGUI() {
    super("Party-GUI");
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    setBackground(Color.lightGray);
    setSize(500,200);
    setVisible(true);
  }

  /** 
   * Berechnet die Anzahl Gl�serpaare beim Anstossen und stellt diese auf dem
   * Fenster dar.
   * 
   * @param g Graphics-Kontext f�r das Zeichnen auf dem Fenster.
   * @see java.awt.Window#paint(java.awt.Graphics)
   */
  public void paint(Graphics g)
  {
    super.paint(g);
    
    PartyCore.setNbOfGuests(teilnehmer);
    
    g.drawString(
        "Wenn " + teilnehmer + " Teilnehmer anstossen, erklingen " + 
        PartyCore.cheers() + " Gl�serpaare." , 10, 80
    );
  }
}
