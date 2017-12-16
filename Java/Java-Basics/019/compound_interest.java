class compound_interest{

    public static void main(String args[]) {       

        double amount, principal, rate;
        principal = 1000;
        rate = 0.075;

        for(int quarter = 1; quarter <= 4; quarter++)
        {
            amount = principal * Math.pow(1+ rate, quarter);
            System.out.println("Amount : "+ amount);
        }
                      
    }
}
