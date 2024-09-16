using System;
class reverse{
    public static void Main(string []args){
        Console.Write("Enter Word : ");
        string reverse=Console.ReadLine();
        Console.Write("The Reversed word is : ");
        for(int i=reverse.Length-1;i>=0;i--){
            Console.Write(reverse[i]);
        }

    }
}