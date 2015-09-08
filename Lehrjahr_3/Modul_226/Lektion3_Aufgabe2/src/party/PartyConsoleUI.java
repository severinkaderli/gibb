package party;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * ab226.03, Aufgabe 2
 * Klasse PartyConsoleUI implementiert eine konsolenbasierte Benutzerschnittstelle
 * f�r die Party-Applikation. Sie verwendet die Klasse PartyCore.
 * @author Andres Scheidegger
 */
public class PartyConsoleUI {

  /**
   * Hauptmethode f�r den Start der Party-Applikation. Fordert den Benutzer auf 
   * die Anzahl G�ste einzugeben und stellt dann die Anzahl der erklingenden
   * Gl�serpaare beim Anstossen dar.
   * 
   * @param args nicht verwendet
   * @throws NumberFormatException, wenn die Benutzereingabe keine g�ltige Zahl ist.
   * @throws IOException, wenn die Konsole nicht ge�ffnet oder gelesen werden kann.
   */
  public static void main(String[] args) throws NumberFormatException, IOException {
    // Konsole zum Lesen �ffnen
    BufferedReader input = new BufferedReader(new InputStreamReader(System.in));

    // Prompt ausgeben und Anzahl Teilnehmer von Konsole lesen
    System.out.println("Geben Sie die Anzahl der Teilnehmer ein:");
    int teilnehmer = Integer.parseInt(input.readLine());
    PartyCore.setNbOfGuests(teilnehmer);

    // anstossen
    System.out.println(
        "Wenn " + teilnehmer + " Teilnehmer anstossen, erklingen " + 
        PartyCore.cheers() + " Gl�serpaare."
    );

  }
}
