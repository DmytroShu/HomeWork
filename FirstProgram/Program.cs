using System.Text;


bool shouldContinue = true;

while (shouldContinue)
{

    Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Введіть число від 1 до 5");
string a = Console.ReadLine();

if (a == "1")
{
    Console.WriteLine("     ccee88oo\r\n  C8O8O8Q8PoOb o8oo\r\n dOB69QO8PdUOpugoO9bD\r\nCgggbU8OU qOp qOdoUOdcb\r\n      6OuU  /p u gcoUodpP\r\n        \\\\\\//  /douUP\r\n           \\\\\\////\r\n             |||/\\\r\n             |||\\/\r\n             |||||\r\n       .....//||||\\....");

}

else if(a == "2")
{
    Console.WriteLine(" /\\_/\\  \r\n( o.o )\r\n > ^ <\r\n");
}

else if (a == "3")
{
    Console.WriteLine("     ***     ***\r\n   **   ** **   **\r\n  **      *      **\r\n  **             **\r\n   **           **\r\n     **       **\r\n       **   **\r\n         ***\r\n");
}

else if (a == "4")
{
    Console.WriteLine("* * * * * * =========================\r\n * * * * *  =========================\r\n* * * * * * =========================\r\n * * * * *  =========================\r\n* * * * * * =========================\r\n * * * * *  =========================\r\n* * * * * * =========================\r\n=====================================\r\n=====================================\r\n=====================================\r\n");
}

else if (a == "5")
{
    Console.WriteLine("    / \\__\r\n   (    @\\___\r\n   /         O\r\n /   (_____/\r\n/_____/   U\r\n");
}

    else if (a == "вийти")
    {
        shouldContinue = false; // Встановити значення false, щоб вийти з циклу
    }


    else
{
    Console.WriteLine("Ви ввели невідомий текст.");
}

    if (shouldContinue)
    {
        Console.WriteLine("Бажаєте продовжити? (+/-)");
        string continueInput = Console.ReadLine();

        if (continueInput == "+")
        {
            shouldContinue = true; // Встановити значення true, щоб повернутися

        }

        else
        {
            shouldContinue = false; // Встановити значення false, щоб вийти з циклу
        }
    }
}