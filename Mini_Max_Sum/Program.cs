class Result
{
    public static void MiniMaxSum(List<int> arr)
    {
        long maxSum = long.MaxValue;
        long minSum = long.MinValue;
        long totalSum = 0;
        foreach (int num in arr)
        {
            totalSum += num;
            if (num < maxSum)
            {
                maxSum = num;
            }
            if (num > minSum)
            {
                minSum = num;
            }
        }
        long minSumFinal = totalSum - minSum;
        long maxSumFinal = totalSum - maxSum;

        Console.WriteLine(minSumFinal + " " + maxSumFinal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.MiniMaxSum(arr);
    }
}
