/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20/12/2023
 * Time: 8:40 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Console_Application
{
	class Program
	{
		private static bool Once = false;
		private static bool Done = false;
		public static void Main()
		{
			
			Console.SetWindowSize(Console.WindowWidth,Console.WindowHeight);
			Console.SetBufferSize(Console.WindowWidth,Console.WindowHeight);
			Console.CursorVisible = false;
			Storage storage = new Storage();
    		
			if (!Done) {
				Instruction display = new Instruction();
				display.ScreenSizeChecker();
				Done = true;
			}
			
	    	if (!Once) {
			Greetings greetings = new Greetings();
			greetings.DisplayText();
				Once = true;
			}
			
			
			
			GameMenu startMenu = new GameMenu();
			int choice = startMenu.Run();
			
			switch (choice)
			{
				case 0:
					GameMechanics page1 = new GameMechanics();
					page1.Passage();
					break;
					
				case 1:
					PlayerName name = new PlayerName();
					int selected = name.RunMenu();
	    			name.Selection(selected);
	    			break;
	    			
	    		case 2:
	    			Credits credits = new Credits();
	    			credits.Passage();
	    			break;
			}
			
			
			Console.ReadKey(true);
		}
	}
}