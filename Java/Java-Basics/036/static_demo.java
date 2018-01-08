public class static_demo
{
    private String first_name;
    private String last_name;

    private static int members_count = 0;

    public static_demo(String fn, String ln)
    {
        first_name = fn;
        last_name = ln;
        members_count++;

        System.out.printf("Hello! %s %s. Your membership number is %d.\n", first_name, last_name, members_count);
    }

    public String get_first_name() {
        return first_name;
    }

    public String get_last_name() {
        return last_name;
    }

    public static int get_members_count() {
        return members_count;
    }
}