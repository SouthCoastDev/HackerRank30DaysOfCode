class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        var binary = Convert.ToString(n,2);
        int maxCount = 0;
        int currentCount = 0;
   
        foreach(var num in binary)
        {
            
            if(num == '1')
            {
               currentCount++;
            } else
            {
                currentCount = 0;
            }
            
            if(currentCount > maxCount)
            {
                maxCount = currentCount;
            }
        }
        
        Console.WriteLine(maxCount);
    }
}
