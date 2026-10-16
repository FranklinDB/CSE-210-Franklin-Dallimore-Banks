class Menu
{
    
        public void ProcessMenu()
    {
        Console.WriteLine("In the menu class");

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            input = int.Parse(Console.Readline())

        } 
    }
}