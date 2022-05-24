using System;
using System.Text;

public static class Program
{

    public static void Main(string[] args)
    {
       
        string [] addres = new string[3];
        for( var i = 1 ; i <= 3; i++)
        {
            var str = Console.ReadLine();
            var clear = str.RemoveSpecialCharacters();

            using (StreamWriter writer = new StreamWriter($"{i}.txt"))
            {
                writer.WriteLine(clear);
            }
            char[] rev = clear.ToCharArray();
            Array.Reverse(rev);
            System.Console.WriteLine(rev);
            File.Delete($"{i}.txt");

            using (StreamWriter writer = new StreamWriter($"{i}.txt"))
            {
                writer.WriteLine(rev);
                addres[i-1] = $"{i}.txt";
            }
        }

        foreach(var item in addres)
        {
                using(StreamReader readtext = new StreamReader(item))
            {
                string readText = readtext.ReadLine();
                System.Console.WriteLine(readText);
            }
        }

    }
    public static string RemoveSpecialCharacters(this string str) {
    StringBuilder sb = new StringBuilder();
    foreach (char c in str) {
        if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ') {
            sb.Append(c);
        }
    }
    return sb.ToString();
    }

    public static string UpperCase(this string srt)
    {
        
        return srt;
    }
}
