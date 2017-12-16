import java.util.Scanner;

class main{

    public static void main(String args[]) {

    Scanner var = new Scanner(System.in);
    
    // get name of the user
    System.out.print("Enter your name: ");
    String name = var.nextLine();    

    // pass the user name to greet method
    greet msg = new greet();
    msg.setName(name);
    msg.greet();

    }
}