using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            double n1 = balance;

            while (true)
            {
                
                var game = Console.ReadLine();

                if (game == "OutFall 4")
                {
                    n1 = n1 - 39.99;

                    if (n1 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        n1 = n1 + 39.99;                       
                    }

                    else if (n1 > 0)
                    {
                        Console.WriteLine("Bought OutFall 4");                      
                    }   
                    
                    else if (n1 == 0)
                    {
                        Console.WriteLine("Bought OutFall 4");
                        Console.WriteLine("Out of money!");                        
                    }                    
                }

                else if (game == "CS: OG")
                {

                    n1 = n1 - 15.99;

                    if (n1 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        n1 = n1 + 15.99;
                    }

                    else if (n1 > 0)
                    {
                        Console.WriteLine("Bought CS: OG");            
                    }

                    else if (n1 == 0)
                    {

                        Console.WriteLine("Bought CS: OG");
                        Console.WriteLine("Out of money!");
                    }
                }

                else if (game == "Zplinter Zell")
                {

                    n1 = n1 - 19.99;

                    if (n1 < 0)
                    {

                        Console.WriteLine("Too Expensive");
                        n1 = n1 + 19.99;
                    }

                    else if (n1 >0)
                    {
                        Console.WriteLine("Bought Zplinter Zell");          
                    }

                    else if (n1 == 0)
                    {

                        Console.WriteLine("Bought Zplinter Zell");
                        Console.WriteLine("Out of money!");
                    }
                }

                else if (game == "Honored 2")
                {

                    n1 = n1 - 59.99;

                    if (n1 < 0)
                    {

                        Console.WriteLine("Too Expensive");
                        n1 = n1 + 59.99;
                    }

                    else if (n1 >0)
                    {

                        Console.WriteLine("Bought Honored 2");                        
                    }

                    else if (n1 == 0)
                    {

                        Console.WriteLine("Bought Honored 2");
                        Console.WriteLine("Out of money!");
                    }
                }

                else if (game == "RoverWatch")
                {

                    n1 = n1 - 29.99;

                    if (n1 < 0)
                    {

                        Console.WriteLine("Too Expensive");
                        n1 = n1 + 29.99;
                    }

                    else if (n1 >0)
                    {
                        Console.WriteLine("Bought RoverWatch");                  
                    }

                    else if (n1 == 0)
                    {

                        Console.WriteLine("Bought RoverWatch");
                        Console.WriteLine("Out of money!");
                    }
                }

                else if (game == "RoverWatch Origins Edition")
                {

                    n1 = n1 - 39.99;

                    if (n1 < 0)
                    {

                        Console.WriteLine("Too Expensive");
                        n1 = n1 + 39.99;
                    }

                    else if (n1 >0)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");                        
                    }

                    else if (n1 == 0)
                    {

                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        Console.WriteLine("Out of money!");
                    }
                }

                else if (game== "Game Time")
                {

                    if (n1 > 0)
                    {

                        Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", balance - n1, n1);
                        break;
                    }

                    else if (n1==0)
                    {
                        break;
                    }                
                }

                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
