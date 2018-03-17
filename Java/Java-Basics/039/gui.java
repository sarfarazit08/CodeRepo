import javax.swing.JOptionPane;

class gui{
	public static void main(String args[])
	{
		String fn = JOptionPane.showInputDialog("Enter first name:");
		String ln = JOptionPane.showInputDialog("Enter last name:");
		int age = Integer.parseInt(JOptionPane.showInputDialog("Enter age:"));
		
		String full_name = fn + " " + ln;
		
		JOptionPane.showMessageDialog(null, "Full name: " + full_name + "\nAge: " + age, "Name", JOptionPane.PLAIN_MESSAGE);
	}
}