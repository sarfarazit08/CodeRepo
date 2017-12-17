public class time_format {
    private int hour;
    private int min;
    private int sec;

    public time_format() {
        this(0, 0, 0);
    }

    public time_format(int h) {
        this(h, 0, 0);
    }

    public time_format(int h, int m) {
        this(h, m, 0);
    }

    public time_format(int h, int m, int s) {
        set_time(h, m, s);
    }

    private void set_time(int h, int m, int s) {
        set_hour(h);
        set_min(m);
        set_sec(s);
    }

    private void set_hour(int h) {
        hour = (h >= 0 && h < 24) ? h : 0 ;
    }

    private void set_min(int m) {
        min = (m >= 0 && m < 60) ? m : 0 ;
    }

    private void set_sec(int s) {
        sec = (s >= 0 && s < 60) ? s : 0 ;
    }

    private int get_hour() {
        return hour;
    }

    private int get_min() {
        return min;
    }

    private int get_sec() {
        return sec;
    }

    public String toMilitary(){
        return String.format("%02d:%02d:%02d", get_hour(), get_min(), get_sec());
    } 

    public String toString(){

      return String.format("%02d:%02d:%02d %s", 
        ((get_hour() == 0 || get_hour() ==12) ?  12 : get_hour()%12),
        get_min(), get_sec(),   (get_hour() <12 ? "AM" : "PM"));
    }
}
    
