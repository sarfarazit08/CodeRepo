class arrays{

    public static void main(String args[]) {       

        int numbers[] = {43,23,34,54,65,67,78,90};
        String names[] = {"Sarfu", "Jasamine", "Riya", "Rohan"};

        for (int num : numbers) {
            System.out.println("Number :" + num);
        }

        for (String name : names) {
            System.out.println("Name :" + name);
        }

    }
}