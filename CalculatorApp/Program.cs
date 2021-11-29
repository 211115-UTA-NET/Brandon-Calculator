 class Program
{
//string cont = 'y';
//while (continue == 'y' || continue == 'Y')
// {
    static void Main(String[] args)
    {
        //Declare variables and then intialize to zero
        //double fnum = 0; double snum = 0;

        //Display name as my calculator app
        Console.WriteLine("\tMy Calculator App\r");
        Console.WriteLine("-------------------------------\n");
        
        //Prompt the user to type the first number
        //Declare and intialize variables
        Console.WriteLine("Type a number, and press Enter");
        double fnum = double.Parse(Console.ReadLine());

        //Prompt the user to type the second number
        //Declare and intialize variables 
        Console.WriteLine("Type another number, and press Enter");
        double snum = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operator: +, -, *, /");

        //Use a switch statement to swith between operation
        switch (Console.ReadLine())
        {
            case "+":
            Console.WriteLine(fnum + snum);
            break;

            case "-":
            Console.WriteLine(fnum - snum);
            break;

            case "*":
            Console.WriteLine(fnum * snum);
            break;

            case "/":
            if (snum == 0) //without an if statement, ∞ will occur 
            Console.WriteLine("ERROR, can't divide by zero");
            else 
            Console.WriteLine(fnum / snum);
            break;

            default:
            Console.WriteLine("Invalid Operation!");
            break;
        } 
        //Wait for the user to respond before closing
        Console.Write("Press any key to close My Calculator App"); 
        Console.ReadKey();
    }
 //}
}
    //Console.WriteLine("Result: {0}");
    //Console.WriteLine("Continue?: Press y or n");
    //continue = Console.ReadLine();

    //Console.WriteLine("Thank you for using our calculator. Press any key to exit application.");
