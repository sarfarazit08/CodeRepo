import java.util.Scanner;

class logical_operators{
    public static void main(String[] args) {
        Scanner var = new Scanner(System.in);

        System.out.print("Enter your age: ");
        int age = var.nextInt();

        if (age >= 18 && age <= 55 ){
            System.out.println("You're allowed to enter this site!");
        } 
        else {
            System.out.println("You're not allowed to enter this site!");
        }

    }
}
