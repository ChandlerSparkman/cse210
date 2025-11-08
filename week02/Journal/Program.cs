// For creativity I implemented functionality that determines if the journal is currently empty if you try to view it with warning, and a system that detects if you try to quit without saving.

using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        FullJournal Journal = new FullJournal();
        string command = "";
        bool quit = false;
        bool saved = true;
        do
        {
            Console.WriteLine("Journal Program\nCommands:\n1. Record Entry\n2. View All Entries\n3. Save to File\n4. Load from File\n5. Quit");
            Console.Write("\nEnter Command: ");

            command = Console.ReadLine();

            if (command == "1")
            {
                Journal.addEntry();
                saved = false;
            }
            else if (command == "2")
            {
                if (Journal._entries.Count == 0)
                {
                    Console.WriteLine("\nNo entries detected! Try recording one or loading some from a file.\n");
                }
                else
                {
                    Journal.printJournal();
                }
            }
            else if (command == "3")
            {
                Journal.savetoFile();
                saved = true;
            }
            else if (command == "4")
            {
                if (saved == false)
                {
                    Console.Write("\nWARNING: Current entries not saved. Would you like to save them before loading a new file? (y/n): ");
                    command = Console.ReadLine();

                    if (command == "y")
                    {
                        Journal.savetoFile();
                    }
                    else
                    {
                        Console.WriteLine("\nCurrent entries discarded.\n");
                    }
                }
                Journal.loadfromFile();
                saved = true;
            }
            else if (command == "5")
            {
                if (saved == false)
                {
                    Console.Write("\nWARNING: Current entries not saved. Would you like to save them before you quit? (y/n): ");
                    command = Console.ReadLine();

                    if (command == "y")
                    {
                        Journal.savetoFile();
                    }
                    else
                    {
                        Console.WriteLine("\nCurrent entries discarded.\n");
                    }
                }
                Console.WriteLine("\nQuitting...");
                quit = true;
            }
            else
            {
                Console.WriteLine("\nERROR: Command not recognized. Please try again.\n");
            }
        } while (quit == false);
    }
}