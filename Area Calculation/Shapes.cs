namespace MethodOverloading //DO NOT change the namespace name
{
    public class Shapes //DO NOT change the class name
    {
        //Implement your code here
        public int CalculateArea(int length, int breadth){
            return length*breadth;
        }
        
        public double CalculateArea(double length){
            return length*length;
        }
        
        public float CalculateArea(float breadth, float heigth){
            return 0.5f*breadth*heigth;
        }
    }
}