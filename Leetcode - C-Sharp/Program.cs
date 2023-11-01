// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        MergeSortedArraySolution sol = new MergeSortedArraySolution();
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = { 2, 5, 6 };
        int n = 3;
        sol.Merge(nums1, m, nums2, n);
    }
}