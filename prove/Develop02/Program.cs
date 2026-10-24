using System;
using System.Collections.Generic;
class Program
{
static void Main(string[] args)
{
    Journal journal = new Journal();
    string choice = "";

    List<string> prompts = new List<string>
{
    "What was the best part of my day?",
    "Who was the most interesting person I interacted with today?",
    "What was the strongest emotion I felt today?",
    "What is something new I learned today?",
    "What is one thing I could improve tomorrow?"
};

Random random = new Random();

    while (choice != "5")
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal");
        Console.WriteLine("4. Load the journal");
        Console.WriteLine("5. Quit");
        Console.Write("Select an option: ");

        choice = Console.ReadLine();

        if (choice == "1")
        {
            int index = random.Next(prompts.Count);
            string prompt = prompts[index];
            
            Console.WriteLine(prompt);
            Console.Write("> ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToShortDateString();

            Entry entry = new Entry(date, prompt, response);
            journal.AddEntry(entry);

            Console.WriteLine("Entry added.");
        }

        else if (choice == "2")
        {
            journal.Display();
        {

}
        }
        else if (choice == "3")
        {
            Console.Write("Enter a filename: ");
            string filename = Console.ReadLine();

            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved.");
        }
        else if (choice == "4")
        {
            Console.Write("Enter a filename: ");
            string filename = Console.ReadLine();

            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded.");
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}
}
