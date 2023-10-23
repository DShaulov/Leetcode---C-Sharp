// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        SearchInsertSolution sol = new SearchInsertSolution();
        int[] nums = { 1, 3, 5, 6 };
        Console.WriteLine(sol.SearchInsert(nums, 5));
        Console.WriteLine(sol.SearchInsert(nums, 2));
        Console.WriteLine(sol.SearchInsert(nums, 7));
    }
}