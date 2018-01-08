import java.util.EnumSet;

public class enum_set {

    public static void main(String[] args) {
        for (info user : info.values()) 
            System.out.printf("%s\t%s\t%s\n", user, user.getDegreeInfo(), user.getAgeInfo());

        System.out.println("\nAnd now for the range of constants!!!\n");

        for(info user: EnumSet.range(info.Sarfu, info.Sophie))
        {
            System.out.printf("%s\t%s\t%s\n", user, user.getDegreeInfo(), user.getAgeInfo());
        }
    }
}
    
