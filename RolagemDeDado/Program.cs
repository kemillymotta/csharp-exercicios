﻿using System.Security.Cryptography;

Console.WriteLine("--- Rolagem de Dado ---");

Console.Write("Quantas faces? ");
int faces = Convert.ToInt32(Console.ReadLine()!);

int rolagem = RandomNumberGenerator.GetInt32(1, faces +1);
Console.WriteLine($"Rolagem: {rolagem}");
