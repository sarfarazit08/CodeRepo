import java.util.Scanner;

class scanner
{
    public static void main(String args[])
    {
        // take the user input from console 
        Scanner name = new Scanner(System.in);       
        
        // and print it in the next line
        System.out.println("Hi! "+ name.nextLine());
    }
}