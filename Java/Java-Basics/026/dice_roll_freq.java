import java.util.Random;

class dice_roll_freq{

    public static void main(String args[]) {       

        Random dice = new Random();
        
        // Frequency array of size 6 
        // to hold frequency of 6 faces of dice
        int frequency[] = new int[7];

        for (int roll = 1; roll <= 1000; roll++){

            // it captures the value of the face of dice
            // and it's frequency
            ++frequency[1 + dice.nextInt(6)]; 
        }

        System.out.println("Face\tFrequency\tPercentage");
        for (int face = 1; face < frequency.length; face++){
            System.out.println(face+"\t"+frequency[face]+"\t\t"+ (frequency[face]/10.0));
        }
    }
}