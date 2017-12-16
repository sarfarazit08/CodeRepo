import java.util.Random;

class dice{

    public static void main(String args[]) {       

        Random dice = new Random();
        int number, counter;

        for (counter = 1; counter <= 10; counter++){
            number = 1 + dice.nextInt(6);
            System.out.println("Dice roll: "+ number);
        }

    }
}