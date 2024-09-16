using System;
class sort
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array length : ");
        int a = Convert.ToInt32(Console.ReadLine());
        string[] word = new string[a];
        Console.Write("Enter word : ");
        for (int i = 0; i < a; i++)
        {
            word[i] = Console.ReadLine();
        }
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0 + i; j < word.Length; j++)
            {
                if (string.Compare(word[i].ToLower(),word[j].ToLower())>0)
                {
                    string temp = word[i];
                    word[i] = word[j];
                    word[j] = temp;
                }
            }
        }
        for(int i=0;i<word.Length;i++){
            Console.Write(word[i]);
        }

    }
}