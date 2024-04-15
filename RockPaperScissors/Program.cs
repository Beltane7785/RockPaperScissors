string playerOneChoice;
string computerChoice;
int playerScore = 0;
int computerScore = 0;

while (playerScore < 3 && computerScore < 3)
{
    Console.WriteLine("Please choose Rock, Paper, or Scissors");

    playerOneChoice = Console.ReadLine();

    string playerChoice = SetPlayerChoice(playerOneChoice);
    computerChoice = SetComputerChoice();

    Console.WriteLine($"The Player's choice is {playerChoice}. The Computer's choice is {computerChoice}");

    string winner = ChooseWinner(playerChoice, computerChoice);
    
    if (winner == "Player")
    {
        Console.WriteLine($"The Player is the winner! The score is {playerScore} to {computerScore}");
    }

    if (winner == "Computer")
    {
        Console.WriteLine($"The Computer is the winner! The score is {playerScore} to {computerScore}");
    }

    if (winner == "Draw")
    {
        Console.WriteLine($"It is a draw! The score is {playerScore} to {computerScore}");
    }
}

if (playerScore == 3)
{
    Console.WriteLine("The Player wins the match!");
}

if (computerScore == 3)
{
    Console.WriteLine("The Computer wins the match!");
}

string SetPlayerChoice(string playerInput)
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

string SetComputerChoice()
{
    string[] choices = ["Rock", "Paper", "Scissors"];
    Random random = new Random();
    int choiceIndex = random.Next(0, choices.Length);
    return choices[choiceIndex];
}

string ChooseWinner(string playerChoice, string computerChoice)
{
    string winner;

    if (playerChoice == "Rock" && computerChoice == "Scissors")
    {
        playerScore++;
        return winner = "Player";
    }

    if (playerChoice == "Scissors" && computerChoice == "Rock")
    {
        computerScore++;
        return winner = "Computer";
    }

    if (playerChoice == "Rock" && computerChoice == "Paper")
    {
        computerScore++;
        return winner = "Computer";
    }

    if (playerChoice == "Paper" && computerChoice == "Rock")
    {
        playerScore++;
        return winner = "Player";
    }

    if (playerChoice == "Scissors" && computerChoice == "Paper")
    {
        playerScore++;
        return winner = "Player";
    }

    if (playerChoice == "Paper" && computerChoice == "Scissors")
    {
        computerScore++;
        return winner = "Computer";
    }

    return winner = "Draw";
    
}