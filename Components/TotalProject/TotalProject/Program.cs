using System;

namespace TotalProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * Jennifer Perry
			 * 11 November 2015
			 * Total Project
			 * Section #01
			*/

			//Calculate the area and perimeter of a rectangle from user prompts

			//Tell the user what we are doing and then ask for width
			Console.WriteLine ("Hello! We are going to find the area and perimeter of a rectangle.\r\nPlease type in a value for the width and hit enter.");

			//Capture user response
			string widthString = Console.ReadLine ();

			//Declare a variable to hold the converted value
			double width;

			//Validate the user is typing in a valid number using a while loop
			while (!double.TryParse (widthString, out width)) {
				//Alert the user to the error
				Console.WriteLine ("Please only type in numbers and do not leave blank.\r\n What is the width of the rectangle?");
				//Recapture the users response in the same variable
				widthString = Console.ReadLine ();
			}

			//Tell the user the width and say thanks and ask for the length
			Console.WriteLine ("Got it! you entered a width of " + width + ". What is the length?");

			//Create a variable to capture the users response
			string lengthString = Console.ReadLine ();

			//Declare the variable to hold the converted value
			double length;

			//Validate using while loop
			while (!double.TryParse (lengthString, out length)) {
				//Alert the user to the error
				Console.WriteLine ("Please only type in numbers and do not leave blank.\r\n What is the length of the rectangle?");
				//Recapture the users response in the same variable
				lengthString = Console.ReadLine ();
			}

			//Tell the user we got the length and tell them next step
			Console.WriteLine ("Thank you! You entered a width of {0} and a length of {1}.\r\nWe will now calculate the perimeter", width, length);

			//Go create a function to calculate the perimeter
			//Function Call the calcPeri method

			//REMEMBER to catch the returned value with a variable and use arguments!
			double perimeter = calcPeri (width, length);

			//Report to user
			Console.WriteLine ("The perimeter of the rectangle is " + perimeter);

			//Create a function to calculate the area
			//Function call it and store the returned value
			double area = calcArea (width, length);

			//Report to the user
			Console.WriteLine ("The area of the rectangle is {0}.", area);


			//Tell the user we want to find the volume and ask for height
			Console.WriteLine ("Let's find the volume if the rectangle was actually a rectangular prism.\r\nWhat is the height?");
			string heightString = Console.ReadLine ();

			//Declare the height variable

			double height;

			//Validate the users response
			while (! double.TryParse (heightString, out height)){
				//Alert the user to the error
				Console.WriteLine ("Please only type in numbers and do not leave blank.\r\n Whwat is the height of the rectangular prism?");
				//Recapture the users response in the same variable
				heightString = Console.ReadLine ();

			}

			//Report to user
			Console.WriteLine("You typed in the height of "+height+". We will now find the volume.");

			//Create another function
			//Function call and save the returned value
			double volume = calcVolume(width, length, height);

			//Final output to user
			Console.WriteLine("The volume of the rectangular prism is {0}.",volume);

			/*
			 * width = 4
			 * length = 5
			 * height = 6
			 * 
			 * computer calculated
			 * perimeter = 18
			 * area = 20
			 * volume = 120
			 * All values are correct and checked with a calculator 

			*/


		}

		public static double calcPeri(double wid, double len){
		
			//Create a variable for perimeter and do the math
			double peri = 2*wid + 2*len;

			//Return the perimeter value
			return peri;


		}
			
		public static double calcArea(double w, double l){
		
			//Do the math and stor in a variable
			double area = w * l;

			//Return to the main method
			return area;
		
		}

		public static double calcVolume(double w, double l, double h){
		
				//Calculate the volume
			double volume = w*l*h;
			
		//Return the volume
		return volume;
		
		}


	}
}
