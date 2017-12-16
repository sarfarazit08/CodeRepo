class multidim_array{

    public static void main(String args[]) {       
        int array1_2D[][] = {{1,2,3},{1,3,4},{4,6,2}};
        int[][] array2_2D = {{1,0,3},{3},{2,5}};
        
        System.out.println("array1_2D elements:");
        show(array1_2D);
        System.out.println("\narray2_2D elements:");
        show(array2_2D);
    }

    public static void show(int array_2D[][]) {
        for (int[] row : array_2D) {
            for (int val : row) {
                System.out.print(val + "\t");
            }
            System.out.print("\n");     
        }
    }
}