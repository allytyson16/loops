using System;

namespace Udemyyyyy
{
	class Program
	{
		static void Main(string[] args)
		{
   //while loop....
			  Console.WriteLine("Hello.");
			  string response = Console.ReadLine();
        
		    while(response == "again")
        {
			  	Console.WriteLine("Hi.");
			  	response = Console.ReadLine();  
         }
//do-while loop....
			  string reply;
		  	do
		  	{
		  		Console.WriteLine("Hello.");
		  		reply = Console.ReadLine();
		  	} while (reply == "again");
       }
     }
  }
      
