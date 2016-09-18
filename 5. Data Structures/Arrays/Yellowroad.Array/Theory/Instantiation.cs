namespace Yellowroad.Array.Theory
{
    public class Instantiation
    {
        //Single dimensional array with 3 empty elements
        int[] nums = new int[3];

        //Single dimensional array with 3 elements (1,2,3)
        int[] nums2 = new int[3] { 1, 2, 3 };

        //Same as nums2, but we can omit the length parameter when using the literal declaration
        int[] nums3 = new int[] { 1, 2, 3 };

        //Same as nums2 and nums3, very similar to JavaScript literal syntax
        int[] nums4 = { 1, 2, 3 };

        //Multi-dimensional array
        int[,] chessTable = new int[8, 8];

        //Array of arrays (jagged array)
        int[][] jagged = new int[3][];
    }
}