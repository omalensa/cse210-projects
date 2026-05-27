using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while (true)   // This creates an infinite loop until we choose to quit
        {
            Console.WriteLine("\n=== My Journal Program ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write a new entry
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                myJournal.AddEntry(newEntry);

                Console.WriteLine("Entry added successfully!\n");
            }
            else if (choice == "2")
            {
                // Display journal
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save to file
                Console.Write("Enter filename (e.g. myjournal.txt): ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
            else if (choice == "4")
            {
                // Load from file
                Console.Write("Enter filename to load: ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye! Have a great day.");
                break;   // This exits the while loop
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}