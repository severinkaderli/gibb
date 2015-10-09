package party;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

/**
 * ab226.03, Aufgabe 2
 * Klasse PartyGUI implementiert eine grafische Benutzerschnittstelle
 * für die Party-Applikation. Sie verwendet die Klasse PartyCore.
 * @author Andres Scheidegger
 */
public class PartyGUI extends JFrame {

  private final static long serialVersionUID = 1l;
	
  /** Klassenvariable für die Anzahl Teilnehmer, welche der Benutzer eingibt */
  private static int teilnehmer;
  
  /**
   * Hauptmethode für den Start der Party-Applikation. Liest die Anzahl Gäste ein
   * und stellt dann die Anzahl der erklingenden Gläserpaare beim Anstossen in
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
   * Öffnet einen Dialog für die Eingabe der Anzahl Gäste durch den Benutzer.
   * 
   * @return Anzahl Gäste, welche der Benutzer eingegeben hat.
   */
  private static int readNbOfGuests() {
    String tn = JOptionPane.showInputDialog("Geben Sie die Anzahl Teilnehmer an");
    return Integer.parseInt(tn);
  }

  /**
   * Konstruktor. Öffnet ein neues Fenster auf dem Desktop.
   */
  private PartyGUI() {
    super("Party-GUI");
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    setBackground(Color.lightGray);
    setSize(500,200);
    setVisible(true);
  }

  /** 
   * Berechnet die Anzahl Gläserpaare beim Anstossen und stellt diese auf dem
   * Fenster dar.
   * 
   * @param g Graphics-Kontext für das Zeichnen auf dem Fenster.
   * @see java.awt.Window#paint(java.awt.Graphics)
   */
  public void paint(Graphics g)
  {
    super.paint(g);
    
    PartyCore.setNbOfGuests(teilnehmer);
    
    g.drawString(
        "Wenn " + teilnehmer + " Teilnehmer anstossen, erklingen " + 
        PartyCore.cheers() + " Gläserpaare." , 10, 80
    );
  }
}
