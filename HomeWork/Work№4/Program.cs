const int a = 5;
int val = 0;
bool found = false;

int[] numbers = new int[a];

    Console.WriteLine("Enter your number:");   

    for (int i = 0; i < a; i++)              //We enter the data
    {
        numbers[i] = int.Parse(Console.ReadLine()); ;
    }

    Console.WriteLine("What number are you interested in?");
    val = int.Parse(Console.ReadLine());


    for (int i = 0; i < a; i++)             //Check for a match
    {
        if (numbers[i] == val)
        {
            Console.WriteLine($"{val} position in the array: {i}");
            found = true;
        }       
    }

    if (found == false)
    {
        Console.WriteLine("Number not found");
    }

Console.WriteLine();