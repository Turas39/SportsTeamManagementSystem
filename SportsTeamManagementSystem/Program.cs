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

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}