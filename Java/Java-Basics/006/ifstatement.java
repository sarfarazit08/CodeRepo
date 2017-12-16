import java.util.Scanner;

class ifstatement
{
    public static void main(String args[]) {
        
        Scanner var = new Scanner(System.in);

        System.out.print("Enter year in YYYY format: ");
        int year = var.nextInt();
        
        if (year > 2017)
        {
            System.out.println("You're now in future!");
        }
        else if (year < 2017) {
            System.out.println("You're looking into the past!");
        }
        else {
            System.out.println("You're in current year now!");
        }
        
    }
}