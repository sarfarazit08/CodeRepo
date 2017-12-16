import java.util.Scanner;

class while_loop{

    public static void main(String args[]) {

        Scanner var = new Scanner(System.in);

        System.out.print("Enter a number: ");
        int num = var.nextInt();

        while (num <= 10 ) {
            System.out.println("Num -> "+ num);
            num++;
            
        }

    }
}
