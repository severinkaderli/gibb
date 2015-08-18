/**
 * Author: Severin Kaderli
 * Date: 11. August 2015
 */
import java.awt.Color;
import java.awt.Font;

import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class Demo2 extends JFrame {
	
	private static final long serialVersionUID = 1l;
	public Demo2() {
		super("Ein erstes Beispiel");
		Icon icon = new ImageIcon(getClass().getResource("duke.gif"));	
		JLabel label = new JLabel("Viel Erfolg mit dem Grundkurs Java", icon, JLabel.CENTER);
	
		add(label);
	
		Font schrift = new Font("SansSerif", Font.BOLD, 20);
		label.setFont(schrift);
		label.setForeground(Color.RED);
		label.setBackground(Color.WHITE);
		label.setOpaque(true);
		
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setSize(500, 200);
		setVisible(true);
		setResizable(false);
	}

	public static void main(String[] args) {
		new Demo2();
	}

}