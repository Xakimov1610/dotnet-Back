using Predicate;
public class Program
{
    public static void Main(string[] args)
    {
        var yoshlar = new int[] {16,21,13,41,15,27,23};
        
        yoshlar.KottaBollar(KattaBola)
            .ToList()
            .ForEach(System.Console.WriteLine);
    }

    public static bool KattaBola(int age)
    {
        return age > 18;
    }
}
