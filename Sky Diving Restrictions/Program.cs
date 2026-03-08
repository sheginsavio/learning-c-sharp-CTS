namespace SkyDivingRestrictions 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implement your code here
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your weight in kilograms");
            int weight = int.Parse(Console.ReadLine());
            
            if(age >= 18 && weight < 90){
                Console.WriteLine("You are allowed to go skydiving");
            }else{
                Console.WriteLine("You are not allowed to go skydiving");
            }
            
        }
    }
}