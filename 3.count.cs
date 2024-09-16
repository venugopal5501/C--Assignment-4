using System;
class count
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Word : ");
        string word = Console.ReadLine();
        string[] arr = word.Split(' ');
        int count = arr.Length;
        Console.WriteLine(count);
    }
}