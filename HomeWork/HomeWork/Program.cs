
double res;

while (true)
{
    double divider = 2;

    Console.Write("Enter your number: ");
    var val = double.Parse (Console.ReadLine());



    if (val > 0 && val <= 3)
    {
        Console.WriteLine($"{val} is a prime number");
    }

    else
    {  
        while (val > divider)
        {
            res = val % divider;


            if (res == 0)
            {
                Console.WriteLine($"{val} is NOT a prime number");
                break;
            }
            else if (val - divider == 1)
            {
                Console.WriteLine($"{val} is a prime number");
            }
            
            divider++;
        }
        
    }
}

Console.ReadLine();


