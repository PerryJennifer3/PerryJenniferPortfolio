using System;

namespace Perry_Jennifer_Conditionals_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/*
			 * Jennifer Perry
			 * 12 November 2015
			 * Section #01
			 * Conditionals Assignment
			*/


			//Ask user their name
			Console.WriteLine("Hi! Please Type in your name and hit enter.");

			string userNameString = Console.ReadLine ();

			//Console.WriteLine (string.IsNullOrWhiteSpace(userNameString));

			//Create a conditional to test if user imputed anything
			if(string.IsNullOrWhiteSpace(userNameString)){
				Console.WriteLine ("Please do not leave this blank.");
				userNameString = Console.ReadLine ();

			}

			Console.WriteLine ("Hello "+userNameString+"! Thanks for visiting!");


			//Space Mountain and Big Thunder Mountain Railroad - At least 40 inches to ride
			//Gadgets Go Coaster - At least 35 inches to ride
			//Matterhorn - At least 42 inches to ride

			 //Ask user for height 
			Console.WriteLine("We are going to determine if you are tall enough to ride these roller coasters at disneyland.\r\nHow tall are you in inches?");

			string rideHeightString = Console.ReadLine ();

			//Declare
			float rideHeight;
		
			//Make sure they type in a number using a conditional 
			if(!(float.TryParse(rideHeightString, out rideHeight))){
				
				//Tell user the issue with what they typed in
				Console.WriteLine ("Oops! You typed in something other than a number!\r\nPlease enter how tall you are in inches:");
				rideHeightString = Console.ReadLine ();
				float.TryParse (rideHeightString, out rideHeight);

			}


			//start conditional

			if (rideHeight<35){
				Console.WriteLine ("You can not ride a roller coaster.");



			} else if (rideHeight<40){

				Console.WriteLine ("You can ride Gadgets Go Goaster.");
			} else if (rideHeight<42){

				Console.WriteLine ("You can ride Space Mountain, Big Thunder Mountain, and Gadgets Go Coaster.");
			} else if (rideHeight>=42){

				Console.WriteLine ("You can ride the Matterhorn, Space Mountain, Big Thunder Mountain, and Gadgets Go Coaster");

			}


			//I tested this with my name, and with leaving it blank where it informed me I can't leave it blank.
			//I entered my height and it gave me which rollercoasters I can ride, and I also typed in "car" where it informed me I need to type in a number.

		}
	}
}
