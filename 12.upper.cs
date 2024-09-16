using System;
class upper
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        word=word.ToUpper();
        for(int i=word.Length-1;i>=0;i--){
            Console.Write(word[i]);
        }
    }
}