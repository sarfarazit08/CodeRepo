public class greet {

    private String name_val;

    public greet(String name){
        name_val = name;
    }

    public String getName() {
        return name_val;
    }

    public void greet() {
        System.out.println("Hello! " + getName() +".");
    }
    
}