import java.util.Scanner;

class main{

    public static void main(String args[]) {

        Scanner var = new Scanner(System.in);    
        
        System.out.print("Enter your age: ");
        int age = var.nextInt();

        if (age >= 70)   {
            System.out.println("You're really old.");
        } else if (age >= 50)   {
                System.out.println("You're old.");
        } else if (age >= 10) {
                System.out.println("You're young.");                
        } else {
            System.out.println("You're a teenager.");
        }            
    }
}
