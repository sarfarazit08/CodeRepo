class array_table{

    public static void main(String args[]) {       

        int ages[] = {25,20,22,23};
        String names[] = {"Sarfu", "Marie", "Riya", "Rohan"};

        System.out.println("Sl. No.\tName\t\tAge");
        for (int i = 0; i < 4 ; i++){
            System.out.println(i+1 +"\t"+names[i]+"\t\t"+ages[i]);
        }       

    }
}