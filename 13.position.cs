using System;
class position{
    public static void Main(string []args){
        Console.Write("Enter array length : ");
        int a=Convert.ToInt32(Console.ReadLine());
        string []word=new string[a];
        string words=Console.ReadLine();
        for(int i=0;i<a;i++){
            word[i]=Console.ReadLine();
        }
        for(int i=0;i<word.Length;i++){
            if(words==word[i]){
                Console.Write(i+1);
            }
            else{
                Console.Write("no");
            }

        }
    }
}