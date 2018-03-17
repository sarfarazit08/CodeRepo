import java.awt.FlowLayout;
import javax.swing.JFrame;
import javax.swing.JLabel;

class jframe extends JFrame{
	
	private JLabel item;
	
	public jframe(){
		super("Title");
		setLayout(new FlowLayout());
		
		item = new JLabel("Welcome to Java Land!");
		item.setToolTipText("Tool Tip Text");
		add(item);
	}
}