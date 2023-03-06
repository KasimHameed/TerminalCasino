using TerminalCasino;

bool exitApp = false;

Console.WriteLine("Let's flip a coin!");

while (!exitApp)
{
    Console.WriteLine("How many flips?");
    try
    {
        var input = Console.ReadLine();
        if(String.IsNullOrEmpty(input))
        {
            Console.WriteLine("Hey, don't ignore me!\n");
        }
        else if(input == "exit")
        {
            exitApp = true;
        }
        else if(Convert.ToUInt16(input) != 0)
        {
            var coin = new Coin(Convert.ToUInt16(input));
            coin.Flip();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}\n");
    }
}

/*
 * TODO:
 * Welcome message
 * give a starting balance
 * make coin toss bet-able
 */