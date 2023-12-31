/*
 * Created by SharpDevelop.
 * User: User
 * Date: 30/12/2023
 * Time: 10:31 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of Credits.
	/// </summary>
	public class Credits
	{
		private static int SelectedIndex;
	    private static bool Once = false;
	    private static int origRow = 0;
	    private static int origCol = 0;
	    
	    public static void WriteAt(string s, int x, int y)
	    {
	        Console.SetCursorPosition(origCol+x, origRow+y);
	        Console.Write(s);
	    }
	    
		public static void DisplayText()
		{
			
			
			string greetings = "-- CREDITS --";
			string pLine1 = "Programmed and designed by ";
			string pLine2 = "Ortigueras Mark Julius L.";
			string pLine3 = "Manambit Jayniell R.";
			string pLine4 = "Dela Peña Eddh V.";
			string pLine5 = "Special thanks to";
			string pLine6 = "Al John Villareal";
			
			int i = Console.WindowHeight;
			
			if (!Once){
				WriteAt(greetings, Console.WindowWidth/2 - (greetings.Length/2), 3);
				Thread.Sleep(2000);
				while(i > Console.WindowHeight/2 - 9){
					Console.Clear();
					
					WriteAt(greetings, Console.WindowWidth/2 - (greetings.Length/2), 3);
					
					WriteAt(pLine1,Console.WindowWidth/2 - (pLine1.Length/2), i - 1);
					
					if (i < Console.WindowHeight - 3) {
						WriteAt(pLine2,Console.WindowWidth/2 - (pLine2.Length/2), i + 1);
					}
					
					if (i < Console.WindowHeight - 5) {
						WriteAt(pLine3,Console.WindowWidth/2 - (pLine3.Length/2), i + 3);
					}
					
					if (i < Console.WindowHeight - 7) {
						WriteAt(pLine4,Console.WindowWidth/2 - (pLine4.Length/2), i + 5);
					}
					
					if (i < Console.WindowHeight - 13) {
						WriteAt(pLine5,Console.WindowWidth/2 - (pLine5.Length/2), i + 11);
					}
					
					if (i < Console.WindowHeight - 15) {
						WriteAt(pLine6,Console.WindowWidth/2 - (pLine6.Length/2), i + 13);
					}
					
					
					Thread.Sleep(800);
					
					i--;
				}
				Once = true;
			}else{
			
				
				WriteAt(greetings, Console.WindowWidth/2 - (greetings.Length/2), 3);
				WriteAt(pLine1,Console.WindowWidth/2 - (pLine1.Length/2), Console.WindowHeight/2 - 9 );
				WriteAt(pLine2,Console.WindowWidth/2 - (pLine2.Length/2), Console.WindowHeight/2 - 7 );
				WriteAt(pLine3,Console.WindowWidth/2 - (pLine3.Length/2), Console.WindowHeight/2 - 5 );
				WriteAt(pLine4,Console.WindowWidth/2 - (pLine4.Length/2), Console.WindowHeight/2 - 3 );
				WriteAt(pLine5,Console.WindowWidth/2 - (pLine5.Length/2), Console.WindowHeight/2 + 3 );
				WriteAt(pLine6,Console.WindowWidth/2 - (pLine6.Length/2), Console.WindowHeight/2 + 5);
			}
			BottomMenu(SelectedIndex);
			
		}
		
		public static void BottomMenu(int selectedIndex)
		{
			Methods method = new Methods();
			SelectedIndex = selectedIndex;
			string firstMenu = "  GAME MENU  ";
			string secondMenu = "   EXIT GAME  ";
			
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
			Once = true;	
			return SelectedIndex;
		}
		
		public void Passage()
		{
			int choice = RunMenu();
			if (choice == 0)
			{
				Once = false;
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
			    	Passage();
			    }
			    		
			}else if (choice == 1){
				Environment.Exit(0);

			}
		}
	}
}
