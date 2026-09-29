Console.Clear();

Console.WriteLine("Players will take turns removing between 1 and three of the remaining sticks.");
Console.WriteLine("The player that removes the last stick loses");
Console.Write("Press any key to begin.");
Console.ReadKey(true);

int sticksLeft = 20;
int maxSticks = 3;
int currentPlayer = 1;
int stickDisplay = sticksLeft;

Console.WriteLine($"The current player is Player {currentPlayer}.");
Console.Write($"There are {sticksLeft} sticks left.");

for (int i = 0; i < sticksLeft; i++)
{
    Console.Write("|");
}
Console.WriteLine();