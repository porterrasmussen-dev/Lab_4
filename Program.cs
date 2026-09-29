Console.Clear();

Console.WriteLine("Players will take turns removing between 1 and three of the remaining sticks.");
Console.WriteLine("The player that removes the last stick loses");
Console.Write("Press any key to begin. ");
Console.ReadKey(true);

Console.Clear();
Console.Write("Who is player 1? ");
string player1 = Console.ReadLine();
Console.Write("Who is player 2? ");
string player2 = Console.ReadLine();

//variable defenitions
int sticksLeft = 20;
int maxSticks = 3;
string currentPlayer = player1;
int stickDisplay = sticksLeft;
int sticksTaken = 1;

for (int i = 0; i < sticksLeft;)
{
    Console.Clear();
    Console.WriteLine($"The current player is {currentPlayer}.");
    Console.Write($"There are {sticksLeft} sticks left.");

    for (int s = 0; s < sticksLeft; s++)
    {
        Console.Write("|");
    }
    Console.WriteLine();

    Console.Write($"{currentPlayer}, how many sticks would you like to take? You may take 1–{maxSticks}. ");
    sticksTaken = int.Parse(Console.ReadLine());
    while(sticksTaken < 1 || sticksTaken > maxSticks)
    {
        Console.WriteLine($"ERROR! You can only take 1–{maxSticks}. Please try again.");
        Console.Write($"{currentPlayer}, how many sticks would you like to take? You may take 1–{maxSticks}. ");
        sticksTaken = int.Parse(Console.ReadLine());
    }
    
    sticksLeft = sticksLeft-sticksTaken;
    if (sticksLeft < maxSticks)
    {
        maxSticks = sticksLeft;
    }
    

    if (currentPlayer == player1)
    {
        currentPlayer = player2;
    }
    else if (currentPlayer == player2)
    {
        currentPlayer = player1;
    }



}
Console.Clear();
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Write($"The winner is {currentPlayer}!    ");
Console.WriteLine(":-)");
Console.BackgroundColor = ConsoleColor.Black;
