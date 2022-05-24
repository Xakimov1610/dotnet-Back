using ActionTask;

public class Program
{
    // Action yasab IEnumurable ga Extension qo'shishga misol
    public static void Main(string[] args)
    {
        var sonlar = new int[] {1,2,3,4,5};

        sonlar.Print(System.Console.WriteLine);
        
        
        var sonlarString = new [] {"1","2","3","4"};

        sonlarString.PrintF(File.WriteAllText);

       
    }
}
