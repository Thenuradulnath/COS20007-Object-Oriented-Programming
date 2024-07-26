using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message firstMessage;
            firstMessage= new Message("Hello World");
            firstMessage.Print();

            Message[] messages= new Message[5];
            messages[0] = new Message("hello there!");
            messages[1] = new Message("hi!");
            messages[2] = new Message("welcome back!");
            messages[3] = new Message("great name!");
            messages[4] = new Message("oh hi!");
            

            Console.Write("Enter name:");
            String userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "thenu" )
            {
                messages[0].Print();    
            }
            else if (userInput.ToLower() == "niketha")
            {
                messages[1].Print();
            }
            else if (userInput.ToLower() == "ash")
            {
                messages[2].Print();
            }
            else if (userInput.ToLower() == "yasith")
            {
                messages[3].Print();
            }
            else 
            {
                messages[4].Print();
            }
            Console.ReadLine();
        }

    }
}