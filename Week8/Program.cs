
class Program
{
    public static void Main()
    {
        // Value type demo
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;

        // modify p2 and print both p1 and p2
        p2.X += 5; 
        p1.Print();
        p2.Print();

        // Reference type demo
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        
        // modify r2 and print both r1 and r2
        r2.Y *= 2;
        r1.Print();
        r2.Print();

        // Boxing demo
        BoxingTester.Test();  

        // The difference is struct = copies the values and creates a new variable in the stack and class = copies the pointer to the object that is stored in the heap
    }
    
}