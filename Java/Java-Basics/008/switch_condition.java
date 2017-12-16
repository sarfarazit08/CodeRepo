import java.util.Scanner;

class switch_condition{

    public static void main(String args[]) {

        Scanner var = new Scanner(System.in);

        System.out.print("Enter numbers from (10,20,40,60) which ever is nearest to your age: ");
        int age = var.nextInt();

        switch (age) {
            case 10:
                System.out.println("You're a teenager now!");
                break;

            case 20:
                System.out.println("You're an adult now!");
                break;

            case 40:
                System.out.println("You're a man now!");
                break;

            case 60:
                System.out.println("You're an old man now!");
                break;
        
            default:
                System.out.println("Sorry! but I'm clueless about your age!");
                break;
        }

    }
}
