class array_sum{

    public static void main(String args[]) {       

        int nums[] = {25,20,22,23};
        String words[] = {"I","Love","You"};

        // integer sum
        int sum = 0;
        for (int i : nums){
            sum += i;          
        }
        System.out.println("Sum : "+ sum);

        // words concatenation
        String sentence = "";
        for (String word : words){
            sentence += word + " ";          
        }
        System.out.println("Sentence : "+ sentence);

    }
}