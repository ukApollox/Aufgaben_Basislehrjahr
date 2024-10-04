using System;
using System.Collections.Generic;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Symbole für das Spiel
            char[] symbols = { '☺', '#', '◄', '&', '§', '$', '£', '♫' };

            // Zufällig erzeugtes Memory-Board
            string[,] board = ErzeugeRandomBoard(symbols);

            // Array zum Speichern, welche Felder aufgedeckt sind
            bool[,] revealed = new bool[4, 4];

            while (true)
            {
                // Memory-Board zeichnen
                ZeichneMemory(board, revealed);

                Console.WriteLine("Geben Sie vier Zahlen ein, z.B. '1224' (für Zeile 1, Spalte 2 und Zeile 2, Spalte 4):");
                string eingabe = Console.ReadLine();

                if (eingabe.Length == 4 &&
                    int.TryParse(eingabe.Substring(0, 1), out int row1) &&
                    int.TryParse(eingabe.Substring(1, 1), out int col1) &&
                    int.TryParse(eingabe.Substring(2, 1), out int row2) &&
                    int.TryParse(eingabe.Substring(3, 1), out int col2))
                {
                    // Array-Index anpassen (der Benutzer denkt 1-basiert, aber Arrays sind 0-basiert)
                    row1--; col1--;
                    row2--; col2--;

                    if (row1 >= 0 && row1 < 4 && col1 >= 0 && col1 < 4 &&
                        row2 >= 0 && row2 < 4 && col2 >= 0 && col2 < 4)
                    {
                        // Aufdecken der Felder
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

        // Funktion zum Erzeugen eines zufälligen Memory-Bretts
        static string[,] ErzeugeRandomBoard(char[] symbols)
        {
            // Jedes Symbol kommt zweimal vor, daher wird die Liste verdoppelt
            List<char> symbolList = new List<char>();
            foreach (char symbol in symbols)
            {
                symbolList.Add(symbol);
                symbolList.Add(symbol);
            }

            // Zufällige Durchmischung der Symbole
            Random rnd = new Random();
            for (int i = 0; i < symbolList.Count; i++)
            {
                int j = rnd.Next(i, symbolList.Count);
                // Symbole vertauschen
                char temp = symbolList[i];
                symbolList[i] = symbolList[j];
                symbolList[j] = temp;
            }

            // 4x4 Spielfeld mit den gemischten Symbolen füllen
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

        // Funktion zum Zeichnen des Memory-Bretts
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

        // Funktion, um zu überprüfen, ob alle Felder aufgedeckt sind
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
