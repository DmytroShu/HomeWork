
int a = 786070;
int b = 1000000;
bool c = true;


//Console.WriteLine( (a - (a / 10000) * 10000) / 1000);
//Console.WriteLine( (a - (a / 1000) * 1000) / 100);
//Console.WriteLine( (a - (a / 100) * 100) / 10);
//Console.WriteLine( (a - (a / 10) * 10) );             Очевидна циклічність


while (c == true)
{
   
    Console.WriteLine(a / b);
    a = a - (a / b * b);
    b = b / 10;
    if (b == 0)
    {
        c = false;

    }
}


Console.ReadLine();