class arrays_as_param{

    public static void main(String args[]) {       
        int ages[] = {12,32,34,56,42,34,46,37,53,23,40,35};
        
        System.out.println("Sum :"+ sum(ages)); 
        System.out.println("Count: "+ ages.length);       
        System.out.println("Average :"+ sum(ages)/ages.length);        
    }

    public static int sum(int arr[]) {
        int sum = 0;
        for(int num : arr){
            sum += num;
        }
        return sum;
    }
}