// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        PlusOneSolution sol = new PlusOneSolution();
        Console.WriteLine(sol.PlusOne(new int[] {1,2,3} ));
        Console.WriteLine(sol.PlusOne(new int[] {9,9,9}));
    }
}