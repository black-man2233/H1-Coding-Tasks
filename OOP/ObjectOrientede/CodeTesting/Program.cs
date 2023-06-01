// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

#pragma warning disable

namespace CodeTesting;

class Program
{
    static void Main(string[] args)
    {
        Program p = new();
        Console.WriteLine(p.IsPalindrome(1121));
    }

    public bool IsPalindrome(int x)
    {
        string news = null;

        for (int j = x.ToString().Length - 1; j > -1; j--)
            news += x.ToString()[j];


        if (x.ToString() == news)
            return true;
        return false;
    }
}