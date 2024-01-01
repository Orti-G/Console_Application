/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 4:31 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Console_Application
{

	public class Difficulty
	{
	    private static int SelectedIndex;
	    private static string[] Options = {"Easy","Normal","Hard"};

	    
	    public static void DisplayText()
		{
	    	Methods method = new Methods();
	    	method.BorderBox();
	    	 string header = @"  ______ _______ _       _______ _______ _______    ______  _ _______ _ _______ _     _ _    _______ _     _";
	    	string header1 = @" / _____|_______|_)     (_______|_______|_______)  (______)| (_______) (_______|_)   (_|_)  (_______) |   | |";
	    	string header2 = @"( (____  _____   _       _____   _          _       _     _| |_____  | |_       _     _ _       _   | |___| |";
	    	string header3 = @" \____ \|  ___) | |     |  ___) | |        | |     | |   | | |  ___) | | |     | |   | | |     | |  |_____  |";
	    	string header4 = @" _____) ) |_____| |_____| |_____| |_____   | |     | |__/ /| | |     | | |_____| |___| | |_____| |   _____| |";
			string header5 = @"(______/|_______)_______)_______)\______)  |_|     |_____/ |_|_|     |_|\______)\_____/|_______)_|  (_______|";
			
			method.WriteAt(header,Console.WindowWidth/2 - header.Length/2, Console.WindowHeight/2 - 13);
			method.WriteAt(header1,Console.WindowWidth/2 - header.Length/2, Console.WindowHeight/2 - 12);
			method.WriteAt(header2,Console.WindowWidth/2 - header.Length/2, Console.WindowHeight/2 - 11);
			method.WriteAt(header3,Console.WindowWidth/2 - header.Length/2, Console.WindowHeight/2 - 10);
			method.WriteAt(header4,Console.WindowWidth/2 - header.Length/2, Console.WindowHeight/2 - 9);
			method.WriteAt(header5,Console.WindowWidth/2 - header.Length/2, Console.WindowHeight/2 - 8);
			
			for (int i = 0; i < Options.Length; i++)
			{
				string currentOption = Options[i];
				
				if (SelectedIndex == i){
					
					Console.ForegroundColor = ConsoleColor.Black;
					Console.BackgroundColor = ConsoleColor.White;
				}else{
					
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Black;
				}				
				method.WriteAt("   "+currentOption+"   ", Console.WindowWidth/2 - (currentOption.Length/2 + 2), (Console.WindowHeight/2 - 3) + (i*3));
			}
			Console.ResetColor();
			
	    }
	    
  		public int RunMenu()
		{
  		Methods method = new Methods();
	    Console.CursorVisible = false;
		ConsoleKey keyPressed;
				do
				{
					
					Console.Clear();
					DisplayText();
					
					
					ConsoleKeyInfo keyInfo = Console.ReadKey(true);
					keyPressed = keyInfo.Key;
					
					if (keyPressed == ConsoleKey.DownArrow)
					{
						SelectedIndex ++;
						
					}
					else if (keyPressed == ConsoleKey.UpArrow)
					{
						SelectedIndex --;
						
					}
					
					if (SelectedIndex == -1)
					{
						SelectedIndex = 2;
						
					}else if (SelectedIndex == 3)
					{
						SelectedIndex = 0;
					}
					
				}while(keyPressed != ConsoleKey.Enter);
				
			return SelectedIndex;
		}
  		
  		public void SetDifficulty(string playerName)
  		{
  			string PlayerName = playerName;
  			string Difficulty;
  			int choice = RunMenu();
  			
  			if (choice == 0)
  			{
  				Difficulty = Options[0];
  				LoadingScreen play = new LoadingScreen();
  				play.Display();
  				GamePlay start = new GamePlay(PlayerName,Difficulty);
  				start.Start();
  				Difficulty = "";
  				
  			}else if (choice == 1){
  				Difficulty = Options[1];
  				LoadingScreen play = new LoadingScreen();
  				play.Display();
  				GamePlay start = new GamePlay(PlayerName,Difficulty);
  				start.Start();
  				Difficulty = "";
  				
  			}else{
  				Difficulty = Options[2];
  				LoadingScreen play = new LoadingScreen();
  				play.Display();
  				GamePlay start = new GamePlay(PlayerName,Difficulty);
  				start.Start();
  				Difficulty = "";
  			}
  		}
	}
}
