int GetDigit() {
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        Console.WriteLine("Value incorrect");
    }
}

Func<int, int, float> GetAction()
{
    Console.WriteLine("1 - '+', 2 - '-', 3 - '/', 4 - '*'");
    
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int s) && s >= 1 && s <= 4 )
        {
            return s switch
            {
                1 => (int a, int b) => a + b,
                2 => (int a, int b) => a - b,
                3 => (int a, int b) => (float)a / b,
                4 => (int a, int b) => a * b,
                _ => (int a, int b) => 0
            };
        }
        Console.WriteLine("Operation invalid");
    }
}

while (true)
{
    Console.WriteLine("Input first digit");
    var a = GetDigit();

    Console.WriteLine("Input action");
    var act = GetAction();

    Console.WriteLine("Input second digit");
    var b = GetDigit();

    Console.WriteLine($"Result: {act(a, b)}");

    Console.WriteLine("Once more? (y/n)");
    while (true)
    {
        var key = Console.ReadKey();
        
        if (key.KeyChar == 'y' || key.KeyChar == 'Y')
        {
            Console.Clear();
            break;
        }

        if (key.KeyChar == 'n' || key.KeyChar == 'N')
            return;
    }
}