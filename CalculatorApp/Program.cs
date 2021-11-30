
       bool go = true;
       char op;
       double fnum = 0; 
       double snum = 0; 

        while (go)
        {
            Console.WriteLine("\n\tSimple Calculator Program\r\r"); //Display name as Simple Calculator Program
            Console.WriteLine("-----------------------------------------------");
                
            Console.WriteLine("Type A Number, And Press Enter");
            fnum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type Another Number, And Press Enter");
            snum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter An Operation, And Press Enter ( +, -, *, / )\r");
    
            op = Console.ReadLine()[0];

            switch ( op )
            {     
                case '+':
                Console.WriteLine(fnum + snum);
                break;

                case '-':
                Console.WriteLine(fnum - snum);
                break;
                
                case '*':
                Console.WriteLine(fnum * snum);
                break;
                
                case '/':
                    if (snum == 0) //without an if statement, ∞ will occur 
                    Console.WriteLine("ERROR, Can't Divide By Zero!");
                    else
                    Console.WriteLine(fnum / snum);
                    break;

                default:
                Console.WriteLine("You Chose An Invalid Operation!"); //display if user iputs an invalid operation
                break;
            }
            Console.Write("Press 'n' And Enter To Exit Simple Calculator Program: Or Any Other Key To Continue: ");
            if (Console.ReadLine() == "n")
            {go = false;}
        }
      