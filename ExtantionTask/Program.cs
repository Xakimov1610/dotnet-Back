public static class MyExtensions
{
    public static int Reverse(this int num)
    {
        int result=0;
        
        while (num != 0) 
        {
        result = result*10 + num%10;
        num /= 10;
        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int a = 1534236469;

        System.Console.WriteLine(a.Reverse());
    }
}