using System;

class length
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Word : ");
        string word=Console.ReadLine();
    
        int count = 0;
        char[] arr = word.ToCharArray();
        foreach (char c in arr){
            count++;
        }
      
        Console.Write(count);
    }
}