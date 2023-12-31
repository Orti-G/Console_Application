/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 4:46 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
namespace Console_Application
{

	public class GamePlay
	{
		public string PlayerName;
		public static string Difficulty;
		private static int TopRight;
		private static int Level = 1;
		private static int Words = 10;
		private static double Wpm;
		private static int RequiredWpm;
		private static int Mistake = 0;
		private static int WpmPenalty = 0;
		private static bool Once = false;
		private static bool Once1 = false;
		private static bool countDown = false;
		private  string setOfWords = "";
		private static string setOfWords1 = "";
		private static int BottomLeftMbox;
	    private static int TopLeftMbox;
	    private static double TimeTakenInterrupted;
	    private static List<double> CollectedWpm = new List<double>();
	    private static int SelectedOption;
	    
	    private static double AverageWpm;
		
	
	   
	    
	    
		public GamePlay(string name, string difficulty)
		{
			PlayerName = name;
			Difficulty = difficulty;
			
			if (Difficulty == "Easy")
			{
				RequiredWpm = 30;
			}else if (Difficulty == "Normal"){
				RequiredWpm = 25;
			}else{
				RequiredWpm = 20;
			}
			
			if (PlayerName == "Kawasaki") {
				Level = 25;
			}
		}
		public void Start()
		{
			if (Difficulty == "Easy")
			{
				StartEasy();
				
			}else if (Difficulty == "Normal"){
				
				StartNormal();
				
			}else{
				
				StartHard();
			}
		}
		
		public void StartEasy()
		{
			Methods method = new Methods();
			var stopwatch = new Stopwatch();
			
			Display();
			PenaltyEasy();
			
				int i = 0;				
		        do
		        {
		        	stopwatch.Start();
		            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		            char input = keyInfo.KeyChar;
					

		            if (input == setOfWords[i])
		            {
		            	
		            	method.WriteAt(input,Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 8);		            	
		            	Storage.Input.Add(input);
		            	method.WriteAt("_", Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 4);
		            	Storage.Censorship.Add("_");
		                i++;
		            }
		            else
		            {		            		
			            TimeTakenInterrupted = method.SimulateOperations(stopwatch);			          
			            Mistake++;
			            Display();
			            PenaltyEasy();   
			        }
				}while(i != setOfWords.Length);
		        
		        if (setOfWords1 != "") {
		        	int j = 0;
		        	do
			        {
			            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			            char input = keyInfo.KeyChar;
						
			            // Check if the typed character matches the expected character in the text
			            if (input == setOfWords1[j])
			            {
			            	method.WriteAt(input,Console.WindowWidth/2 - (setOfWords1.Length/2) + j, Console.WindowHeight/2 + 9);
			            	Storage.Input1.Add(input);
			            	method.WriteAt("_", Console.WindowWidth/2 - (setOfWords1.Length/2) + j, Console.WindowHeight/2 + 5);
		            		Storage.Censorship1.Add("-");
			                j++;
			            
			            }else{
				            TimeTakenInterrupted = method.SimulateOperations(stopwatch); 	
		            		Mistake++;
		            		Display();
		            		PenaltyEasy();
				            }

		        	}while(j != setOfWords1.Length);
		        }
	        stopwatch.Stop();
	        double timeTaken = stopwatch.Elapsed.TotalSeconds;
	        double wpm = ( Words / timeTaken) * 60;
	        Wpm = Math.Round(wpm,0);
	        CollectedWpm.Add(Wpm);
	        CurrentResult(Math.Round(timeTaken,2));
	        Progression();
	        StartEasy();	
		}
		
		public void StartNormal()
		{
			Methods method = new Methods();
			var stopwatch = new Stopwatch();			
			Display();
			Penalty();
			
				int i = 0;				
		        do
		        {
		        	stopwatch.Start();
		            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		            char input = keyInfo.KeyChar;
					
		            if (input == setOfWords[i])
		            {		            	
		            	method.WriteAt(input,Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 8);		            	
		            	Storage.Input.Add(input);
		            	method.WriteAt("_", Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 4);
		            	Storage.Censorship.Add("_");
		                i++;
		                
		            }else{	
			            	TimeTakenInterrupted = method.SimulateOperations(stopwatch);
							Mistake++;
				        	Display();
							Penalty();								
				         }
			            				            	           
				}while(i != setOfWords.Length);

		        
		        if (setOfWords1 != "") {
		        	int j = 0;
		        	do
			        {
			            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			            char input = keyInfo.KeyChar;
							            
			            if (input == setOfWords1[j])
			            {
			            	method.WriteAt(input,Console.WindowWidth/2 - (setOfWords1.Length/2) + j, Console.WindowHeight/2 + 9);
			            	Storage.Input1.Add(input);
			            	method.WriteAt("_", Console.WindowWidth/2 - (setOfWords1.Length/2) + j, Console.WindowHeight/2 + 5);
		            		Storage.Censorship1.Add("-");
			                j++;
			            }else{
				            TimeTakenInterrupted = method.SimulateOperations(stopwatch);
				     		Mistake++;
				            Display();
							Penalty();				            
				        }				            				            	
			            
			            
		        	}while(j != setOfWords1.Length);
		        }
		        
	        stopwatch.Stop();
	        double timeTaken = stopwatch.Elapsed.TotalSeconds;
	        double wpm = ( Words / timeTaken) * 60;
	        Wpm = Math.Round(wpm,0);
	        CollectedWpm.Add(Wpm);
	        CurrentResult(Math.Round(timeTaken,2));
	        Progression();
	        StartNormal();

		        
		}
		
		public void StartHard()
		{
			Methods method = new Methods();
			Storage storage = new Storage();
			SecretEnding start = new SecretEnding();
			var stopwatch = new Stopwatch();			
			Display();
			Penalty();
			if (Level == 26)
			{
				start.Ending();
				Computation();
				storage.HardAddPlayer(PlayerName,Level,AverageWpm);
				Storage.LeaderboardHard = storage.UpdateRanksHard();
				int choice = Options();
			   		switch (choice) {
			   			case 0:
			   				Level = 1;
			   				Words = 10;
			   				Once = false;
			   				Once1 = false;
			   				countDown = false;
			   				Mistake = 0;
			   				WpmPenalty = 0;
			   				setOfWords = "";
							setOfWords1 = "";
							AverageWpm = 0;
							TimeTakenInterrupted = 0;
							Storage.Input.Clear();
							Storage.Input1.Clear();
							Storage.Words.Clear();
							Storage.Censorship.Clear();
							Storage.Censorship1.Clear();
			   				CollectedWpm.Clear();
			   				PlayerName = "";
			   				Difficulty = "";
			   				for (;;) {
			   				Program program = new Program();
			   				Program.Main();
			   				}
			   				
			   			case 1:
			   				Level = 1;
			   				Words = 10;
			   				Once = true;
			   				Once1 = false;
			   				countDown = false;
			   				Mistake = 0;
			   				WpmPenalty = 0;
			   				if (Difficulty == "Easy")
							{
								RequiredWpm = 30;
							}else if (Difficulty == "Normal"){
								RequiredWpm = 25;
							}else{
								RequiredWpm = 20;
							}
			   				setOfWords = "";
							setOfWords1 = "";
							AverageWpm = 0;							
							TimeTakenInterrupted = 0;
							Storage.Input.Clear();
							Storage.Input1.Clear();
							Storage.Words.Clear();
							Storage.Censorship.Clear();
							Storage.Censorship1.Clear();
			   				CollectedWpm.Clear();
			   				Start();
			   				break;
			   		}
			}
			
				int i = 0;				
		        do
		        {
		        	stopwatch.Start();
		            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		            char input = keyInfo.KeyChar;
					
		            if (input == setOfWords[i])
		            {		            	
		            	method.WriteAt(input,Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 8);		            	
		            	Storage.Input.Add(input);
		            	method.WriteAt("_", Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 4);
		            	Storage.Censorship.Add("_");
		                i++;

		            }else{	
			            	TimeTakenInterrupted = method.SimulateOperations(stopwatch);
			            	Storage.Input.Clear();
			            	Storage.Censorship.Clear();
							Mistake++;
				        	Display();
							Penalty();
							i = 0;							
				         }
			            				            	           
				}while(i != setOfWords.Length);

		        
		        if (setOfWords1 != "") {
		        	int j = 0;
		        	do
			        {
			            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			            char input = keyInfo.KeyChar;
							            
			            if (input == setOfWords1[j])
			            {
			            	method.WriteAt(input,Console.WindowWidth/2 - (setOfWords1.Length/2) + j, Console.WindowHeight/2 + 9);
			            	Storage.Input1.Add(input);
			            	method.WriteAt("_", Console.WindowWidth/2 - (setOfWords1.Length/2) + j, Console.WindowHeight/2 + 5);
		            		Storage.Censorship1.Add("-");
			                j++;
			            }else{
				            TimeTakenInterrupted = method.SimulateOperations(stopwatch);
			            	Storage.Input1.Clear();
			            	Storage.Censorship1.Clear();
							Mistake++;
				        	Display();
							Penalty();
							i = 0;					            
				        }				            				            	
			            
			            
		        	}while(j != setOfWords1.Length);
		        }
		        
	        stopwatch.Stop();
	        double timeTaken = stopwatch.Elapsed.TotalSeconds;
	        double wpm = ( Words / timeTaken) * 60;
	        Wpm = Math.Round(wpm,0);
	        CollectedWpm.Add(Wpm);
	        CurrentResult(Math.Round(timeTaken,2));
	        Progression();
	        StartHard();
		        
		}
		

		
		public void PenaltyEasy()
		{
			Methods method = new Methods();
			string prefix = " ";
			int i = 0;
			int combi = Mistake/2 + WpmPenalty;
			
				if (combi < 0)
				{
					combi = 0;			
				}else if (combi > 12){
					combi = 12;
				}		
			while(i != combi)
			{
		   		
		   			for (int j = 0; j < 26; j++)
		   				{
				   			Console.BackgroundColor = ConsoleColor.Blue;
				   			method.WriteAt(prefix, (TopLeftMbox + 1 ) + j, (BottomLeftMbox - 1) - i);	   							   					
			   			}
		   			   				
			  i++;					
	   		}
			Console.ResetColor();
					
			if (combi == 12)
			   {	
					Thread.Sleep(3000); 
					Computation();					
			   		GameOver();
					int choice = Options();
			   		switch (choice) {
			   			case 0:
			   				Level = 1;
			   				Words = 10;
			   				Once = false;
			   				Once1 = false;
			   				countDown = false;
			   				Mistake = 0;
			   				WpmPenalty = 0;
			   				setOfWords = "";
							setOfWords1 = "";			
							TimeTakenInterrupted = 0;
							Storage.Input.Clear();
							Storage.Input1.Clear();
							Storage.Words.Clear();
							Storage.Censorship.Clear();
							Storage.Censorship1.Clear();
			   				CollectedWpm.Clear();
			   				PlayerName = "";
			   				Difficulty = "";
			   				AverageWpm = 0;
			   				for (;;) {
			   				Program program = new Program();
			   				Program.Main();
			   				}
			   				
						case 1:
			   				Level = 1;
			   				Words = 10;
			   				Once = true;
			   				Once1 = false;
			   				countDown = false;
			   				AverageWpm = 0;
			   				Mistake = 0;
			   				WpmPenalty = 0;
			   				if (Difficulty == "Easy")
							{
								RequiredWpm = 30;
							}else if (Difficulty == "Normal"){
								RequiredWpm = 25;
							}else{
								RequiredWpm = 20;
							}
			   				setOfWords = "";
							setOfWords1 = "";			
							TimeTakenInterrupted = 0;
							Storage.Input.Clear();
							Storage.Input1.Clear();
							Storage.Words.Clear();
							Storage.Censorship.Clear();
							Storage.Censorship1.Clear();
			   				CollectedWpm.Clear();
			   				Start();
			   				break;			   				
					}
			   }
		}
		
		public void Penalty()
		{
			Methods method = new Methods();
			
			string prefix = " ";
			int i = 0;
			int combi = Mistake + WpmPenalty;
			
				if (combi < 0)
				{
					combi = 0;			
				}else if (combi > 12){
					combi = 12;
				}
			
   			while(i != combi)
	   			{			
   						for (int j = 0; j < 26; j++) 
	   					{
		   					Console.BackgroundColor = ConsoleColor.Blue;
		   					method.WriteAt(prefix, (TopLeftMbox + 1 ) + j, (BottomLeftMbox - 1) - i);	   							   					
	   					}
					i++;					
	   			}
   			Console.ResetColor();
   			if (combi == 12)
			   {	
					Thread.Sleep(3000);
					Computation();					
			   		GameOver();				   		
			   		int choice = Options();
			   		switch (choice) {
			   			case 0:
			   				Level = 1;
			   				Words = 10;
			   				Once = false;
			   				Once1 = false;
			   				countDown = false;
			   				Mistake = 0;
			   				WpmPenalty = 0;
			   				setOfWords = "";
							setOfWords1 = "";
							AverageWpm = 0;
							TimeTakenInterrupted = 0;
							Storage.Input.Clear();
							Storage.Input1.Clear();
							Storage.Words.Clear();
							Storage.Censorship.Clear();
							Storage.Censorship1.Clear();
			   				CollectedWpm.Clear();
			   				PlayerName = "";
			   				Difficulty = "";
			   				for (;;) {
			   				Program program = new Program();
			   				Program.Main();
			   				}
			   				
			   			case 1:
			   				Level = 1;
			   				Words = 10;
			   				Once = true;
			   				Once1 = false;
			   				countDown = false;
			   				Mistake = 0;
			   				WpmPenalty = 0;
			   				if (Difficulty == "Easy")
							{
								RequiredWpm = 30;
							}else if (Difficulty == "Normal"){
								RequiredWpm = 25;
							}else{
								RequiredWpm = 20;
							}
			   				setOfWords = "";
							setOfWords1 = "";
							AverageWpm = 0;							
							TimeTakenInterrupted = 0;
							Storage.Input.Clear();
							Storage.Input1.Clear();
							Storage.Words.Clear();
							Storage.Censorship.Clear();
							Storage.Censorship1.Clear();
			   				CollectedWpm.Clear();
			   				Start();
			   				break;
			   		}
			   }
		}
   			
				
		public void GameOver()
		{

			Console.Clear();
			Storage storage = new Storage();
			Methods method = new Methods();
			 string title = @"      _____          _____        ______  _______        ______                 _____     ____      ____      ______        _____   ";
			string title1 = @"  ___|\    \     ___|\    \      |      \/       \   ___|\     \           ____|\    \   |    |    |    | ___|\     \   ___|\    \  ";
			string title2 = @" /    /\    \   /    /\    \    /          /\     \ |     \     \         /     /\    \  |    |    |    ||     \     \ |    |\    \";
			string title3 = @"|    |  |____| |    |  |    |  /     /\   / /\     ||     ,_____/|       /     /  \    \ |    |    |    ||     ,_____/||    | |    |";
			string title4 = @"|    |    ____ |    |__|    | /     /\ \_/ / /    /||     \--'\_|/      |     |    |    ||    |    |    ||     \--'\_|/|    |/____/";
			string title5 = @"|    |   |    ||    .--.    ||     |  \|_|/ /    / ||     /___/|        |     |    |    ||    |    |    ||     /___/|  |    |\    \";
			string title6 = @"|    |   |_,  ||    |  |    ||     |       |    |  ||     \____|\       |\     \  /    /||\    \  /    /||     \____|\ |    | |    |";
			string title7 = @"|\ ___\___/  /||____|  |____||\____\       |____|  /|____ '     /|      | \_____\/____/ || \ ___\/___ / ||____ '     /||____| |____|";
			string title8 = @"| |   /____ / ||    |  |    || |    |      |    | / |    /_____/ |       \ |    ||    | / \ |   ||   | / |    /_____/ ||    | |    |";
			string title9 = @" \|___|    | / |____|  |____| \|____|      |____|/  |____|     | /        \|____||____|/   \|___||___|/  |____|     | /|____| |____|";
		   string title10 = @"   \( |____|/    \(      )/      \(          )/       \( |_____|/            \(    )/        \(    )/      \( |_____|/   \(     )/";
		   string title11 = @"    '   )/        '      '        '          '         '    )/                '    '          '    '        '    )/       '     '";
			method.WriteAt(title, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 - 6);
		    method.WriteAt(title1, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 - 5);
		    method.WriteAt(title2, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 - 4);
			method.WriteAt(title3, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 - 3);
		    method.WriteAt(title4, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 - 2);
		    method.WriteAt(title5, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 - 1);
		    method.WriteAt(title6, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2);
			method.WriteAt(title7, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 + 1);
		    method.WriteAt(title8, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 + 2);
		    method.WriteAt(title9, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 + 3);
			method.WriteAt(title10, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 + 4);
		    method.WriteAt(title11, Console.WindowWidth/2 - title6.Length/2, Console.WindowHeight/2 + 5);
			
			if (Difficulty == "Easy")
				{
				  storage.EasyAddPlayer(PlayerName,Level,AverageWpm);
				  Storage.LeaderboardEasy = storage.UpdateRanksEasy();				
				} else if (Difficulty == "Normal"){						
					storage.NormalAddPlayer(PlayerName,Level,AverageWpm);
					Storage.LeaderboardNormal = storage.UpdateRanksNormal();
				}else{
					storage.HardAddPlayer(PlayerName,Level,AverageWpm);
					Storage.LeaderboardHard = storage.UpdateRanksHard();
				}
			
			Thread.Sleep(3000);	
		}
		public int Options()
		{
			Storage storage = new Storage();
			ConsoleKey keyPressed;
			bool hidden = false;
				do
				{
					
					Console.Clear();
					GameResult(SelectedOption);
					if (hidden) {
						DataAnalysis();
					}
					
					ConsoleKeyInfo keyInfo = Console.ReadKey(true);
					keyPressed = keyInfo.Key;
					
					if (keyPressed == ConsoleKey.F1)
					{
						hidden = true;
					}
					
					if (keyPressed == ConsoleKey.RightArrow)
					{
						SelectedOption ++;
						hidden = false;
						
					}
					else if (keyPressed == ConsoleKey.LeftArrow)
					{
						
						SelectedOption --;
						hidden = false;
					}
					
					if (SelectedOption == -1){
						SelectedOption = 1;
					}else if (SelectedOption == 2)
					{
						SelectedOption = 0;
					}
					
				}while(keyPressed != ConsoleKey.Enter);
				
				
				
				
			return SelectedOption;
		}
		
		public void GameResult(int SelectedOption)
		{			  
			Storage storage = new Storage();
 			Methods method = new Methods();
 			
 			 string header = @"      _______  _______  __   __  _______    ______    _______  _______  __   __  ___      _______ ";
 			string header1 = @"     |       ||   _   ||  |_|  ||       |  |    _ |  |       ||       ||  | |  ||   |    |       |    ";
 			string header2 = @"     |    ___||  |_|  ||       ||    ___|  |   | ||  |    ___||  _____||  | |  ||   |    |_     _|	";
 			string header3 = @"/\   |   | __ |       ||       ||   |___   |   |_||_ |   |___ | |_____ |  |_|  ||   |      |   | 	/\";
 			string header4 = @"\/   |   ||  ||       ||       ||    ___|  |    __  ||    ___||_____  ||       ||   |___   |   | 	\/";
 			string header5 = @"     |   |_| ||   _   || ||_|| ||   |___   |   |  | ||   |___  _____| ||       ||       |  |   |		";
 			string header6 = @"     |_______||__| |__||_|   |_||_______|  |___|  |_||_______||_______||_______||_______|  |___|		";
 			
			method.WriteAt(header, Console.WindowWidth/2 - header3.Length/2, 3);
		    method.WriteAt(header1, Console.WindowWidth/2 - header3.Length/2, 4);
		    method.WriteAt(header2, Console.WindowWidth/2 - header3.Length/2, 5);
			method.WriteAt(header3, Console.WindowWidth/2 - header3.Length/2, 6);
		    method.WriteAt(header4, Console.WindowWidth/2 - header3.Length/2, 7);
		    method.WriteAt(header5, Console.WindowWidth/2 - header3.Length/2, 8);
		    method.WriteAt(header6, Console.WindowWidth/2 - header3.Length/2, 9);
		    
		    string playerName = "PLAYER'S NAME: ";
		    string averageWpm = "AVERAGE WPM: ";
		    
		     string easy = @" ____   ____    ____ __  __";
			string easy1 = @"| ===| / () \  (_ (_`\ \/ /";
			string easy2 = @"|____|/__/\__\.__)__) |__| ";
			
			 string normal = @" __  _  ____ _____  __  __   ____   _";
			string normal1 = @"|  \| |/ () \| () )|  \/  | / () \ | |__";
			string normal2 = @"|_|\__|\____/|_|\_\|_|\/|_|/__/\__\|____|";
			
			 string hard = @" _   _   ____  _____  ____";
			string hard1 = @"| |_| | / () \ | () )| _) \";
			string hard2 = @"|_| |_|/__/\__\|_|\_\|____/";
			if(!Once1){
 				Thread.Sleep(1000);
 			}
			method.WriteAt(playerName, (5 * Console.WindowWidth)/8 - playerName.Length + 3, 14);
			
			if(!Once1){
 				Thread.Sleep(1000);
 			}
			
			method.WriteAt(PlayerName, (5 * Console.WindowWidth)/8 + 4, 14);
			if(!Once1){
 				Thread.Sleep(1000);
 			}
			method.WriteAt(averageWpm, (5 * Console.WindowWidth)/8 - averageWpm.Length + 3, 16);
			if(!Once1){
 				Thread.Sleep(1000);
 			}
			
			method.WriteAt(AverageWpm, (5 * Console.WindowWidth)/8 + 4, 16);
			
			
			if(!Once1){
 				Thread.Sleep(1000);
 			}
			
			
			if (Difficulty == "Easy")
			{
				method.WriteAt(easy, (5 * Console.WindowWidth)/8 - easy1.Length/2, 20);
				method.WriteAt(easy1, (5 * Console.WindowWidth)/8 - easy1.Length/2, 21);
				method.WriteAt(easy2, (5 * Console.WindowWidth)/8 - easy1.Length/2, 22);
				
				
			} else if (Difficulty == "Normal"){
				method.WriteAt(normal, (5 * Console.WindowWidth)/8 - normal2.Length/2, 20);
				method.WriteAt(normal1, (5 * Console.WindowWidth)/8 - normal2.Length/2, 21);
				method.WriteAt(normal2, (5 * Console.WindowWidth)/8 - normal2.Length/2, 22);
				
				
			}else{
				method.WriteAt(hard, (5 * Console.WindowWidth)/8 - hard.Length/2, 20);
				method.WriteAt(hard1, (5 * Console.WindowWidth)/8 - hard.Length/2, 21);
				method.WriteAt(hard2, (5 * Console.WindowWidth)/8 - hard.Length/2, 22);
				
			}
			
			 string rank = @"██████   █████  ███    ██ ██   ██";
			string rank1 = @"██   ██ ██   ██ ████   ██ ██  ██";
			string rank2 = @"██████  ███████ ██ ██  ██ █████";
			string rank3 = @"██   ██ ██   ██ ██  ██ ██ ██  ██";
			string rank4 = @"██   ██ ██   ██ ██   ████ ██   ██";
			

			if(!Once1){
 				Thread.Sleep(1000);
 			}
			    method.WriteAt(rank, (5 * Console.WindowWidth)/8 - rank4.Length/2 - 10, 24);
				method.WriteAt(rank1, (5 * Console.WindowWidth)/8 - rank4.Length/2 - 10, 25);
				method.WriteAt(rank2, (5 * Console.WindowWidth)/8 - rank4.Length/2 - 10, 26);
				method.WriteAt(rank3, (5 * Console.WindowWidth)/8 - rank4.Length/2 - 10, 27);
				method.WriteAt(rank4, (5 * Console.WindowWidth)/8 - rank4.Length/2 - 10, 28);
				if(!Once1)
				{
	 				int count = 0;
						while (count < 3) {
							for (int i = 0; i < 70; i++) {
								method.WriteAt(Storage.Ranking[i], (5 * Console.WindowWidth)/8 + 15, 24);
								method.WriteAt(Storage.Ranking[i + 1], (5 * Console.WindowWidth)/8 + 15, 25);
						        method.WriteAt(Storage.Ranking[i + 2], (5 * Console.WindowWidth)/8 + 15, 26);
						        method.WriteAt(Storage.Ranking[i + 3], (5 * Console.WindowWidth)/8 + 15, 27);
						        method.WriteAt(Storage.Ranking[i + 4], (5 * Console.WindowWidth)/8 + 15, 28);
						        Thread.Sleep(1);
							}
							count++;
						}
 				}
				
			 if (Difficulty == "Easy") {
			 	storage.showRankingEasy(PlayerName);
			 }else if (Difficulty == "Normal") {
			 	storage.showRankingNormal(PlayerName);
			 }else{
				storage.showRankingHard(PlayerName);	
			 }
			 
				
 				
 				
			 int bottomRight = (7 * Console.WindowWidth)/16 - 9;
			 int bottomLeft = 0;
			 
			 if(!Once1){
 				Thread.Sleep(1000);
 			}
			 for (int i = 0; i < 41; i++) {
			 	method.WriteAt("*", bottomRight - i, 35);
			 	bottomLeft = bottomRight - i;
			 }
			 if (!(Level == 26 && Difficulty == "Hard")) {
				 for (int i = 35; i > 15; i--) {
				 	method.WriteAt("*", bottomLeft, i);
				 }
			 }
			 
			 for (int i = 0; i < 41; i++) {
			 	method.WriteAt("*", bottomLeft + i, 15);
			 }
			 
			 for (int i = 15; i < 35; i++) {
			 	method.WriteAt("*", bottomRight, i);
			 }
			 
			 if (Level == 26 && Difficulty == "Hard") {
			 
			 string player = @"             :--:    YOH! THANKSS!";
			string player1 = @"            +####*   "   ; 
			string player2 = @"            +####*"    ; 
			string player3 = @"   .         -*#+-::..   "; 
			string player4 = @"   =+++++++++==#*--==+#"   ; 
			string player5 = @"         .     +*    :#.   "; 
			string player6 = @"               -#:   .#:    "; 
			string player7 = @"               .#=    -.   "; 
			string player8 = @"                +*             "; 
			string player9 = @"                +#*:          ..   ";
		   string player10 = @"                **:+*:    .-+*+:   "; 
		   string player11 = @"                #=  :*+-+*+-.      "; 
		   string player12 = @"               :#-    :-.       "; 
		   string player13 = @"               .*=          "; 
		   string player14 = @"                :#:       ";
		   string player15 = @"                  =*.      ";
		   
		   
		   		method.WriteAt(player, bottomRight/5, 19);
				method.WriteAt(player1,bottomRight/5 , 20);
				method.WriteAt(player2,bottomRight/5 , 21);
				method.WriteAt(player3,bottomRight/5 , 22); 	
				method.WriteAt(player4,bottomRight/5 , 23);
				method.WriteAt(player5,bottomRight/5 , 24);
				method.WriteAt(player6,bottomRight/5 , 25);
				method.WriteAt(player7,bottomRight/5 , 26);
				method.WriteAt(player8,bottomRight/5 , 27);
				method.WriteAt(player9,bottomRight/5 , 28);
				method.WriteAt(player10,bottomRight/5 , 29);
				method.WriteAt(player11,bottomRight/5 , 30); 	
				method.WriteAt(player12,bottomRight/5 , 31);
				method.WriteAt(player13,bottomRight/5, 32);
				method.WriteAt(player14,bottomRight/5, 33);
				method.WriteAt(player15,bottomRight/5 , 34);
				
				
			 }else{
				 int midSec = (bottomLeft + bottomRight)/2;
				 string prefix = " ";
				 for (int j = 0; j < 19; j++) {
				 	for (int i = 0; i < 39; i++) {
				 	Console.BackgroundColor = ConsoleColor.Blue;
				 	method.WriteAt(prefix, bottomRight - 1 - i, 34 - j);
				 	}	
				 }
				 Console.ResetColor();
                 
 
				 string player = @"              _.,"; 
				string player1 = @"            .-+"; 
				string player2 = @"           .++:"; 
				string player3 = @"         :*=:-++==**+++_ "; 
				string player4 = @"      . -**+       +=. .-*."; 
				string player5 = @"   .+***+-=++=-     -*-  =+"; 
				string player6 = @"   -*****    .-.     :*:  *="; 
				string player7 = @"    ‘’’’      -*     ++  :*:"; 
				string player8 = @"                :-    :*.  ."; 
				string player9 = @"                       *-";
				
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
				method.WriteAt(player, midSec - player6.Length/2 - 1, 18);
				method.WriteAt(player1,midSec - player6.Length/2 - 1 , 19);
				method.WriteAt(player2,midSec - player6.Length/2 - 1 , 20);
				method.WriteAt(player3,midSec - player6.Length/2 - 1 , 21); 	
				method.WriteAt(player4,midSec - player6.Length/2 - 1 , 22);
				method.WriteAt(player5,midSec - player6.Length/2 - 1 , 23);
				method.WriteAt(player6,midSec - player6.Length/2 - 1 , 24);
				method.WriteAt(player7,midSec - player6.Length/2 - 1 , 25);
				method.WriteAt(player8,midSec - player6.Length/2 - 1 , 26);
				method.WriteAt(player9,midSec - player6.Length/2 - 1 , 27);
				Console.ResetColor();
			 }
			 
			string first = "  ⌂ GAME MENU  ";
			string second = "  PLAY AGAIN |>  ";
			if(!Once1){
 				Thread.Sleep(1000);
 			}
			Once1 = true;
			if (SelectedOption == 0)
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(first, Console.WindowWidth/2, 35);
				Console.ResetColor();
				method.WriteAt(second, Console.WindowWidth/2 + 30, 35);
		
			}else{				
				method.WriteAt(first, Console.WindowWidth/2, 35);
				Console.ForegroundColor = ConsoleColor.Black;
				Console.BackgroundColor = ConsoleColor.White;
				method.WriteAt(second, Console.WindowWidth/2 + 30, 35);
				Console.ResetColor();
			}
			
			
		}
		public void Computation()
		{
		 	double totalWpm = CollectedWpm.Sum();
			double averageWpm;
			int temp;
			if (Level == 26 && Difficulty == "Hard") {
				temp = 25;
			}else{
				temp = Level;
			}
			
				if (temp != CollectedWpm.Count)
				{
					int words = ((Storage.Censorship.Count + Storage.Censorship1.Count) * Words) / (setOfWords.Length + setOfWords1.Length);
					double wpm = (words/TimeTakenInterrupted) * 60;
					averageWpm = (totalWpm + Math.Round(wpm,0))/temp;
					
				}else{
					averageWpm = totalWpm / temp;
				}
				AverageWpm =  Math.Round(averageWpm,0);
				
		}

		public void DataAnalysis()
		{
			Console.Clear();
			double totalWpm = CollectedWpm.Sum();
			int letters = setOfWords.Length + setOfWords1.Length;
			int lettersTyped = Storage.Censorship.Count + Storage.Censorship1.Count;
			Console.WriteLine("Collected Wpm");
			foreach (var wpm in CollectedWpm) {
				Console.Write(wpm + " ");
			}
			Console.WriteLine();
			
			Console.WriteLine("Total Wpm: "+totalWpm);
			Console.WriteLine("Total words on level {0}: {1}",Level,Words);
			Console.WriteLine("Total Letters on level {0}: {1}",Level,letters);
			Console.WriteLine("Letters Typed: " +lettersTyped);
			Console.WriteLine("Timestamp: " + TimeTakenInterrupted);
			                  
			
			
		}
		public void CurrentResult(double time)
		{
				Console.Clear();
				MiddleBox();
				GameMode();				
				CurrentPhase();				
				TypingArea();
				Methods method = new Methods();
				
				 string text = "Number of Mistype/s";
				string text1 = "Total Time Used";
				string text2 = "Words Per Minute";
				string text3 = "Press any key to Continue...";
				
				method.WriteAt(text,Console.WindowWidth/2 - text1.Length/2 - 20 - text.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
				method.WriteAt(text1,Console.WindowWidth/2 - text1.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
				method.WriteAt(text2,Console.WindowWidth/2 + text1.Length/2 + 11,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
				
				method.WriteAt(Mistake,Console.WindowWidth/2 - text1.Length/2 - 20,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
				method.WriteAt(time+"s",Console.WindowWidth/2 - 2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
				method.WriteAt(Wpm,Console.WindowWidth/2 + text1.Length/2 + 11 + text2.Length/2 - 1,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
				if (Difficulty == "Easy") {
					PenaltyEasy();
				}else{
					Penalty();
				}
				
				
				if (Wpm < RequiredWpm)
				{
					
					for (int i = 0; i < 3; i++) {
					Thread.Sleep(1000);
					Console.Clear();
					MiddleBox();
					GameMode();				
					CurrentPhase();				
					TypingArea();
					method.WriteAt(text,Console.WindowWidth/2 - text1.Length/2 - 20 - text.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
					method.WriteAt(text1,Console.WindowWidth/2 - text1.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
					
					method.WriteAt(Mistake,Console.WindowWidth/2 - text1.Length/2 - 20,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
					method.WriteAt(time+"s",Console.WindowWidth/2 - 2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
					if (Difficulty == "Easy") {
					PenaltyEasy();
					}else{
						Penalty();
					}				
					Thread.Sleep(1000);
					
					Console.Clear();
					MiddleBox();
					GameMode();				
					CurrentPhase();				
					TypingArea();
					method.WriteAt(text,Console.WindowWidth/2 - text1.Length/2 - 20 - text.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
					method.WriteAt(text1,Console.WindowWidth/2 - text1.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
					method.WriteAt(text2,Console.WindowWidth/2 + text1.Length/2 + 11,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
					
					method.WriteAt(Mistake,Console.WindowWidth/2 - text1.Length/2 - 20,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
					method.WriteAt(time+"s",Console.WindowWidth/2 - 2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
					method.WriteAt(Wpm,Console.WindowWidth/2 + text1.Length/2 + 11 + text2.Length/2 - 1,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
						if (Difficulty == "Easy") {
						PenaltyEasy();
						}else{
							Penalty();
						}
					}
				}
					WpmPenalty = RequiredWpm - Convert.ToInt32(Wpm);
				
				
				if (Difficulty == "Easy") {
					PenaltyEasy();
				}else{
					Penalty();
				}
				method.WriteAt(text3,Console.WindowWidth/2 - text3.Length/2,(Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) + 4);	
				Console.ReadKey(true);
				
			}
		
		
		
		public void Progression()
		{
			setOfWords = "";
			setOfWords1 = "";
			TimeTakenInterrupted = 0;
	
				Mistake = Mistake + WpmPenalty;
				if (Mistake < 0) {
					Mistake = 0;
				}
			
			WpmPenalty = 0;
			if (Words < 31)
			{
				Words++;
			}
			Level++;
			if (Level % 5 == 0)
			{
				RequiredWpm += 5;
			}
			Storage.Input.Clear();
			Storage.Input1.Clear();
			Storage.Words.Clear();
			Storage.Censorship.Clear();
			Storage.Censorship1.Clear();
		}
		
		
		public void Display()
		{
			if (!Once)
			{	
				Console.Clear();
				Thread.Sleep(1000);
				MiddleBox();
				Thread.Sleep(1000);
				GameMode();
				Thread.Sleep(1000);
				CurrentPhase();
				Thread.Sleep(1000);
				TypingArea();
				Preparatory();
				
			}else{
				Console.Clear();
				MiddleBox();
				GameMode();				
				CurrentPhase();				
				TypingArea();
				CountDown();
				TypingAreaDisplay();		
				
			}
		}
		
		public void TypingAreaDisplay()
		{
			Methods method = new Methods();
			string message = "Type the text below:";
			
			Storage storage = new Storage();
			storage.WordsToType(Words);
			

			if (setOfWords == "")
			{
				for (int i = 0; i < Storage.Words.Count; i++) {
					if (i > 14)
					{
						setOfWords1 += Storage.Words[i];
						
					}else{
						setOfWords += Storage.Words[i];
					}
					
					if (i != Storage.Words.Count - 1 && i < 14)
					{
						setOfWords += " ";
					}else if (i != Storage.Words.Count - 1 && i > 14)
					{
						setOfWords1 += " ";
					}
				}
			}
			method.WriteAt(message, Console.WindowWidth/2 - (message.Length/2), Console.WindowHeight/2 + 2);
			method.WriteAt(setOfWords, Console.WindowWidth/2 - (setOfWords.Length/2), Console.WindowHeight/2 + 4);
			
			for (int i = 0; i < Storage.Censorship.Count; i++) {
				method.WriteAt("_", Console.WindowWidth/2 - (setOfWords.Length/2) + i, Console.WindowHeight/2 + 4);
			}
			
			method.WriteAt(setOfWords1, Console.WindowWidth/2 - (setOfWords1.Length/2), Console.WindowHeight/2 + 5);
			
			for (int i = 0; i < Storage.Censorship1.Count; i++) {
				method.WriteAt("_", Console.WindowWidth/2 - (setOfWords1.Length/2) + i, Console.WindowHeight/2 + 5);
			}
			
			string displayInput = storage.DisplayInput();
			string displayInput1 = storage.DisplayInput1();
			method.WriteAt(displayInput, Console.WindowWidth/2 - (setOfWords.Length/2), Console.WindowHeight/2 + 8);
			method.WriteAt(displayInput1, Console.WindowWidth/2 - (setOfWords1.Length/2), Console.WindowHeight/2 + 9);
		}
		
		public static void MiddleBox()
		{
			Methods method = new Methods();
			int midSec = Console.WindowWidth/2;
   			int topLeft = midSec - 14;
   			TopLeftMbox = topLeft;
   			int topRight = 0;
   			int bottomLeft = 0;
   			
   			for (int i = 0; i<29; i++)
   			{
   				method.WriteAt("*", topLeft + i, 5);
   				if (!Once)
				{
	              Thread.Sleep(30);
	            }
   				topRight = topLeft + i;
   				TopRight = topRight;
   				
   			}
   			
			for (int i = 0; i<14; i++)
   			{
				method.WriteAt("*", topRight, 5 + i);
   				if (!Once)
				{
	              Thread.Sleep(30);
	            };
   				bottomLeft = 5 + i;
   				BottomLeftMbox = bottomLeft;
   				
   			}
			
   			//bottomRight to bottomLeft
   			for (int i = topRight; i>topLeft; i--)
   			{
   				method.WriteAt("*", i, bottomLeft);
   				if (!Once)
				{
	              Thread.Sleep(30);
	            }		
   			}
   			
   			//topLeft to bottomLeft
   			for (int i = bottomLeft; i>5; i--)
   			{
   				method.WriteAt("*", topLeft, i);
   				if (!Once)
				{
	              Thread.Sleep(30);
	            }
	
   			}
   		
   			method.WriteAt(@"       -+=.", topLeft+6, 6);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"  .   -%@%#   .", topLeft+6, 7);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"  =#+--*%#=:-#*.", topLeft+6, 8);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"    :---%+---.", topLeft+6, 9);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"        %-", topLeft+6, 10);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"       .%-", topLeft+6, 11);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"       -%#", topLeft+6, 12);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"      .%+##", topLeft+6, 13);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"      ##  #*", topLeft+6, 14);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"     +%.  -%:", topLeft+6, 15);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"     %+    *#", topLeft+6, 16);
   			if (!Once)
				{
	              Thread.Sleep(50);
	            }
   			method.WriteAt(@"    .+.    .=", topLeft+6, 17);
		}
		
		public static void CurrentPhase()
		{
			Methods method = new Methods();
			method.WriteAt("Level " + Level, TopRight + 10, 8);
			if (!Once)
				{
	              Thread.Sleep(750);
	            }
   			method.WriteAt("Words: " + Words, TopRight + 10, 9);
   			if (!Once)
				{
	              Thread.Sleep(750);
	            }
   			method.WriteAt("Required Wpm: " + RequiredWpm, TopRight + 10, 10);
		}
		
		public static void GameMode()
		{
			Methods method = new Methods();
			 string header = @" __     _  _";
			string header1 = @"|  \ . (_ (_ .  _     | |_      |    _     _ | .";
			string header2 = @"|__/ | |  |  | (_ |_| | |_ \/   |__ (- \/ (- | .";
			string header3 = @"                           /";
			
			 string easy = @" ____   ____    ____ __  __";
			string easy1 = @"| ===| / () \  (_ (_`\ \/ /";
			string easy2 = @"|____|/__/\__\.__)__) |__| ";
			
			 string normal = @" __  _  ____ _____  __  __   ____   _";
			string normal1 = @"|  \| |/ () \| () )|  \/  | / () \ | |__";
			string normal2 = @"|_|\__|\____/|_|\_\|_|\/|_|/__/\__\|____|";
			
			 string hard = @" _   _   ____  _____  ____";
			string hard1 = @"| |_| | / () \ | () )| _) \";
			string hard2 = @"|_| |_|/__/\__\|_|\_\|____/";

            method.WriteAt(header,1,0);
            method.WriteAt(header1,1,1);
            method.WriteAt(header2,1,2);
            method.WriteAt(header3,1,3);
	            if (!Once)
				{
	              Thread.Sleep(750);
	            }
            if (Difficulty == "Easy" )
            {
            	method.WriteAt(easy,1,4);
            	method.WriteAt(easy1,1,5);
           	 	method.WriteAt(easy2,1,6);
            }else if (Difficulty == "Normal"){
            	method.WriteAt(normal,1,4);
            	method.WriteAt(normal1,1,5);
           	 	method.WriteAt(normal2,1,6);
            }else{
            	method.WriteAt(hard,1,4);
            	method.WriteAt(hard1,1,5);
           	 	method.WriteAt(hard2,1,6);
            }

		}
		
		
		public static void TypingArea()
		{
			Methods method = new Methods();
			int halfBorder = Console.WindowHeight/2;
			int topRightborder = 0;
			int lowRightborder = 0;
			
			if (!Once)
			{
				for (int i = 0; i < Console.WindowWidth - 8; i++)
				{
					method.WriteAt("*", 4+i, halfBorder);
					Thread.Sleep(1);
					topRightborder = 4 + i;					
				}
				
				for (int i = 0; i < Console.WindowHeight/2 - 3; i++) {
					method.WriteAt("*", topRightborder, halfBorder+i);
					Thread.Sleep(1);
					lowRightborder = halfBorder + i;					
				}
				
				for (int i = topRightborder; i > 4; i--) {
					method.WriteAt("*", i, lowRightborder);
					Thread.Sleep(1);					
				}
				
				for (int i = lowRightborder; i > halfBorder; i--)
				{
					method.WriteAt("*", 4, i);
					Thread.Sleep(1);
								
				}
			}else{
			    for (int i = 0; i < Console.WindowWidth - 8; i++)
					{
						method.WriteAt("*", 4+i, halfBorder);
						topRightborder = 4 + i;		
					}
				
				for (int i = 0; i < Console.WindowHeight/2 - 3; i++) 
					{
						method.WriteAt("*", topRightborder, halfBorder+i);
						lowRightborder = halfBorder + i;						
					}
				
				for (int i = topRightborder; i > 4; i--) 
					{
						method.WriteAt("*", i, lowRightborder);						
					}
				
				for (int i = lowRightborder; i > halfBorder; i--)
					{
						method.WriteAt("*", 4, i);									
					}
			}
			
		}
		public void Preparatory()
		{
		Methods method = new Methods();
		string[] array = {
		 @"  _______________", 
		 @" / ___/ __/_  __/", 
		 @"/ (_ / _/  / /   ",
		 @"\___/___/ /_/    ",

		 @"  _______________   ___  _______   _____  ____", 
		 @" / ___/ __/_  __/  / _ \/ __/ _ | / _ \ \/ / /", 
		 @"/ (_ / _/  / /    / , _/ _// __ |/ // /\  /_/ ",
		 @"\___/___/ /_/    /_/|_/___/_/ |_/____/ /_(_)  "};
		
			int i = 0;				 				
			while(i < array.Length)
			{
				method.WriteAt(array[i], Console.WindowWidth/2 - (array[4].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
				method.WriteAt(array[i + 1], Console.WindowWidth/2 - (array[4].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 1);
				method.WriteAt(array[i + 2], Console.WindowWidth/2 - (array[4].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
				method.WriteAt(array[i + 3], Console.WindowWidth/2 - (array[4].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) + 1);
				Thread.Sleep(500);
				i += 4;
			}
			Thread.Sleep(500);
			Once = true;
			Display();
		}
		public void CountDown()
		{
			Methods method = new Methods();
			string[] array = {
 @"   ____", 
 @"  |_  /", 
 @" _/_ <",
 @"/____/",
 
 @"   ____   ", 
 @"  |_  /   ", 
 @" _/_ <  _ ",
 @"/____/ (_)", 
 
 @"   ____       ", 
 @"  |_  /       ", 
 @" _/_ <  _   _ ",
 @"/____/ (_) (_)",
               	
 @"   ____          ___ ", 
 @"  |_  /         |_  |", 
 @" _/_ <  _   _   / __/",
 @"/____/ (_) (_) /____/", 

 @"   ____          ___     ", 
 @"  |_  /         |_  |    ", 
 @" _/_ <  _   _   / __/  _ ",
 @"/____/ (_) (_) /____/ (_)",

 @"   ____          ___         ", 
 @"  |_  /         |_  |        ", 
 @" _/_ <  _   _   / __/  _   _ ",
 @"/____/ (_) (_) /____/ (_) (_)",
 
 @"   ____          ___            ___", 
 @"  |_  /         |_  |          <  /", 
 @" _/_ <  _   _   / __/  _   _   / / ",
 @"/____/ (_) (_) /____/ (_) (_) /_/  ",

 @"   ____          ___            ___  ", 
 @"  |_  /         |_  |          <  /  ", 
 @" _/_ <  _   _   / __/  _   _   / / _ ",
 @"/____/ (_) (_) /____/ (_) (_) /_/ (_)",

 @"   ____          ___            ___      ", 
 @"  |_  /         |_  |          <  /      ", 
 @" _/_ <  _   _   / __/  _   _   / / _   _ ",
 @"/____/ (_) (_) /____/ (_) (_) /_/ (_) (_)",

 @"   ____          ___            ___        ________  _____  ______", 
 @"  |_  /         |_  |          <  /       /_  __/\ \/ / _ \/ __/ /", 
 @" _/_ <  _   _   / __/  _   _   / / _   _   / /    \  / ___/ _//_/ ",
 @"/____/ (_) (_) /____/ (_) (_) /_/ (_) (_) /_/     /_/_/  /___(_)  "};

			if(!countDown)
			{
				int i = 0;				 				
				while(i < array.Length)
				{
					method.WriteAt(array[i], Console.WindowWidth/2 - (array[39].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 2);
					method.WriteAt(array[i + 1], Console.WindowWidth/2 - (array[39].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) - 1);
					method.WriteAt(array[i + 2], Console.WindowWidth/2 - (array[39].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2));
					method.WriteAt(array[i + 3], Console.WindowWidth/2 - (array[39].Length/2), (Console.WindowHeight/2 + (Console.WindowHeight/2 - 3)/2) + 1);
					Thread.Sleep(500);
					i += 4;
				}
				Thread.Sleep(1000);
				countDown = true;
				Display();
			}
		}	
	}
}
