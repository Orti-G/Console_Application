/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 3:21 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of PlayerName.
	/// </summary>
	public class PlayerName
	{
		
	    private static int SelectedIndex;
	    private static string[] Options = {"Eddh","Jayniell","Mark","NEW PLAYER"};
	    private static string Prefix = "  ";
	    private static string playerName;
	   
	    public static void DisplayText()
		{
	    	Methods method = new Methods();
	    	method.BorderBox();
	    	
	    	 string header = @" ______ _       _______ _     _ _ _______ _______      _______  ______";
	    	string header1 = @"(_____ (_)     (_______) |   | | (_______|_______)    (_______)/ _____)";
	    	string header2 = @" _____) )       _______| |___| | |_     _ _   ___      _______( (____";
	    	string header3 = @"|  ____/ |     |  ___  |_____  | | |   | | | (_  |    |  ___  |\____ \ ";
	    	string header4 = @"| |    | |_____| |   | |_____| | | |   | | |___) |    | |   | |_____) )";
			string header5 = @"|_|    |_______)_|   |_(_______|_|_|   |_|\_____/     |_|   |_(______/ ";
			
			string sub = "-- RECENT --";
			string end = "____________";
			
			method.WriteAt(header,Console.WindowWidth/2 - header1.Length/2, Console.WindowHeight/2 - 13);
			method.WriteAt(header1,Console.WindowWidth/2 - header1.Length/2, Console.WindowHeight/2 - 12);
			method.WriteAt(header2,Console.WindowWidth/2 - header1.Length/2, Console.WindowHeight/2 - 11);
			method.WriteAt(header3,Console.WindowWidth/2 - header1.Length/2, Console.WindowHeight/2 - 10);
			method.WriteAt(header4,Console.WindowWidth/2 - header1.Length/2, Console.WindowHeight/2 - 9);
			method.WriteAt(header5,Console.WindowWidth/2 - header1.Length/2, Console.WindowHeight/2 - 8);
			method.WriteAt(sub,Console.WindowWidth/2 - sub.Length/2, Console.WindowHeight/2 - 4);
	
	    	for (int i = 0; i < 4; i++)
			{
				string currentOption = Options[i];
				
				if (SelectedIndex == i){
					
					Console.ForegroundColor = ConsoleColor.Black;
					Console.BackgroundColor = ConsoleColor.White;
				}else{
					
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Black;
				}				
				method.WriteAt(Prefix + currentOption + Prefix, Console.WindowWidth/2 - (currentOption.Length/2 + Prefix.Length), (Console.WindowHeight/2 - 1) + (i*3));
				
			}
			Console.ResetColor();
			method.WriteAt(end,(Console.WindowWidth/2) - (end.Length/2), (Console.WindowHeight/2 - 1) + 10);
			
			
		}
	    
	    public int RunMenu()
		{
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
						SelectedIndex = 3;
						
					}else if (SelectedIndex == 4)
					{
						SelectedIndex = 0;
					}
					
				}while(keyPressed != ConsoleKey.Enter);
				
			return SelectedIndex;
		}
	    
	    public void Selection(int selected)
	    {
	    	Methods method = new Methods();
	    	string end = "____________";
	    	string message = "Maximum of 8 characters only";
	    	string newPlayer;
	    	
	    	
	    	if (selected == 0)
	    	{
	    		playerName = Options[0];
	    		Difficulty run = new Difficulty();
	    		run.SetDifficulty(playerName);
	    		playerName = "";
	    		
	    	}else if (selected == 1){
	    		playerName = Options[1];
	    		Difficulty run = new Difficulty();
	    		run.SetDifficulty(playerName);
	    		playerName = "";
	    		
	    	}else if (selected == 2){
	    		playerName = Options[2];
	    		Difficulty run = new Difficulty();
	    		run.SetDifficulty(playerName);
	    		playerName = "";
	    			
	    	}
	    	else
	    	{	    		    		
	    		do{	
				    			
	    		Console.Clear();
	    		Prefix = "";
	    		Options[3] = "";
	    		
	    		DisplayText();
	    		method.WriteAt(message,Console.WindowWidth/2 - message.Length/2,(Console.WindowHeight/2 - 1) + 11);	    		
	    		Console.SetCursorPosition(Console.WindowWidth/2 - end.Length/2 + 2, (Console.WindowHeight/2 - 1) + 9);	    		
	    		Console.Write("");
				newPlayer = Console.ReadLine();
				
	    		}while(newPlayer.Length > 8 );
	    		
	    		if ((newPlayer == Options[0] || newPlayer == Options[1]) || (newPlayer == Options[2])) {
					Selection(3);		
				}
	    		for (int i = 0; i < Options.Length - 1; i++) {
	    			Options[i] = Options[i + 1];
	    		}
	    		Options[2] = newPlayer;
	    		Options[3] = "NEW PLAYER";
	    		Prefix = "  ";
	    		
	    		Console.Clear();
	    		int selected1 = RunMenu();
	    		Selection(selected1);
	    		
	    	}	    	
	    }
	}
}
