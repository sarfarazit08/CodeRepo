import java.util.Scanner;

class average{

    public static void main(String args[]) {

        Scanner var = new Scanner(System.in);

        int total, counter, grade, average;

        total = 0;
        counter = 0;

        while (counter < 10){
            System.out.print("Enter your grade: ");
            grade = var.nextInt();
            total += grade;
            counter++;
        }

        average = total / 10 ;
        System.out.println("Average grade : "+ average);               
    }
}
