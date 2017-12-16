import java.util.Scanner;

class main{

    public static void main(String args[]) {

        Scanner var = new Scanner(System.in);    
        
        System.out.print("Enter your age: ");
        int age = var.nextInt();

        if (age < 50)   {
            System.out.println("You're young.");
            
            if (age < 18)   {
                System.out.println("You're a teenager.");
            } else {
                System.out.println("You're an adult person.");                
            } 

        } else {
            System.out.println("You're old.");
            
            if (age > 75)   {
                System.out.println("You're really old.");
            } else {
                System.out.println("You're old but still enjoying your life.");
            }            
        }
    }
}