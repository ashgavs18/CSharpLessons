public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x, int y);

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x+" ,"+y);
        return x + y;
    }
    public int Sub(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x - y;
    }
    public int Mul(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x * y;
    }
    public double Div(double x, double y)
    {
        Console.WriteLine(x + " ," + y);
        return x / y;
    }
    public String GetMode()
    {
        return "X500";
    }

}
public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add);
        MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Mul);
        //MethodHandlerB methodHandlerThree = new MethodHandlerB(mc.Div);
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine(addResult);
        int mulResult = methodHandlerTwo(20, 5);
        Console.WriteLine(mulResult);

    }
    public static void TestTwo()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Mul;
        methodHandlerB(100, 50);


    }

}