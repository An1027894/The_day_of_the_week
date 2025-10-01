//ask user for a number to pick a number 1-7
Console.WriteLine("pleas enter a number 1-7: ");
Console.Write(">> ");
string number = Console.ReadLine() + "";

//start a switch statment. each case represents a condition if it met then it will show a message
switch (number)
{
    case "1":
        Console.WriteLine("Aack! I hate Mondays!");
        //the break statement stop the case from running into the next case and stopping the program from crashing
        break;
    case "2":
        Console.WriteLine("Tuesday!");
        break;
    case "3":
        Console.WriteLine("Hump Daaaay!");
        break;
    case "4":
        Console.WriteLine("Thursday!");
        break;
    case "5":
        Console.WriteLine(" TGIF!");
        break;
    case "6":
        Console.WriteLine("It's the weekend!");
        break;
    case "7":
        Console.WriteLine("It's the weekend!");
        break;
    default:
        Console.WriteLine("Invalid input, please enter a number between 1 and 7.");
        break;
}