public class enum_demo {

    public static void main(String[] args) {
        for (details user : details.values()) 
            System.out.printf("%s\t%s\t%s\n", user, user.getDegreeInfo(), user.getAgeInfo());
    }
}
    
