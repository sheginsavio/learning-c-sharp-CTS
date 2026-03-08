namespace JaggedArray //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement the methods here
        public string FindWhoGotMaximumPoints(int[][] points){
            string result ="";
            int[] TotalPoint = new int[points.Length];
            
            for(int i=0;i<points.Length;i++){
                int sum = 0;
                for(int j=0;j<points[i].Length;j++){
                    sum += points[i][j];
                }
                TotalPoint[i] = sum;
            }
            
            int max = -1,maxValue = -1;
            for(int i=0;i<TotalPoint.Length;i++){
                if(TotalPoint[i] > maxValue){
                    maxValue = TotalPoint[i];
                    max = i+1;
                }
            }
            
            result = $"Student {max} got maximum points";
            
            return result;
        }
        
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Console.WriteLine("Enter the number of students");
            int n = Int32.Parse(Console.ReadLine());
            
            int[][] jaggedArray = new int[n][];
            
            for(int i=0;i<n;i++){
                Console.WriteLine($"Enter the number of competitions attended by student {i+1}");
                int comp = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine($"Enter the student {i+1} points");
                
                jaggedArray[i] = new int[comp];
                for(int j=0;j<comp;j++){
                    jaggedArray[i][j] = Int32.Parse(Console.ReadLine());
                }
                
            }
            Program p = new Program();
            Console.WriteLine(p.FindWhoGotMaximumPoints(jaggedArray));
        }
        
    }
}
