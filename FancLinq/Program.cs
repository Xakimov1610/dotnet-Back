using FancLinq;

public class Program
{
    public static void Main(string[] args)
    {
        var nums = new int[] {1,2,3,4,5,6,7};
        var str = nums.Select((value) => SelectMethod(value))
                .ToList();
            
        str.ForEach(System.Console.WriteLine);

        var str2 = nums.Select((value1, value2) => SelectMethod(value1, value2))
                .ToList();

        str2.ForEach(System.Console.WriteLine);

        // MY Select ------------------

        var str3 = nums.MySelect(SelectMethod)
                .ToList();
        str3.ForEach(System.Console.WriteLine);

    }




    public static string SelectMethod(int arg1)
    {
        return string.Format($"sonlar : {arg1}");
    }

    public static string SelectMethod(int arg1, int arg2)
    {
        return string.Format($"son : {arg1} index : {arg2}");
    }


}
