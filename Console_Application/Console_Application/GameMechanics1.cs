/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 3:08 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of GameMechanics1.
	/// </summary>
	public class GameMechanics1
	{
	    private static int SelectedIndex;	
	    public static bool Once = false;

		
		public static void DisplayText()
		{
			Methods method = new Methods();
			method.BorderBox();
			string header = "-- GAME MECHANICS --";
			string pLine1 = "This game has three levels of difficulty: Easy, Normal, and Hard. Every level starts with 10 sets of words";
			 string pLine2 = @" ____   ____    ____ __  __";
			string pLine2a = @"| ===| / () \  (_ (_`\ \/ /";
			string pLine2b = @"|____|/__/\__\.__)__) |__| ";
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			
			string pLine3 = "• Every mistypes forbids you on";
			string pLine3a = "typing the next letter";
			string pLine4 = "• Every two mistypes raise the";
			string pLine4a = "water level";
			string pLine5 = "• The initial required WPM";
			string pLine5a = "is 30.";
			
			     
			 string pLine6 = @" __  _  ____ _____  __  __   ____   _";
			string pLine6a = @"|  \| |/ () \| () )|  \/  | / () \ | |__";
			string pLine6b = @"|_|\__|\____/|_|\_\|_|\/|_|/__/\__\|____|";
			string pLine7 = "• Like in Easy, mistypes stops you from";
			string pLine7a = "typing the next letter.";
			string pLine8 = "• However, every single mistype now raises";
			string pLine8a = "the water level.";
			string pLine9 = "• The initial required WPM";
			string pLine9a = "is 25.";
			  


			 string pLine10 = @" _   _   ____  _____  ____";
			string pLine10a = @"| |_| | / () \ | () )| _) \";
			string pLine10b = @"|_| |_|/__/\__\|_|\_\|____/";
			string pLine11 = "• Mistype gets serious – it";
			string pLine11a = "wipes out what you've typed.";
			string pLine12 = "• Each mistype raises the water";
			string pLine12a = "level.";
			string pLine13 = "• The initial required WPM";
			string pLine13a = "is 20.";
			string pLine13b = "";
			
			string pLine14 = "Ready to choose your battle level and conquer the typing game?";
			
			if (!Once)
			{
				int EasyPosition = Console.WindowWidth/5 - (pLine2.Length/2);
				method.WriteAt(header, Console.WindowWidth/2 - (header.Length/2), 3);
				for (int i = 0; i < pLine1.Length; i++) {
					method.WriteAt(pLine1[i],	Console.WindowWidth/2 - (pLine1.Length/2) + i, 8);
					Thread.Sleep(40);
				}
				
				Thread.Sleep(1500);
				method.WriteAt(pLine2, EasyPosition, 12);
				method.WriteAt(pLine2a,EasyPosition, 13);
				method.WriteAt(pLine2b,EasyPosition, 14);
				method.WriteAt(pLine3,EasyPosition - 1, 16);
				method.WriteAt(pLine3a,EasyPosition + 1, 17);
				method.WriteAt(pLine4,EasyPosition - 1, 18);
				method.WriteAt(pLine4a,EasyPosition + 1, 19);
				method.WriteAt(pLine5,EasyPosition - 1, 20);
				method.WriteAt(pLine5a,EasyPosition + 1, 21);
				
				Thread.Sleep(1500);
				int MediumPosition = Console.WindowWidth/2 - (pLine6b.Length/2);
				method.WriteAt(pLine6, MediumPosition, 12);
				method.WriteAt(pLine6a, MediumPosition, 13);
				method.WriteAt(pLine6b, MediumPosition, 14);
				method.WriteAt(pLine7, MediumPosition - 1, 16);
				method.WriteAt(pLine7a, MediumPosition + 1, 17);
				method.WriteAt(pLine8, MediumPosition - 1, 18);
				method.WriteAt(pLine8a, MediumPosition + 1, 19);
				method.WriteAt(pLine9, MediumPosition - 1, 20);
				method.WriteAt(pLine9a, MediumPosition + 1, 21);
				
				Thread.Sleep(1500);
				int HardPosition = ((Console.WindowWidth/2) + (Console.WindowWidth/5) + 2);
				method.WriteAt(pLine10, HardPosition, 12);
				method.WriteAt(pLine10a, HardPosition, 13);
				method.WriteAt(pLine10b, HardPosition, 14);
				
				method.WriteAt(pLine11, HardPosition - 1, 16);
				method.WriteAt(pLine11a, HardPosition + 1, 17);
				method.WriteAt(pLine12, HardPosition - 1, 18);
				method.WriteAt(pLine12a, HardPosition + 1, 19);
				method.WriteAt(pLine13, HardPosition - 1, 20);
				method.WriteAt(pLine13a, HardPosition + 1, 21);
				method.WriteAt(pLine13b, HardPosition + 1, 22);
				
				Thread.Sleep(1500);
				for (int i = 0; i < pLine14.Length; i++) {
					method.WriteAt(pLine14[i], Console.WindowWidth/2 - pLine14.Length/2 + i, 30);
					Thread.Sleep(40);
				}
			Thread.Sleep(1000);
			Once = true;
			}else{
				int EasyPosition = Console.WindowWidth/5 - (pLine2.Length/2);
				method.WriteAt(header, Console.WindowWidth/2 - (header.Length/2), 3);				
				method.WriteAt(pLine1,	Console.WindowWidth/2 - (pLine1.Length/2), 8);

				method.WriteAt(pLine2, EasyPosition, 12);
				method.WriteAt(pLine2a,EasyPosition, 13);
				method.WriteAt(pLine2b,EasyPosition, 14);
				method.WriteAt(pLine3,EasyPosition - 1, 16);
				method.WriteAt(pLine3a,EasyPosition + 1, 17);
				method.WriteAt(pLine4,EasyPosition - 1, 18);
				method.WriteAt(pLine4a,EasyPosition + 1, 19);
				method.WriteAt(pLine5,EasyPosition - 1, 20);
				method.WriteAt(pLine5a,EasyPosition + 1, 21);
							
				int MediumPosition = Console.WindowWidth/2 - (pLine6b.Length/2);
				method.WriteAt(pLine6, MediumPosition, 12);
				method.WriteAt(pLine6a, MediumPosition, 13);
				method.WriteAt(pLine6b, MediumPosition, 14);
				method.WriteAt(pLine7, MediumPosition - 1, 16);
				method.WriteAt(pLine7a, MediumPosition + 1, 17);
				method.WriteAt(pLine8, MediumPosition - 1, 18);
				method.WriteAt(pLine8a, MediumPosition + 1, 19);
				method.WriteAt(pLine9, MediumPosition - 1, 20);
				method.WriteAt(pLine9a, MediumPosition + 1, 21);
							
				int HardPosition = ((Console.WindowWidth/2) + (Console.WindowWidth/5) + 2);
				method.WriteAt(pLine10, HardPosition, 12);
				method.WriteAt(pLine10a, HardPosition, 13);
				method.WriteAt(pLine10b, HardPosition, 14);
				
				method.WriteAt(pLine11, HardPosition - 1, 16);
				method.WriteAt(pLine11a, HardPosition + 1, 17);
				method.WriteAt(pLine12, HardPosition - 1, 18);
				method.WriteAt(pLine12a, HardPosition + 1, 19);
				method.WriteAt(pLine13, HardPosition - 1, 20);
				method.WriteAt(pLine13a, HardPosition + 1, 21);
				method.WriteAt(pLine13b, HardPosition + 1, 22);
									
				method.WriteAt(pLine14, Console.WindowWidth/2 - pLine14.Length/2, 30);			
				
			}
			BottomMenu(SelectedIndex);
			
		}
		
		public static void BottomMenu(int SelectedIndex)
		{
			Methods method = new Methods();
			string firstMenu = "  GAME MENU  ";
			string secondMenu = "  <<BACK   ";
			string thirdMenu = "   START>>  ";
			
			if (SelectedIndex == 0)
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(firstMenu, 8, Console.WindowHeight - 3);
				Console.ResetColor();
				method.WriteAt(secondMenu, Console.WindowWidth - (firstMenu.Length + secondMenu.Length + 4), Console.WindowHeight - 3);
				method.WriteAt(thirdMenu, Console.WindowWidth - (firstMenu.Length + 4), Console.WindowHeight - 3);
			}
			
			else if (SelectedIndex == 1)
			{
				
				method.WriteAt(firstMenu, 8, Console.WindowHeight - 3);
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(secondMenu, Console.WindowWidth - (firstMenu.Length + secondMenu.Length + 4), Console.WindowHeight - 3);
				Console.ResetColor();
				method.WriteAt(thirdMenu, Console.WindowWidth - (firstMenu.Length + 4), Console.WindowHeight - 3);
			}
			else{
				method.WriteAt(firstMenu, 8, Console.WindowHeight - 3);
				method.WriteAt(secondMenu, Console.WindowWidth - (firstMenu.Length + secondMenu.Length + 4), Console.WindowHeight - 3);
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(thirdMenu, Console.WindowWidth - (firstMenu.Length + 4), Console.WindowHeight - 3);
				Console.ResetColor();
			}
			
			
		}
		
		public static int RunMenu()
		{
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
						Once = true;
					}
					else if (keyPressed == ConsoleKey.LeftArrow)
					{
						SelectedIndex --;
						Once = true;
					}
					
					if (SelectedIndex == -1)
					{
						SelectedIndex = 2;
						
					}else if (SelectedIndex == 3)
					{
						SelectedIndex = 0;
					}
					
				}while(keyPressed != ConsoleKey.Enter);
			Once = true;	
			return SelectedIndex;
		}
		
		public void Passage()
		{
			int choice = RunMenu();
			if (choice == 0)
			{
				GameMenu startMenu = new GameMenu();
			    int choice1 = startMenu.Run();
			    if (choice1 == 0)
			    {
			    	GameMechanics page1 = new GameMechanics();
					page1.Passage();
			    }else if (choice1 == 1){
			    	PlayerName name = new PlayerName();
					int selected = name.RunMenu();
	    			name.Selection(selected);
			    }else{
			    	Credits credits = new Credits();
			    	credits.Passage();
			    }
			    		
			}else if (choice == 1){
					GameInterface page2 = new GameInterface();
					page2.Passage();
				
			}else{
				PlayerName name = new PlayerName();
				int selected = name.RunMenu();
	    		name.Selection(selected);
			}
		}
	}
}
