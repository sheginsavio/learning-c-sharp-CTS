namespace TheRankFinder //DO NOT change the namespace name
{
    public class Program //DO NOT change the class name
    {
        //Implement the methods here
        public int[] FindStudentsRank(int[,] stdMarks){
            int[] TotalSum = new int[stdMarks.GetLength(0)];
            int[] result = new int[stdMarks.GetLength(0)];
            
            for(int i=0;i<stdMarks.GetLength(0);i++){
                int sum=0;
                for(int j=0;j<stdMarks.GetLength(1);j++){
                    sum += stdMarks[i,j];
                }
                TotalSum[i] = sum;
            }
            
            for(int i=0;i<stdMarks.GetLength(0);i++){
                int rank=1;
                for(int j=0;j<stdMarks.GetLength(0);j++){
                    if(TotalSum[j] > TotalSum[i]){
                        rank ++;
                    }
                }
                result[i] = rank;
            }
            
            return result;
        }
        
        public static void Main(string[] args)  //DO NOT change the method signature
        {
            //Implement your code here
            Console.WriteLine("Enter the number of students");
            int n = Int32.Parse(Console.ReadLine());
            
            int[,] arr = new int[n,5];
            
            for(int i=0;i<n;i++){
                Console.WriteLine($"Enter marks for Student {i+1}");
                for(int j=0;j<5;j++){
                    arr[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
            
            Program p = new Program();
            int[] result = p.FindStudentsRank(arr);
            
            // Console.WriteLine(arr);
            for(int i=0;i<n;i++){
                Console.WriteLine($"Rank of student {i+1} is {result[i]}");
            }
            
            
        }
    }
}
