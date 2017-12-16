import java.util.Scanner;

class operators
{
    public static void main(String args[])
    {
        // take the user input from console 
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int num1 = input.nextInt();

        System.out.println("Pre-increment");
        System.out.println(++num1);
        System.out.println(++num1);

        System.out.println("Post-increment");
        System.out.println(num1++);
        System.out.println(num1++);

        System.out.println("Pre-decrement");
        System.out.println(--num1);
        System.out.println(--num1);

        System.out.println("Post-decrement");
        System.out.println(num1--);
        System.out.println(num1--); 

        System.out.println("Other Operators");
        num1 += 5;
        System.out.println(num1);
        num1 -= 5;
        System.out.println(num1);
        num1 *= 5;
        System.out.println(num1);
        num1 /= 5;
        System.out.println(num1);
        num1 %= 4;
        System.out.println(num1);
    }
}