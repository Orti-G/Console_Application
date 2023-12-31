/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 1:51 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace Console_Application
{

	public class GameInterface
	{
		
	    private static int SelectedIndex;	    
	    private static int BottomLeftMbox;
	    private static int TopLeftMbox;
	    private static bool Once = false;
	    

		public static void MiddleBox()
		{
			Methods method = new Methods();
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int midSec = Console.WindowWidth/2;
   			int topLeft = 0;
   			int topRight = 0;
   			int bottomLeft = 0;
   			int midH = 0;
   			
   			//mid to topRight
   			for (int i = 0; i<14; i++)
   			{
   				method.WriteAt("*", midSec + i, 5);
   				topRight = midSec + i;
   			}
   			
   			//mid to topLeft
   			for (int i = 0; i<15; i++)
   			{
   				method.WriteAt("*", midSec - i, 5);
   				topLeft = midSec - i; 
   				TopLeftMbox = topLeft;
   			}
   			
   			//topLeft to bottomLeft
   			for (int i = 0; i<14; i++)
   			{
   				method.WriteAt("*", topLeft, 5 + i);
   				bottomLeft = 5 + i;
   				BottomLeftMbox = bottomLeft;
   				midH = (bottomLeft + 5)/2;
   			}
   			//topRight to bottomRight
   			for (int i = 0; i<14; i++)
   			{
   				method.WriteAt("*", topRight, 5 + i);
   			}
   			
   			//bottomLeft to to bottomRight
   			for (int i = 0; i<28; i++)
   			{
   				method.WriteAt("*", topLeft + i, bottomLeft);  				
   			}
   			
   			string player = "Your Player";
   			string header = "-- GAME MECHANICS --";
   			string message = "If the box is completely filled with water";
   			string message1 = "It's Game Over";
   			method.WriteAt(player, midSec - player.Length/2, midH);
   			method.WriteAt(header, midSec - header.Length/2, 3);
   			method.WriteAt("Level #", topRight + 10, 8);
   			method.WriteAt("Words: #", topRight + 10, 9);
   			method.WriteAt("Required Wpm: #", topRight + 10, 10);
   			if (!Once)
   			{
	   			for (int i = 0; i < message.Length; i++) 
	   			{
	   				method.WriteAt(message[i], topLeft - (message.Length + 5) + i, midH);
	   				Thread.Sleep(40);
	   			}
	   			Thread.Sleep(1000);
	   			for (int i = 0; i < message1.Length; i++) 
	   			{
	   				method.WriteAt(message1[i], topLeft - (message1.Length/2 + (message.Length/2 + 5)) + i, midH + 1);
	   				Thread.Sleep(40);
	   			}
	   			Thread.Sleep(1000);
   			}else{
   				method.WriteAt(message, topLeft - (message.Length + 5), midH);
   				method.WriteAt(message1, topLeft - (message1.Length/2 + (message.Length/2 + 5)), midH+1);
   			}
   			
   			
   			
   			
		}
		
		public static void WithAnimation()
		{
			Methods method = new Methods();
			if (!Once)
			{
			string prefix = " ";
			string message = "Game Over";
			int i = 0;
   			while(i != 12)
	   			{	
	   				for (int j = 0; j < 26; j++) 
	   				{
	   					Console.BackgroundColor = ConsoleColor.Blue;
	   					method.WriteAt(prefix, (TopLeftMbox + 1 ) + j, (BottomLeftMbox - 1) - i);
	   					
	   					Thread.Sleep(10);
	   				}
					i++;					
	   			}
   			
   			Console.ResetColor();
   			Console.Clear();
			method.BorderBox();
   			method.WriteAt(message,Console.WindowWidth/2 - message.Length/2, Console.WindowHeight/2 - 1) ;
   			Thread.Sleep(2000);
   			BottomMenu(SelectedIndex);
			}
   			
			
   			
//   			Console.Clear();
		}
		public static void TypingArea()
		{
			Methods method = new Methods();
			int halfBorder = Console.WindowHeight/2;
			int topRightborder = 0;
			int lowRightborder = 0;
			
			for (int i = 30; i < Console.WindowWidth - 29; i++)
			{
				method.WriteAt("*", i, halfBorder);
				topRightborder = i;
				
			}
			
			for (int i = 0; i < Console.WindowHeight/2 - 5; i++) {
				method.WriteAt("*", topRightborder, halfBorder+i);
				lowRightborder = halfBorder + i;
				
			}
			
			for (int i = 30; i < Console.WindowWidth - 29; i++) {
				method.WriteAt("*",i, lowRightborder);
				
			}
			
			for (int i = 0; i < Console.WindowHeight/2 - 5; i++)
			{
				method.WriteAt("*", 30, halfBorder + i);
							
			}
			string Words =	"SET OF WORDS TO BE TYPED";
			string typingArea =	"TYPING SPACE";
			method.WriteAt(Words, Console.WindowWidth/2 - Words.Length/2,halfBorder+3);
			method.WriteAt(typingArea, Console.WindowWidth/2 - typingArea.Length/2,halfBorder+10);
		}
		
		public static void DisplayText()
		{
				Methods method = new Methods();
				method.BorderBox();
				TypingArea();
				MiddleBox();
				WithAnimation();
				Once = true;
				BottomMenu(SelectedIndex);
				
				
		}
				
				
		
		
		public static void BottomMenu(int SelectedIndex)
		{
			Methods method = new Methods();
			string firstMenu = "  GAME MENU  ";
			string secondMenu = "  <<BACK   ";
			string thirdMenu = "   NEXT>>  ";
			
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
		
		public int RunMenu()
		{
		ConsoleKey keyPressed;
				do
				{
					
					Console.Clear();
					DisplayText();
					
					
					ConsoleKeyInfo keyInfo = Console.ReadKey(true);
					keyPressed = keyInfo.Key;
					
					if (keyPressed == ConsoleKey.UpArrow)
					{						
						Once = true;
					}
					else if (keyPressed == ConsoleKey.DownArrow)
					{						
						Once = true;
					}
					
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
				GameMechanics page1 = new GameMechanics();
				page1.Passage();
			}else{
				GameMechanics1 page3 = new GameMechanics1();
				page3.Passage();
			}
		}
	}
}
