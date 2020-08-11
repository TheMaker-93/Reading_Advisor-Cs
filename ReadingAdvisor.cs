using System;

namespace _ReadingAdvisor
{
	class MainClass
	{
		public static void Main(String[] args)
		{
			Console.SetWindowSize(80, 16);
			Console.SetBufferSize(80, 16);


			String name;
			int age;
			char gender, longYesNo;
			bool likesLong;

			char mainCriterion;
			int secondaryCriterion;

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("************************");
			Console.WriteLine("    READING ADVISOR");
			Console.WriteLine("************************");
			Console.WriteLine();
			Console.ResetColor();

			Console.Write("Hello reader! Please tell me your name: ");
			Console.ForegroundColor = ConsoleColor.Green;
			name = Console.ReadLine();
			Console.ResetColor();

			Console.Write("Pleased to meet you " + name + ". Now please tell me your age ");
			Console.ForegroundColor = ConsoleColor.Green;
			age = Convert.ToInt32(Console.ReadLine());
			Console.ResetColor();

			Console.Write("Are you a male (m) or a female (f) " + name + " (enter F or f or M or m) ");
			Console.ForegroundColor = ConsoleColor.Green;
			gender = Convert.ToChar(Console.ReadLine());
			Console.ResetColor();

			Console.Write("And finally " + name + ", do you like long stories? (enter Y or y or N or n) ");
			Console.ForegroundColor = ConsoleColor.Green;
			longYesNo = Convert.ToChar(Console.ReadLine());
			Console.ResetColor();
			likesLong = (longYesNo == 'y' || longYesNo == 'Y');

			/* CATEGORIZATION */

			/* TODO 1
	 		 * initialize variable mainCriterion with 't', 'c', 'y' or 'a'
	 		 * depending on the user's age. You may use an if-else ladder.
	 		 * */

			// edad

			mainCriterion = 't';

			if (age < 10 && age > 0)
			{
				// imposible to get advise t
				mainCriterion = 't';
			}
			else if (age >= 10 && age <= 14)
			{
				// c
				mainCriterion = 'c';
			}
			else if (age >= 15 && age <= 20)
			{
				mainCriterion = 'y';
			}
			else // mayores de veinte años
			{
				mainCriterion = 'a';
			}



			/* TODO 2 
			 * initialize variable secondaryCriterior with 1, 2, 3 or 4.
			 * Remember that secondaryCriterion takes into account both
			 * the gender (stored as a char in variable gender) 
			 * and the liking for long stories (stored as a boolean in variable
			 * likesLong).
			 * You may use a nested if-else structure
			 * */

			// sexo y preferencia 
			secondaryCriterion = Convert.ToInt32("1");

			if (gender == 'm' || gender == 'M')		// sera hombre
			{
				switch (likesLong)
				{
					case (true):
						secondaryCriterion = Convert.ToInt32("1");
						break;

					case (false):
						secondaryCriterion = Convert.ToInt32("2");
						break;

					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\t ERROR");
						Console.ResetColor();
						break;
				}
			}
			else {									// sera mujer si no es hombre
				switch (likesLong)
				{
					case (true):
						secondaryCriterion = Convert.ToInt32("3");
						break;

					case (false):
						secondaryCriterion = Convert.ToInt32("4");
						break;

					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\t ERROR");
						Console.ResetColor();
						break;
				}
			}

			
			// categorization ends here

			/* GIVE ADVICE */

			Console.WriteLine();

			/* TODO 3 
		 	 * write the part of the code that gives advice. This part has to
		 	 * be based on the contents of the variables mainCriterion and
		 	 * secondaryCriterion. 
		 	 * Remember that you MUST combine one or several if-else
		 	 * structures with one or several switch structures.
		 	 * */

			if (mainCriterion == 't' && secondaryCriterion >= 1 && secondaryCriterion <= 4)
			{
				// imposible to get advise
				Console.WriteLine("You are too young {0}, Ask your parents for advise", name);

			}
			else if (mainCriterion == 'c' && secondaryCriterion >= 1 && secondaryCriterion <= 4)
			{
				// hobit
				Console.WriteLine("Hi {0}, I suggest you the next reading, I'm sure you will like it:", name);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\tTHE HOBBIT by J.R.R Tolkien");
				Console.ResetColor();

			}
			else if (mainCriterion == 'y')
			{
				Console.WriteLine("Hi {0}, I suggest you the next reading, I'm sure you will like it:", name);
				Console.ForegroundColor = ConsoleColor.Yellow;

				switch (secondaryCriterion)
				{
					case (1):
						Console.WriteLine("\tTHE HARRY POTTER series by J.K. Rowling");
						break;

					case (2):
						Console.WriteLine("\tANIMAL FARM by J.Orwell");
						break;

					case (3):
						Console.WriteLine("\tTHE HUNGER GAMES trilogy by S.Colins");
						break;

					case (4):
						Console.WriteLine("\tANIMAL FARM by J.Orwell");
						break;
				}
				Console.ResetColor();
			}
			else if (mainCriterion == 'a')
			{
				Console.WriteLine("Hi {0}, I suggest you the next reading, I'm sure you will like it:", name);
				Console.ForegroundColor = ConsoleColor.Yellow;

				switch (secondaryCriterion)
				{
					case (1):
						Console.WriteLine("\tTHE FOUNDATION series by I.Asimow");
						break;

					case (2):
						Console.WriteLine("\tIN COLD BLOOD by T.Capote");
						break;

					case (3):
						Console.WriteLine("\tTHE PILLARS OF THE EARTH and its sequels by J.Follet");
						break;

					case (4):
						Console.WriteLine("\tOF MICE AND MEN by J.SteinBeck");
						break;
				}
				Console.ResetColor();
			}
			else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\t Something wrong is happening");
				Console.ResetColor();
			}



			/* FAREWELL */

			Console.SetCursorPosition(0, Console.WindowHeight-1);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("please press any key to exit ");
			Console.ReadKey(true);
			Environment.Exit(0);
		}
	}
}
