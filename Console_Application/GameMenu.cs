/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20/12/2023
 * Time: 11:49 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Console_Application
{
	class Color{
		public static ConsoleColor Colors {get;set;}
	}
	class GameMenu
	{

		private static int SelectedIndex;
		
		
		public void DisplayText()
		{ 
			Methods method = new Methods();
			
			Console.Clear();			

			 string title = @"███████╗ █████╗ ████████╗    ███████╗██╗███╗   ██╗ ██████╗ ███████╗██████╗";
			string title1 = @"██╔════╝██╔══██╗╚══██╔══╝    ██╔════╝██║████╗  ██║██╔════╝ ██╔════╝██╔══██╗";
			string title2 = @"█████╗  ███████║   ██║       █████╗  ██║██╔██╗ ██║██║  ███╗█████╗  ██████╔╝";
			string title3 = @"██╔══╝  ██╔══██║   ██║       ██╔══╝  ██║██║╚██╗██║██║   ██║██╔══╝  ██╔══██╗";
			string title4 = @"██║     ██║  ██║   ██║       ██║     ██║██║ ╚████║╚██████╔╝███████╗██║  ██║";
			string title5 = @"╚═╝     ╚═╝  ╚═╝   ╚═╝       ╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝";
			
			if (SelectedIndex == 0) {
				Color.Colors = ConsoleColor.Cyan;
			}
			
			Console.ForegroundColor = Color.Colors;
			
			method.WriteAt(title,Console.WindowWidth/2 - (title5.Length/2),5);
			method.WriteAt(title1,Console.WindowWidth/2 - (title5.Length/2),6);
			method.WriteAt(title2,Console.WindowWidth/2 - (title5.Length/2) ,7);
			method.WriteAt(title3,Console.WindowWidth/2 - (title5.Length/2),8);
			method.WriteAt(title4,Console.WindowWidth/2 - (title5.Length/2),9);
			method.WriteAt(title5,Console.WindowWidth/2 - (title5.Length/2),10);
			Console.ResetColor();
			Leaderboard();
			Options(SelectedIndex);
			
			
		}
		
		public void Leaderboard()
		{
			
			Methods method = new Methods();
			int halfBorder = Console.WindowHeight/2;
			int topRightborder = 0;
			int lowRightborder = 0;
			for (int i = 0; i < Console.WindowWidth - 8; i++)
					{
						method.WriteAt(".", 4+i, halfBorder);
						topRightborder = 4 + i;		
					}
				
				for (int i = 0; i < Console.WindowHeight/2 - 1; i++) 
					{
						method.WriteAt(".", topRightborder, halfBorder+i);
						lowRightborder = halfBorder + i;						
					}
				
				for (int i = topRightborder; i > 4; i--) 
					{
						method.WriteAt(".", i, lowRightborder);						
					}
				
				for (int i = lowRightborder; i > halfBorder; i--)
					{
						method.WriteAt(".", 4, i);									
					}
			
			string header = "-------------------  LEADER BOARD  -------------------";
			string level = "- EASY -";
			string level1 = "- NORMAL -";
			string level2 = "- HARD -";
			
			method.WriteAt(header, Console.WindowWidth/2 - header.Length/2, halfBorder - 2);
			method.WriteAt(level1, Console.WindowWidth/2 - level1.Length/2 + 1, halfBorder + 2);
			method.WriteAt(level, (Console.WindowWidth)/5 - level.Length/2, halfBorder + 2);
			method.WriteAt(level2, (4 * Console.WindowWidth)/5 - level2.Length/2, halfBorder + 2);
			
		
			string[] rank = {"1st", "2nd", "3rd", "4th", "5th" , "6th" , "7th","8th", "9th", "10th", "11th", "12th" , "13th" , "14th", "15th"};
			string subheader = "Rank";
			string subheader1 = "Name";
			string subheader2 = "Levels";
			string subheader2a = "Completed";
			string subheader3 = "Average";
			string subheader3a = "Wpm";
			
			method.WriteAt(subheader, 9, halfBorder + 4);
			
				for (int i = 0; i < rank.Length; i++) {
					if (halfBorder + 6 + (i*2) >= Console.WindowHeight - 2) {
						break;
					}
				method.WriteAt(rank[i], 9, halfBorder + 6 + (i*2));
				}
			
			
			
			
			//easy
			method.WriteAt(subheader1, (Console.WindowWidth)/5 - level.Length/2 - (subheader1.Length + 4), halfBorder + 4);
			method.WriteAt(subheader2, (Console.WindowWidth)/5 - subheader2.Length/2, halfBorder + 4);
			method.WriteAt(subheader2a, (Console.WindowWidth)/5 - subheader2a.Length/2, halfBorder + 5);
			method.WriteAt(subheader3, (Console.WindowWidth)/5 + level.Length/2 + 4, halfBorder + 4);
			method.WriteAt(subheader3a, (Console.WindowWidth)/5 + level.Length/2 + 6, halfBorder + 5);
			ShowEasy();
			
			//normal
			method.WriteAt(subheader1, Console.WindowWidth/2 - level1.Length/2 + 1 - (subheader1.Length + 4), halfBorder + 4);
			method.WriteAt(subheader2, Console.WindowWidth/2 - subheader2.Length/2 + 1 , halfBorder + 4);
			method.WriteAt(subheader2a, Console.WindowWidth/2 - subheader2a.Length/2 + 1 , halfBorder + 5);
			method.WriteAt(subheader3, Console.WindowWidth/2 + level1.Length/2 + 5, halfBorder + 4);
			method.WriteAt(subheader3a, Console.WindowWidth/2 + level1.Length/2 + 7, halfBorder + 5);
			ShowNormal();
			
			//hard
			method.WriteAt(subheader1, (4 * Console.WindowWidth)/5 - level2.Length/2 - (subheader1.Length + 4), halfBorder + 4);
			method.WriteAt(subheader2, (4 * Console.WindowWidth)/5 - (subheader2.Length/2), halfBorder + 4);
			method.WriteAt(subheader2a, (4 * Console.WindowWidth)/5 - (subheader2a.Length/2), halfBorder + 5);
			method.WriteAt(subheader3, (4 * Console.WindowWidth)/5 + level2.Length/2 + 4, halfBorder + 4);
			method.WriteAt(subheader3a, (4 * Console.WindowWidth)/5 + level2.Length/2 + 6, halfBorder + 5);
			ShowHard();
		}
		
		public void ShowEasy()
		{
			Methods method = new Methods();
			Storage storage = new Storage();
			Storage.LeaderboardEasy = storage.UpdateRanksEasy();
		
			int i = 0; 
	        while(i < 15)
	        {
	        	
	        	try {
	        		var player = Storage.LeaderboardEasy[i];
	        		if (Console.WindowHeight/2 + 6 + (i*2) >= Console.WindowHeight - 2) {
						break;
					}
	        		method.WriteAt(player.Item1, (Console.WindowWidth)/5 - 10 - (player.Item1.Length/2), Console.WindowHeight/2 + 6 + (i * 2));
	        		method.WriteAt(player.Item2, (Console.WindowWidth)/5 - 1, Console.WindowHeight/2 + 6 + (i * 2));
	        		method.WriteAt(player.Item3, (Console.WindowWidth)/5 + 11, Console.WindowHeight/2 + 6 + (i * 2));
	        		i++;
	        	} catch (ArgumentOutOfRangeException) {
	        		
	        		
	        		i++;
	        	}
	        	
	        }
			
		}
		
		public void ShowNormal()
		{
			
			Methods method = new Methods();
			Storage storage = new Storage();
			Storage.LeaderboardNormal = storage.UpdateRanksNormal();
			

			
			int i = 0; 
	        while(i < 15)
	        {
	        	
	        	try {
	        		var player = Storage.LeaderboardNormal[i];
	        		if (Console.WindowHeight/2 + 6 + (i*2) >= Console.WindowHeight - 2) {
						break;
					}
	        		method.WriteAt(player.Item1, Console.WindowWidth/2 - 10 - (player.Item1.Length/2), Console.WindowHeight/2 + 6 + (i * 2));
	        		method.WriteAt(player.Item2, Console.WindowWidth/2, Console.WindowHeight/2 + 6 + (i * 2));
	        		method.WriteAt(player.Item3, Console.WindowWidth/2 + 13, Console.WindowHeight/2 + 6 + (i * 2));
	        		i++;
	        	} catch (ArgumentOutOfRangeException) {		
	        		i++;
	        	}
	        	
	        }
			
		}
		
		public void ShowHard()
		{
			Methods method = new Methods();
			Storage storage = new Storage();
			Storage.LeaderboardHard = storage.UpdateRanksHard();

			int i = 0; 
	        while(i < 15)
	        {
	        	try {
	        		var player = Storage.LeaderboardHard[i];
	        		if (Console.WindowHeight/2 + 6 + (i*2) >= Console.WindowHeight - 2) {
						break;
					}
	        		method.WriteAt(player.Item1, (4 * Console.WindowWidth)/5 - 10 - (player.Item1.Length/2), Console.WindowHeight/2 + 6 + (i * 2));
	        		method.WriteAt(player.Item2, (4 * Console.WindowWidth)/5  - 1, Console.WindowHeight/2 + 6 + (i * 2));
	        		method.WriteAt(player.Item3, (4 * Console.WindowWidth)/5 + 11, Console.WindowHeight/2 + 6 + (i * 2));
	        		i++;
	        	} catch (ArgumentOutOfRangeException) {
					i++;
	     
	        		
	        	}
	        	
	        }
			
		}
		
		public static void Options(int selectedIndex)
		{
			Methods method = new Methods();
			SelectedIndex = selectedIndex;
			string first = "  -- HELP --  ";
			string second = "  -- START --  ";
			string third = "  -- CREDITS --  ";
			
			if (SelectedIndex == 0)
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(first, Console.WindowWidth/2 - (second.Length/2 + 20), 15);
				Console.ResetColor();
				method.WriteAt(second, Console.WindowWidth/2 - (second.Length/2), 15);
				method.WriteAt(third, Console.WindowWidth/2 - (second.Length/2 - 20), 15);
			}
			
			else if (SelectedIndex == 1)
			{
				
				method.WriteAt(first, Console.WindowWidth/2 - (second.Length/2 + 20), 15);
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(second, Console.WindowWidth/2 - (second.Length/2), 15);
				Console.ResetColor();
				method.WriteAt(third, Console.WindowWidth/2 - (second.Length/2 - 20), 15);
			}
			else{
				method.WriteAt(first, Console.WindowWidth/2 - (second.Length/2 + 20), 15);
				method.WriteAt(second, Console.WindowWidth/2 - (second.Length/2), 15);
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(third, Console.WindowWidth/2 - (second.Length/2 - 20), 15);
				Console.ResetColor();
			}
			
			
		}
		
		public int Run()
		{
			Methods method = new Methods();			
			
			
			ConsoleKey keyPressed;
				do
				{
					
					Console.Clear();
					DisplayText();
					
					
					ConsoleKeyInfo keyInfo = Console.ReadKey(true);
					keyPressed = keyInfo.Key;
					
					if (keyPressed == ConsoleKey.RightArrow)
					{
						SelectedIndex ++;
						
						
					}
					else if (keyPressed == ConsoleKey.LeftArrow)
					{
						
						SelectedIndex --;
						
					}
					
					
					if (SelectedIndex == -1){
						SelectedIndex = 2;
					}else if (SelectedIndex == 3)
					{
						SelectedIndex = 0;
					}
					
					if (SelectedIndex == 0) {
						Color.Colors = ConsoleColor.Cyan;
					}else if (SelectedIndex == 1) {
						Color.Colors = ConsoleColor.Red;
					}else{
						Color.Colors = ConsoleColor.Green;
					}
					
				}while(keyPressed != ConsoleKey.Enter);
				
			return SelectedIndex;
			
		}
	}
}
