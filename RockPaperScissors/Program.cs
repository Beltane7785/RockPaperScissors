string playerOneChoice;
string computerChoice;
int playerScore = 0;
int computerScore = 0;

while (playerScore < 2 && computerScore < 2)
{
    Console.WriteLine("Please choose Rock, Paper, or Scissors");

    playerOneChoice = Console.ReadLine();

    Console.WriteLine(PlayerChoice(playerOneChoice));
    Console.WriteLine(ComputerChoice());
    playerScore++;
}

Console.WriteLine("Please choose Rock, Paper, or Scissors");

playerOneChoice = Console.ReadLine();

Console.WriteLine(PlayerChoice(playerOneChoice));
Console.WriteLine(ComputerChoice());


string PlayerChoice(string playerInput)
{
    string[] choices = ["Rock", "Paper", "Scissors"];
    string errorMessage = "You have not chosen a valid option, please choose again.";

    switch (playerInput)
    {
        case "rock": return choices[0];
        case "Rock": return choices[0];
        case "paper": return choices[1];
        case "Paper": return choices[1];
        case "scissors": return choices[2];
        case "Scissors": return choices[2];
        default: return errorMessage;
    }
    
}

string ComputerChoice()
{
    string[] choices = ["Rock", "Paper", "Scissors"];
    Random random = new Random();
    int choiceIndex = random.Next(0, choices.Length);

    return choices[choiceIndex];
}