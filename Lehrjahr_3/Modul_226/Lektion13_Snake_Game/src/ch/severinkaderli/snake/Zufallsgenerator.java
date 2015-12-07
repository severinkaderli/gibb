package ch.severinkaderli.snake;

import java.util.Random;

/**
 * Hilfsklasse zum Erzeugen von Zufallszahlen.
 * 
 * @author Andres Scheidegger
 */
public class Zufallsgenerator {

  /** Random-Objekt zur Erzeugung von Zufallszahlen */
  private static final Random RANDOM = new Random(System.currentTimeMillis());;

  /**
   * Hilfsmethode zum Erzeugen von Zufallszahlen in einem gegebenen Intervall,
   * inklusive Intervallgrenzen.
   * @param untereGrenze Unter Grenze des Intervalls
   * @param obereGrenze  Obere Grenze des Intervalls
   * @return Zufallszahl innerhalb des gegebenen Intervalls
   */
  public static int zufallszahl(int untereGrenze, int obereGrenze)
  {
    return Math.abs(RANDOM.nextInt() % (obereGrenze + 1 - untereGrenze)) + untereGrenze;
  }

}
