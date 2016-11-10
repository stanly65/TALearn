using System;
class MaximalSumOfConsecutiveElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        int maxSum = arr[0], tempSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            tempSum += arr[i];
            if (tempSum < arr[i]) tempSum = arr[i];

            if (tempSum > maxSum) maxSum = tempSum;
        }
        Console.Write(maxSum);
    }
}