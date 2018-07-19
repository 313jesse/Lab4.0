using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int Square, Cube;
                // int userInput;
                Console.WriteLine("Please enter an integer to Square and Cube!");
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Number\tSquare\tCube\t");
                for (int i = 1; i <= userInput; i++)
                {
                    Square = i * i;
                    Cube = i * i * i;
                    Console.WriteLine("{0}\t{1}\t{2}\t", i, Square, Cube);
                }

            }


        }
    }

}           
            
        

      
            
        
            
    
    

    
