class time_calculator{

    public static void main(String args[]) {       
        time timeObj = new time();
        System.out.println("Military time:" + timeObj.toMilitary());
        System.out.println("Standard time:" + timeObj.toString());
        timeObj.setTime(22,23,25);
        System.out.println("Military time:" + timeObj.toMilitary());
        System.out.println("Standard time:" + timeObj.toString());
        timeObj.setTime(11,12,25);
        System.out.println("Military time:" + timeObj.toMilitary());
        System.out.println("Standard time:" + timeObj.toString());
    }
}