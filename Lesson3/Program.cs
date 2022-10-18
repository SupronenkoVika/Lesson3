using Lesson3;

double num1, num2;
double result = 0;
char operation;

while (true)
{
    Console.Clear();

    try
    {
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("The number is incorrect");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Enter operation: ");
    operation = Convert.ToChar(Console.ReadLine());

    switch (operation)
    {
        case '+':
            result = num1 + num2;
            Console.WriteLine("Operation result: " + result);
            break;
        case '-':
            result = num1 - num2;
            Console.WriteLine("Operation result: " + result);
            break;
        case '*':
            result = num1 * num2;
            Console.WriteLine("Operation result: " + result);
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Divisor cannot be zero");
                continue;
            }
            result = num1 / num2;
            Console.WriteLine("Operation result: " + result);
            break;
        default:
            Console.WriteLine("Invalid action. Try again.");
            break;
    }


    QueueRes res = new QueueRes();
    res.AddToQueue(result);
    res.LastResults();
    Console.ReadLine();
}









