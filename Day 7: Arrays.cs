class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        // I know it says array but the challange makes it a list!
    
        arr.Reverse();
        var retVal = string.Join(" ", arr);
        Console.WriteLine(retVal);

    }
}
