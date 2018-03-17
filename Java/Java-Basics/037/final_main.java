class final_main{
    public static void main(String[] args){
        final_keyword fkObj = new final_keyword(5);

        for (int i = 0; i < 5 ; i++){
            fkObj.add();
            System.out.printf("Sum = %s", fkObj.toString());
        }
    }

}