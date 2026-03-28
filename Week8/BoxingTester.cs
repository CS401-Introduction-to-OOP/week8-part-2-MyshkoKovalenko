static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a; // boxed into object
        int c = (int)b; // unboxed into int

        Console.WriteLine($"{a} {b} {c}"); // printing all values
    }
}