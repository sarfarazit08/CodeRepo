public enum info {
    Sarfu ("B. Tech", 27),
    Riya  ("M. Tech", 29),
    Sophie ("B. Ed.", 25),
    Saloni("M. Tech", 24),
    Seneca("Accountant", 22),
    Roza("Receptionist", 19);
    
    private final String degree;
    private final int age;

    info (String degree_info, int age_info){
        degree = degree_info;
        age = age_info;        
    }

    public String getDegreeInfo() {
        return degree;        
    }

    public int  getAgeInfo() {
        return age;
    }
}