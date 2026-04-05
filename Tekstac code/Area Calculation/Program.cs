namespace MethodOverloading //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Shapes p = new Shapes();
            
            Console.WriteLine("1. Calculate area of rectange\n2. Calculate area of Square\n3. Calculate area of triangle");
            Console.WriteLine("Enter your choice");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.WriteLine("Enter the length:");
                    int RectangleLength = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the breadth:");
                    int Rectanglebreadth = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(p.CalculateArea(RectangleLength,Rectanglebreadth));
                    break;
                
                case 2:
                    Console.WriteLine("Enter the length:");
                    double SquareLength = Double.Parse(Console.ReadLine());
                    Console.WriteLine(p.CalculateArea(SquareLength));
                    break;
                    
                case 3:
                    Console.WriteLine("Enter the length:");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the breadth:");
                    float breadth = float.Parse(Console.ReadLine());
                    Console.WriteLine(p.CalculateArea(length,breadth));
                    break;
            }
        }
    }
}
