internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("------CALCULATOR------");
        
        

        bool runCalc = true;
        do
        {
            Console.WriteLine("Select the operation:");
            Console.WriteLine("1 > Add");
            Console.WriteLine("2 > Subtract");
            Console.WriteLine("3 > Multiply");
            Console.WriteLine("4 > Division");
            Console.WriteLine("0 > Exit");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    AddOperation();
                    break;
                case 2:
                    SubtractOperation();
                    break;
                case 3:
                    MultiplyOperation();
                    break;
                case 4:
                    DivisionOperation();
                    break;
                case 0:
                    runCalc = false;
                    Console.WriteLine("Thank you!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        } while (runCalc == true);

        
    }

    public static void AddOperation()
    {
        Console.WriteLine("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        double result = firstNum + secondNum;
        Console.WriteLine($"Your result: {firstNum} + {secondNum} = {result}");

    }
    public static void SubtractOperation()
    {
        Console.WriteLine("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        double result = firstNum - secondNum;
        Console.WriteLine($"Your result: {firstNum} - {secondNum} = {result}");

    }
    public static void MultiplyOperation()
    {
        Console.WriteLine("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        double result = firstNum * secondNum;
        Console.WriteLine($"Your result: {firstNum} * {secondNum} = {result}");

    }
    public static void DivisionOperation()
    {
        Console.WriteLine("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        if(secondNum <= 0)
        {
            Console.WriteLine("You cannot divide by 0");
        } else
        {
            double result = firstNum / secondNum;
            Console.WriteLine($"Your result: {firstNum} / {secondNum} = {result}");
        }   

    }
}