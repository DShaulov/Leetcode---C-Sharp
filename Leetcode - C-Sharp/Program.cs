// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        PathSumTwoSolution sol = new PathSumTwoSolution();
        TreeNode root = new TreeNode(null, null, 8);
        TreeNode node1 = new TreeNode(null, null, 9);
        TreeNode node2 = new TreeNode(null, null, -6);
        TreeNode node3 = new TreeNode(null, null, 5);
        TreeNode node4 = new TreeNode(null, null, 9);

        root.left = node1;
        root.right = node2;
        node2.left = node3;
        node2.right = node4;

        TreeNode root2 = new TreeNode(null, new TreeNode(null, null, -3), -2);

        sol.PathSum(root, 7);

    }
}