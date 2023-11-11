using System;

class Program
{
    static void Main(string[] args)
    {   
        Write write_object = new Write();
        int i = 0;

        while (i != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What was the best part of my day?");
            
            string test2 = (Console.ReadLine());
            i = int.Parse(test2);

            if (i == 1)
            {
                Console.WriteLine("Type your journal entry here:");
                write_object.user_input(Console.ReadLine());
            }
            else if(i == 2)
            {
                Display.DisplayEntry(write_object);
            }
            else if(i == 3)
            {
                Load.LoadJournal(write_object);
            }
            else if(i == 4)
            {
                Save.SaveJournalAsCSV(write_object);
            }
        }
    }
}
