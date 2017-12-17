public class enum_demo {
    private int month;
    private int day;
    private int year;

    public birthday(int m, int d, int y) {
        month = m;
        day   = d;
        year  = y;
    }

    public String toString(){
        return String.format("%02d/%02d/%02d", day,month,year);
      }

    public static void main(String[] args) {
        birthday bdayObj = new birthday(4, 5, 89);
        bdayObj.toString();
        composition Obj = new composition("Sarfu", bdayObj);
        System.out.println(Obj);
    }

    
}
    
