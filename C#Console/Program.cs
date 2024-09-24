namespace C_Console;
using MyCalculatorApp;

class Program
{

    static void Main()
    {
        Calculator calculator = new Calculator();
        Console.WriteLine("Add(int, int): " + calculator.Add(3,4));
        Console.WriteLine("Add(int, int, int): " + calculator.Add(3, 4, 12));
        Console.WriteLine("Add(double, double): " + calculator.Add(3.7, 5.9));
    }

        //Console.WriteLine("Hello, World!");
        //Var.MyVar();
        //Var.DataType();
        //Math.Numbers();
        //Math.Add(200, 350, 456);
        //Input.Hello();
        //If.Numbers(-3);
        //If.Health(87);
        //Loops.ForLoops();
        //Loops.EvenLoops();
        //Loops.HealthLoop();
        //int result2 = Return1.PrintSquare(5);
        //Console.WriteLine(result2);
        //Loops.NestedLoops();
        //Arrays.Array1(args);
        //List.List1(args);
        //Dictionary1.Dict1(args);
        //Dictionary1.Dict2(args);

}
