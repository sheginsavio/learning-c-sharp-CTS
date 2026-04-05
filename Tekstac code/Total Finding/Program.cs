namespace TotalFinding 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implement your code here
            Console.WriteLine("Enter the first number");
            int a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the last number");
            int b = Int32.Parse(Console.ReadLine());
            
            if(a == b){
                Console.WriteLine(a);
            }else{
                int sum = 0;
                for(int i=a; i<=b ; i++){
                    sum += i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}