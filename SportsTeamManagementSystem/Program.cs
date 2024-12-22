using System;
using System.Collections.Generic;
using System.Linq;

public interface IPlayer
{
    string Name { get; set; }
    string Position { get; set; }
    int Score { get; set; }

    void UpdateScore(int newScore);
}

public class Player : IPlayer
{
    public string Name { get; set; }
    public string Position { get; set; }
    public int Score { get; set; }

    public Player(string name, string position, int score)
    {
        Name = name;
        Position = position;
        Score = score;
    }

    public void UpdateScore(int newScore)
    {
        Score = newScore;
    }
}

public class Team
{
    private List<IPlayer> players;

    public Team()
    {
        players = new List<IPlayer>();
    }
    
    public void AddPlayer(IPlayer player)
    {
        players.Add(player);
        Console.WriteLine($"Zawodnik {player.Name} został dodany do drużyny.");
    }
    
    public void RemovePlayer(string name)
    {
        var playerToRemove = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (playerToRemove != null)
        {
            players.Remove(playerToRemove);
            Console.WriteLine($"Zawodnik {name} został usunięty z drużyny.");
        }
        else
        {
            Console.WriteLine($"Zawodnika o imieniu {name} nie ma w drużynie.");
        }
    }
    
    public void DisplayTeamStats()
    {
        Console.WriteLine("Statystyki drużyny:");
        foreach (var player in players)
        {
            Console.WriteLine($"Imię: {player.Name}, Pozycja: {player.Position}, Wynik: {player.Score}");
        }
    }
    
    public static double CalculateAverageScore(List<IPlayer> players)
    {
        return players.Any() ? players.Average(p => p.Score) : 0;
    }

    public void DisplayAverageScore()
    {
        double averageScore = CalculateAverageScore(players);
        Console.WriteLine($"Średnia punktów drużyny: {averageScore:F2}");
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}