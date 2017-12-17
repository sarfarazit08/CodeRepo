public class composition {
    private String name;
    private birthday bday;

    public composition(String birth_name, birthday birth_date) {
        name = birth_name;
        bday = birth_date;
    }

    public String toString(){
      return String.format("My name is %s.\nMy birthday is %s.", name, bday);
    }
}
    
