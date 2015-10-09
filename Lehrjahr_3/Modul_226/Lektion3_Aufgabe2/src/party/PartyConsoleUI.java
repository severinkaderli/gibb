package party;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * ab226.03, Aufgabe 2
 * Klasse PartyConsoleUI implementiert eine konsolenbasierte Benutzerschnittstelle
 * für die Party-Applikation. Sie verwendet die Klasse PartyCore.
 * @author Andres Scheidegger
 */
public class PartyConsoleUI {

  /**
   * Hauptmethode für den Start der Party-Applikation. Fordert den Benutzer auf 
   * die Anzahl Gäste einzugeben und stellt dann die Anzahl der erklingenden
   * Gläserpaare beim Anstossen dar.
   * 
   * @param args nicht verwendet
   * @throws NumberFormatException, wenn die Benutzereingabe keine gültige Zahl ist.
   * @throws IOException, wenn die Konsole nicht geöffnet oder gelesen werden kann.
   */
  public static void main(String[] args) throws NumberFormatException, IOException {
    // Konsole zum Lesen öffnen
    BufferedReader input = new BufferedReader(new InputStreamReader(System.in));

    // Prompt ausgeben und Anzahl Teilnehmer von Konsole lesen
    System.out.println("Geben Sie die Anzahl der Teilnehmer ein:");
    int teilnehmer = Integer.parseInt(input.readLine());
    PartyCore.setNbOfGuests(teilnehmer);

    // anstossen
    System.out.println(
        "Wenn " + teilnehmer + " Teilnehmer anstossen, erklingen " + 
        PartyCore.cheers() + " Gläserpaare."
    );

  }
}
