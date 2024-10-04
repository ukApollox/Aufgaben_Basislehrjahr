//Disclaimer: I made the code with the help of AI.

using System;
using System.Collections.Generic;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { '☺', '#', '◄', '&', '§', '$', '£', '♫' };

            string[,] board = ErzeugeRandomBoard(symbols);

            bool[,] revealed = new bool[4, 4];

            while (true)
            {
                ZeichneMemory(board, revealed);

                Console.WriteLine("Geben Sie vier Zahlen ein, z.B. '1224' (für Zeile 1, Spalte 2 und Zeile 2, Spalte 4):");
                string eingabe = Console.ReadLine();

                if (eingabe.Length == 4 &&
                    int.TryParse(eingabe.Substring(0, 1), out int row1) &&
                    int.TryParse(eingabe.Substring(1, 1), out int col1) &&
                    int.TryParse(eingabe.Substring(2, 1), out int row2) &&
                    int.TryParse(eingabe.Substring(3, 1), out int col2))
                {
                    row1--; col1--;
                    row2--; col2--;

                    if (row1 >= 0 && row1 < 4 && col1 >= 0 && col1 < 4 &&
                        row2 >= 0 && row2 < 4 && col2 >= 0 && col2 < 4)
                    {
                        revealed[row1, col1] = true;
                        revealed[row2, col2] = true;

                        if (board[row1, col1] == board[row2, col2])
                        {
                            Console.WriteLine("Treffer! Die beiden Felder stimmen überein.");
                        }
                        else
                        {
                            Console.WriteLine("Keine Übereinstimmung. Die Felder werden wieder verdeckt.");
                            revealed[row1, col1] = false;
                            revealed[row2, col2] = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Zeilen und Spalten müssen zwischen 1 und 4 liegen.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie genau vier Ziffern ein.");
                }

                if (IsGameOver(revealed))
                {
                    ZeichneMemory(board, revealed);
                    Console.WriteLine("Herzlichen Glückwunsch! Sie haben das Memory-Spiel gewonnen.");
                    break;
                }
            }
        }

        static string[,] ErzeugeRandomBoard(char[] symbols)
        {
            List<char> symbolList = new List<char>();
            foreach (char symbol in symbols)
            {
                symbolList.Add(symbol);
                symbolList.Add(symbol);
            }

            Random rnd = new Random();
            for (int i = 0; i < symbolList.Count; i++)
            {
                int j = rnd.Next(i, symbolList.Count);
                char temp = symbolList[i];
                symbolList[i] = symbolList[j];
                symbolList[j] = temp;
            }

            string[,] board = new string[4, 4];
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = symbolList[index].ToString();
                    index++;
                }
            }

            return board;
        }

        static void ZeichneMemory(string[,] board, bool[,] revealed)
        {
            Console.WriteLine("  1 2 3 4");
            for (int i = 0; i < 4; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 4; j++)
                {
                    if (revealed[i, j])
                    {
                        Console.Write(board[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("? ");
                    }
                }
                Console.WriteLine();
            }
        }

        static bool IsGameOver(bool[,] revealed)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!revealed[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
