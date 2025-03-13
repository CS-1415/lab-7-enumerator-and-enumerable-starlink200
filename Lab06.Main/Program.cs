internal class Program
{
    private static void Main(string[] args)
    {
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        bool keepGoing = true;
        printIntro();
        do
        {
            Console.WriteLine("What would you like to do");
            bool validAnswer;
            string userAnswer;
            do
            {
                printOptions();
                userAnswer = Console.ReadLine();
                validAnswer = ValidateAnswer(userAnswer);
            }
            while(!validAnswer);
            switch (userAnswer)
            {
                case "f" or "F":
                    list.AddFirst(AddTo());
                    break;
                case "e" or "E":
                    list.AddLast(AddTo());
                    break;
                case "p" or "P":
                    foreach(var value in list)
                    {
                        Console.WriteLine(value);
                    }
                    break;
                case "x" or "X":
                    keepGoing = false;
                    break;
            }
        }
        while(keepGoing);
    }

    public static void printIntro()
    {
        Console.WriteLine("Hello! This program will allow you to add values to the list, both at the beginning and the end, print all of the values out, and exit the program whenever");
    }

    public static string AddTo()
    {
        Console.WriteLine("What would you like to add to the list");
        return Console.ReadLine();
    }

    public static void printOptions()
    {
        Console.WriteLine("___________________");
        Console.WriteLine("f: add to the beginning");
        Console.WriteLine("e: add to the end");
        Console.WriteLine("p: print out list");
        Console.WriteLine("x: Exit program");
    }
    public static bool ValidateAnswer(string userChoice)
    {
        switch (userChoice)
        {
            case "f":
            case "e":
            case "p":
            case "x":
            case "F":
            case "E":
            case "P":
            case "X":
                return true;
            default:
                return false;
        }
    }
}