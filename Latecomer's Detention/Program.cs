namespace Looping 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implement your code here
            Console.WriteLine("Enter the number of times");
            int n = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the message");
            string str = Console.ReadLine();
            
            for(int i=0;i<n;i++){
                Console.WriteLine(str);
            }
        }
    }
}