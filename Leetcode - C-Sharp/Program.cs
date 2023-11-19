// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        SearchMatrixSolution sol= new SearchMatrixSolution();
        int[][] nums = new int[3][];
        nums[0] = new int[]  { 1, 3, 5 ,7};
        nums[1] = new int[]  { 10, 11, 16 ,20};
        nums[2] = new int[] { 23, 30, 34 ,60};
        sol.SearchMatrix(nums, 13);
    }
}