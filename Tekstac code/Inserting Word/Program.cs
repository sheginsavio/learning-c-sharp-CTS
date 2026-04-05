using System.Text;

namespace InsertingWord //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement the methods here
        public StringBuilder WordInserting(StringBuilder word1, char ch, string word2){
            int i=0;
            for(;i<word1.Length;i++){
                if(word1[i] == ch){
                    break;
                }
            }
            word1.Insert(i, word2);
            return word1;
        }
        
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Console.WriteLine("Enter the word 1");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the character to search");
            char ch = Console.ReadLine()[0];
            Console.WriteLine("Enter the word 2");
            string word2 = Console.ReadLine();
            
            Program p = new Program();
            StringBuilder result = p.WordInserting(new StringBuilder(word1), ch, word2);
            
            Console.WriteLine(result);
        }
    }
}
