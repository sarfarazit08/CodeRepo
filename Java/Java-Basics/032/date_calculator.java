public class date_calculator {
    private int month;
    private int day;
    private int year;

    public static void main(String[] args) {
        date_calculator obj = new date_calculator(4, 5, 6);
        obj.toString();
    }

    public date_calculator(int m, int d, int y) {
        month = m;
        day   = d;
        year  = y;

        System.out.printf("The constructor for this is %s\n",this);
    }

    public String toString(){
      return String.format("%02d/%02d/%02d", day,month,year);
    }
}
    
