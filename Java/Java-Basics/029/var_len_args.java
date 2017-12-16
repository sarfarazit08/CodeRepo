class var_len_args{

    public static void main(String args[]) {       
        System.out.println("Sum(1 ,2 ,2 ,5):" + sum(1, 2, 2, 5));
        System.out.println("Sum(3, 8, 2, 5, 9):" + sum(3, 8, 2, 5, 9));
    }

    public static int sum(int...numbers) {
        int sum = 0;
        for (int num : numbers) {
            sum += num;
        }
        return sum;
    }
}