public class final_keyword{
    private int sum;
    private final int Num;

    public final_keyword(int x){
        Num = x;        
    }

    public void add(){
        sum += Num;
    }

    public String toString(){
        return String.format("%s\n",sum);
    }
}