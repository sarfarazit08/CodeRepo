class overloaded_constructor{

    public static void main(String args[]) {       
        time_format timeObj1 = new time_format();
        time_format timeObj2 = new time_format(15);
        time_format timeObj3 = new time_format(15,6);
        time_format timeObj4 = new time_format(13,45,34);
        
        System.out.println("Military time:" + timeObj1.toMilitary());
        System.out.println("Standard time:" + timeObj1.toString());
        System.out.println("Military time:" + timeObj2.toMilitary());
        System.out.println("Standard time:" + timeObj2.toString());
        System.out.println("Military time:" + timeObj3.toMilitary());
        System.out.println("Standard time:" + timeObj3.toString());
        System.out.println("Military time:" + timeObj4.toMilitary());
        System.out.println("Standard time:" + timeObj4.toString());
    }
} 