class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        
        for(var i = 1 ; i <=  10; i++)
        {
            Console.WriteLine($"{n.ToString()} x {i.ToString()} = {(i * n).ToString()}");
        }
    }
}
