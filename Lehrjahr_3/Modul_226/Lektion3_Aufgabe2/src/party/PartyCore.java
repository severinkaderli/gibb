package party;

public class PartyCore {
	private static int nbOfGuests;
	
	public static void setNbOfGuests(int guests) {
		if(guests > 0) {
			nbOfGuests = guests;
		}
	}
	
	public static int cheers() {
		return nbOfGuests * (nbOfGuests-1)/2;
	}
}
