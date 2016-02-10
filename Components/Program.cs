using System;

namespace PerryJenniferExpressionsAssignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*Jennifer Perry
			  5 November 2015
			  Expression Assignment
			*/

			//Asking the user their name

		Console.WriteLine ("Hello, please type your name and press enter to get started!");

			string userName = Console.ReadLine ();
			Console.WriteLine ("Hi "+userName+", welcome to our weightloss calculator!");

			//Ask the user for current weight

			Console.WriteLine ("Lets find out how many weeks it will take to reach your goal! \r\nPlease type in your current weight and press enter:"); 

			//Listening for the answer
			string currentWeight = Console.ReadLine ();

			//Converting the string to a dataType
			int currentNumber = int.Parse (currentWeight);


			//Ask user for their goal weight
			Console.WriteLine("Please enter your goal weight:");
			string goalWeight = Console.ReadLine ();

			int goalNumber = int.Parse (goalWeight);

			//Display how much weight the user wants to lose

			Console.WriteLine ("This is how much weight you plan on losing: ");

			int totalWeightLost = currentNumber - goalNumber;

			Console.WriteLine (totalWeightLost);

			Console.WriteLine ("How much weight do you plan on losing each week?");
			string weeklyNumber = Console.ReadLine ();

			int weeklyLoss = int.Parse (weeklyNumber);

			Console.WriteLine ("This is how many weeks it will take you to reach your goal weight:");
		
			int totalWeeks = totalWeightLost/weeklyLoss;

			Console.WriteLine (totalWeeks);

			Console.WriteLine ("If you lose one more pounds per week, it will take this many weeks:");

			weeklyLoss++;

			int addPound = totalWeightLost / weeklyLoss;

			Console.WriteLine (addPound);

			//I tested this with my starting weight at 150, my goal weight, 120, with a loss of 2 pounds per week.  It answered with 15 weeks to reach my goal weight or 10 weeks if I lose one more pound.

				
		}
	}
} 