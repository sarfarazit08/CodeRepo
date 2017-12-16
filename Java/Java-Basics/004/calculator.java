import java.util.Scanner;

class calculator
{
    public static void main(String args[])
    {
        // take the user input from console 
        Scanner var = new Scanner(System.in);       
        
        // define variables to store the numbers and results
        double first_num, second_num;

        // assign the variables
        System.out.print("Enter first number: ");
        first_num = var.nextDouble();

        System.out.print("Enter second number: ");
        second_num = var.nextDouble();

        // calculate results
        System.out.println("Results: ");
        System.out.println("\tSum: "+ (first_num + second_num));
        System.out.println("\tDifference: "+ (first_num - second_num));
        System.out.println("\tMultiplication: "+ (first_num * second_num));
        System.out.println("\tDivision: "+ (first_num / second_num));
        System.out.println("\tRemainder: "+ (first_num % second_num));
        
    }
}