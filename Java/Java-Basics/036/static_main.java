class static_main{
    public static void main(String[] args) {
        static_demo obj1 = new static_demo("Riya", "Sen");
        static_demo obj2 = new static_demo("Rima", "Sen");
        static_demo obj3 = new static_demo("Rohan", "Vadwa");
        static_demo obj4 = new static_demo("Rony", "Kapoor");     
        
        System.out.println(obj1.get_first_name());
        System.out.println(obj1.get_last_name());
        System.out.println(static_demo.get_members_count());
    }
}