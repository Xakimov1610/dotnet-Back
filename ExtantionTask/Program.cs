﻿using System.Runtime.ConstrainedExecution;
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
        System.Console.WriteLine("Ener");
        // int a = int.Parse(Console.ReadLine());
        int a = -12345;
        
       
        System.Console.WriteLine(a.Reverse());
    }
}