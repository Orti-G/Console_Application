/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 2:31 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of GameMechanics.
	/// </summary>
	public class GameMechanics
	{
	    private static int SelectedIndex;
	    private static int TopRight;
	    private static int TR;
	    private static bool Once = false;
	    
		public static void Box()
		{
			Methods method = new Methods();
			int topR = 0;
			int bottomL = 0;
			int bottomR = 0;
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			
			for (int i = 1; i < 10; i++) {
   				method.WriteAt("*",Console.WindowWidth/2 - 5,Console.WindowHeight/2 + i);
   				bottomR = Console.WindowHeight/2 + i;
   			}
   			
   			for (int i = 0; i < 45; i++) {
				method.WriteAt("*",(Console.WindowWidth/2 - 5 )- i,bottomR);
   				bottomL = (Console.WindowWidth/2 - 5 )- i;	
   				
   			}
			
   			
   			for (int i = 1; i < 20; i++) {
   				method.WriteAt("*",bottomL,bottomR - i);
   				topR = bottomR - i;
   				TopRight = topR;
   			}
   			
   			for (int i = 0; i < 45; i++) {
   				method.WriteAt("*",bottomL + i,topR);
   				TR = bottomL + i; 
			}
			
			for (int i = 1; i <= 10; i++) {
   				method.WriteAt("*",Console.WindowWidth/2 - 5,topR + i);
   			}
		}
		
		public static void DisplayText()
		{
			Methods method = new Methods();
			method.BorderBox();
			Box();
			string greetings = "-- GAME MECHANICS --";
			string pLine1 = "Picture this: Your character is trapped";
			string pLine2 = "inside a box, and here's the deal –";
			string pLine3 = "mistype sends water rising. There is an";
			string pLine4 = "initial required words per minute (WPM)";
			string pLine5 = "per difficulty, which increases by 5 every,";
			string pLine6 = "5 levels. If you do not meet the required";
			string pLine7 = "WPM, the water level will rise based on the";
			string pLine8 = "shortage. The good news is that exceeding";
			string pLine9 = "the needed WPM will decrease the error you've";
			string pLine10 = "made, lowering the water level.";
			string pLine11 = "Uh-oh! If that box gets full, it's game";
			string pLine12 = "over, and your character is in for a";
			string pLine13 = "splashy disaster. Your mission? Save";
			string pLine14 = "your character from drowning by typing";
			string pLine15 = "swiftly and meeting the required WPM";
			string pLine16 = "Remember, you only have 12 of water";
			string pLine17 = "levels, so keep those typos at bay and";
			string pLine18 = "keep your character fresh and dry!";
			method.WriteAt(greetings, Console.WindowWidth/2 - (greetings.Length/2), 3);
			if (!Once)
			{
				for (int i = 0; i < pLine1.Length; i++) {
					method.WriteAt(pLine1[i],TR + 15 + i, TopRight);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine2.Length; i++) {
					method.WriteAt(pLine2[i],TR + 15 + i, TopRight + 1);
					Thread.Sleep(20);
				}
				
				for (int i = 0; i < pLine3.Length; i++) {
					method.WriteAt(pLine3[i],TR + 15 + i, TopRight + 2);
					Thread.Sleep(20);
				}
				
				for (int i = 0; i < pLine4.Length; i++) {
					method.WriteAt(pLine4[i],TR + 15 + i, TopRight + 3);
					Thread.Sleep(20);
				}
				
				for (int i = 0; i < pLine5.Length; i++) {
					method.WriteAt(pLine5[i],TR + 15 + i, TopRight + 4);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine6.Length; i++) {
					method.WriteAt(pLine6[i],TR + 15 + i, TopRight + 5);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine7.Length; i++) {
					method.WriteAt(pLine7[i],TR + 15 + i, TopRight + 6);
					Thread.Sleep(20);
				}
				
				for (int i = 0; i < pLine8.Length; i++) {
					method.WriteAt(pLine8[i],TR + 15 + i, TopRight + 7);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine9.Length; i++) {
					method.WriteAt(pLine9[i],TR + 15 + i, TopRight + 8);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine10.Length; i++) {
					method.WriteAt(pLine10[i],TR + 15 + i, TopRight + 9);
					Thread.Sleep(20);
				}
				Thread.Sleep(1500);
				for (int i = 0; i < pLine11.Length; i++) {
					method.WriteAt(pLine11[i],TR + 15 + i, TopRight + 11);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine12.Length; i++) {
					method.WriteAt(pLine12[i],TR + 15 + i, TopRight + 12);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine13.Length; i++) {
					method.WriteAt(pLine13[i],TR + 15 + i, TopRight + 13);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine14.Length; i++) {
					method.WriteAt(pLine14[i],TR + 15 + i, TopRight + 14);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine15.Length; i++) {
					method.WriteAt(pLine15[i],TR + 15 + i, TopRight + 15);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine16.Length; i++) {
					method.WriteAt(pLine16[i],TR + 15 + i, TopRight + 16);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine17.Length; i++) {
					method.WriteAt(pLine17[i],TR + 15 + i, TopRight + 17);
					Thread.Sleep(20);
				}
				for (int i = 0; i < pLine18.Length; i++) {
					method.WriteAt(pLine18[i],TR + 15 + i, TopRight + 18);
					Thread.Sleep(20);
				}
				
				Once = true;
			}else{
			
			method.WriteAt(pLine1,TR + 15, TopRight);
			method.WriteAt(pLine2,TR + 15, TopRight+1);
			method.WriteAt(pLine3,TR + 15, TopRight+2);
			method.WriteAt(pLine4,TR + 15, TopRight+3);
			method.WriteAt(pLine5,TR + 15, TopRight+4);
			method.WriteAt(pLine6,TR + 15, TopRight+5);
			method.WriteAt(pLine7,TR + 15, TopRight + 6);
			method.WriteAt(pLine8,TR + 15, TopRight+7);
			method.WriteAt(pLine9,TR + 15, TopRight+8);
			method.WriteAt(pLine10,TR + 15, TopRight+9);
			method.WriteAt(pLine11,TR + 15, TopRight+11);
			method.WriteAt(pLine12,TR + 15, TopRight+12);
			method.WriteAt(pLine13,TR + 15, TopRight+13);
			method.WriteAt(pLine14,TR + 15, TopRight+14);
			method.WriteAt(pLine15,TR + 15, TopRight+15);
			method.WriteAt(pLine16,TR + 15, TopRight+16);
			method.WriteAt(pLine17,TR + 15, TopRight+17);
			method.WriteAt(pLine18,TR + 15, TopRight+18);
			}
			BottomMenu(SelectedIndex);
			
		}
		
		public static void BottomMenu(int selectedIndex)
		{
			Methods method = new Methods();
			SelectedIndex = selectedIndex;
			string firstMenu = "  GAME MENU  ";
			string secondMenu = "   NEXT>>  ";
			
			if (SelectedIndex == 0)
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(firstMenu, 8, Console.WindowHeight - 3);
				Console.ResetColor();
				method.WriteAt(secondMenu, Console.WindowWidth - (firstMenu.Length + 4), Console.WindowHeight - 3);
				
			}
			
			else
			{				
				method.WriteAt(firstMenu, 8, Console.WindowHeight - 3);
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(secondMenu, Console.WindowWidth - (firstMenu.Length + 4), Console.WindowHeight - 3);
				Console.ResetColor();
			}
			
			
			
		}
		
		public int RunMenu()
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
					
					if (SelectedIndex == -1)
					{
						SelectedIndex = 1;
						
					}else if (SelectedIndex == 2)
					{
						SelectedIndex = 0;
					}
					
				}while(keyPressed != ConsoleKey.Enter);
				
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
			    	Passage();
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
				

			}
		}
	}
}
