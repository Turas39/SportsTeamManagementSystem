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

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}