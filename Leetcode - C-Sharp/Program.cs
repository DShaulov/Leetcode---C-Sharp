// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        IsBalancedSolution sol = new IsBalancedSolution();
        TreeNode root = new TreeNode(new TreeNode(null, null, 2), null, 1);
        sol.IsBalanced(root);
    }
}