import java.util.Observable;


public class Fernseher extends Observable {
	
	private String channel;
	
	public Fernseher(String channel) {
		setChannel(channel);
	}
	
	public String getChannel() {
		return channel;
	}
	
	public void setChannel(String channel) {
		this.channel = channel;
	}
	
	public void changeChannel(String newChannel) {
		setChannel(channel);
		setChanged();
		notifyObservers(newChannel);
	}
}
