import java.util.Scanner;

class main{

    public static void main(String args[]) {

        Scanner var = new Scanner(System.in);    
        
        System.out.print("Enter your age: ");
        int age = var.nextInt();
        
        // Conditional Operator
        System.out.println(age >= 70 ? "You're really old." : 
            (age >= 50 ? "You're old." : 
            (age >= 10 ? "You're young." :
            "You're a teenager." 
            )));
                 
    }
}
