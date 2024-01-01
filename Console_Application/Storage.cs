/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 4:38 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_Application
{

	public class Storage
	{
		public static List<Tuple<string, int, double>> LeaderboardEasy = new List<Tuple<string, int, double>>
		{
			new Tuple<string, int, double>("Edh",16,43),
	    	new Tuple<string, int, double>("Jayniell",18,40),
	    	new Tuple<string, int, double>("Mark",7,45),
			new Tuple<string, int, double>("Abraham",10,38),
	    	new Tuple<string, int, double>("Vincent",13,45),
	    	new Tuple<string, int, double>("Carlo",9,36)  ,
			new Tuple<string, int, double>("Jose",11,42),
	    	new Tuple<string, int, double>("Lawrence",8,34),
	    	new Tuple<string, int, double>("Daniell",7,36),
	    	new Tuple<string, int, double>("Aeron",12,39)
		};
			
		public static List<Tuple<string, int, double>> LeaderboardNormal = new List<Tuple<string, int, double>>
		{
		    new Tuple<string, int, double>("Eddh",20,43),
			new Tuple<string, int, double>("Jayniell",14,45),
	    	new Tuple<string, int, double>("Mark",18,42),
	    	new Tuple<string, int, double>("Abraham",10,33),
	    	new Tuple<string, int, double>("Vincent",9,32),
	    	new Tuple<string, int, double>("Carlo",10,36)  ,
			new Tuple<string, int, double>("Jose",13,39),
	    	new Tuple<string, int, double>("Lawrence",9,35),
	    	new Tuple<string, int, double>("Daniell",10,32),
	    	new Tuple<string, int, double>("Aeron",11,41)
		};
		public static List<Tuple<string, int, double>> LeaderboardHard = new List<Tuple<string, int, double>>
		{
			new Tuple<string, int, double>("Eddh",10,33),
	    	new Tuple<string, int, double>("Jayniell",10,28),
	    	new Tuple<string, int, double>("Mark",12,35),
	    	new Tuple<string, int, double>("Abraham",5,31),
	    	new Tuple<string, int, double>("Vincent",4,28),
	    	new Tuple<string, int, double>("Carlo",7,28)  ,
			new Tuple<string, int, double>("Jose",9,31),
	    	new Tuple<string, int, double>("Lawrence",5,24),
	    	new Tuple<string, int, double>("Daniell",6,25),
	    	new Tuple<string, int, double>("Aeron",8,30)
		};
		
	
		
		private string[] wordBank = {
            "apple", "banana", "orange", "grape", "kiwi", "melon",
            "carrot", "broccoli", "potato", "tomato", "cucumber",
            "elephant", "giraffe", "lion", "tiger", "zebra",
            "sunflower", "rose", "tulip", "daisy", "lily",
            "computer", "keyboard", "mouse", "monitor", "printer",
            "ocean", "mountain", "desert", "forest", "river",
            "guitar", "piano", "violin", "drums", "flute",
            "chocolate", "vanilla", "strawberry", "mint", "caramel",
            "football", "soccer", "basketball", "tennis", "baseball",
            "book", "magazine", "newspaper", "novel", "dictionary",
            "umbrella", "raincoat", "hat", "scarf", "gloves",
            "bicycle", "motorcycle", "car", "bus", "train",
            "moon", "sun", "star", "planet", "galaxy",
            "school", "college", "university", "classroom", "teacher",
            "camera", "photo", "video", "film", "director",
            "pizza", "burger", "sushi", "pasta", "salad",
            "swimming", "running", "yoga", "cycling", "hiking",
            "music", "art", "dance", "theater", "film"
        };
		
		public static string [] Ranking = 
    {
        
@"  ██        ",
@"████        ",
@"  ██        ",
@"  ██        ",
@"  ██        ",


@"██████      ",
@"     ██     ",
@" █████      ",
@"██          ",
@"███████     ",
                                              
                                              

@"██████      ",
@"     ██     ",
@" █████      ",
@"     ██     ",
@"██████      ",
                                              
                                              

@"██   ██     ",
@"██   ██     ",
@"███████     ",
@"     ██     ",
@"     ██     ",
		
		

@"███████     ",
@"██          ",
@"███████     ",
@"     ██     ",
@"███████     ",
                                          
                                          

@" ██████     ",
@"██          ",
@"███████     ",
@"██    ██    ",
@" ██████     ",
                                           
                                           

@"███████     ",
@"     ██     ",
@"    ██      ",
@"   ██       ",
@"   ██       ",

@" █████      ",
@"██   ██     ",
@" █████      ",
@"██   ██     ",
@" █████      ",

@" █████      ",
@"██   ██     ",
@" ██████     ",
@"     ██     ",
@" █████      ",

@" ██  ██████ ",
@"███ ██  ████",
@" ██ ██ ██ ██",
@" ██ ████  ██",
@" ██  ██████ ",

@" ██  ██     ",
@"███ ███     ",
@" ██  ██     ",
@" ██  ██     ",
@" ██  ██     ",

@" ██ ██████  ",
@"███      ██ ",
@" ██  █████  ",
@" ██ ██      ",
@" ██ ███████ ",

@" ██ ██████  ",
@"███      ██ ",
@" ██  █████  ",
@" ██      ██ ",
@" ██ ██████  ",

@" ██ ██   ██ ",
@"███ ██   ██ ",
@" ██ ███████ ",
@" ██      ██ ",
@" ██      ██ ",

@" ██ ███████ ",
@"███ ██      ",
@" ██ ███████ ",
@" ██      ██ ",
@" ██ ███████ "
};
		
		public static string [] Ranking1 =	{
@" ██ ███████     ██    ",
@"███ ██          ██    ",
@" ██ ███████ ██████████",
@" ██      ██     ██    ",
@" ██ ███████     ██    "
};	
		
		public static List<string> Words = new List<string>();
		
		public static List<char> Input = new List<char>();
		public static List<char> Input1 = new List<char>();
		
		public static List<string> Censorship = new List<string>();
		public static List<string> Censorship1 = new List<string>();
		
		public void WordsToType(int numberOfWords)
		{
			Random rnd = new Random();
			
			
			for (int i = 0; i < numberOfWords; i++) 
			{
				int randomWords = rnd.Next(wordBank.Length);
				Words.Add(wordBank[randomWords]);
				
			}
					
		}
		
		public string DisplayInput()
		{
			string input = "";
			for (int i = 0; i < Input.Count; i++) {
				input += Input[i];

			}
			return input;
		}
		
		public string DisplayInput1()
		{
			string input1 = "";
			for (int i = 0; i < Input1.Count; i++) {
				input1 += Input1[i];
			}
			return input1;
		}
		
		public void EasyAddPlayer(string playerName, int level, double score)
	    {
	        var playerIndex = LeaderboardEasy.FindIndex(p => p.Item1.Equals(playerName));
	        if (playerIndex != -1)
	        {
	            var player = LeaderboardEasy[playerIndex];
	            if (player.Item2 > level) {
	            	LeaderboardEasy[playerIndex] = new Tuple<string,int,double>(player.Item1,player.Item2,player.Item3);
	            }else{
	            	LeaderboardEasy[playerIndex] = new Tuple<string,int,double>(player.Item1,level,score);
	            }
	        }
	        else
	        {
	            // Player not found, adding the player to the leaderboard
	            LeaderboardEasy.Add(new Tuple<string,int,double>(playerName, level, score)); 
	        }
	    }
		
	    public List<Tuple<string, int, double>> UpdateRanksEasy()
	    {
	    	

	        var sortedLeaderboard = LeaderboardEasy.OrderByDescending(p => p.Item2)
	        									   .ThenByDescending(p => p.Item3)
                                           		   .ToList();
	        
	        for (int i = 0; i < sortedLeaderboard.Count; i++)
	        {
	            sortedLeaderboard[i] = new Tuple<string,int,double>(sortedLeaderboard[i].Item1, sortedLeaderboard[i].Item2, sortedLeaderboard[i].Item3);
	        }
	        return sortedLeaderboard;
	    }
	    
	    public void NormalAddPlayer(string playerName, int level, double score)
	    {
	        var playerIndex = LeaderboardNormal.FindIndex(p => p.Item1.Equals(playerName));
	        if (playerIndex != -1)
	        {
	            var player = LeaderboardNormal[playerIndex];
	            if (player.Item2 > level) {
	            	LeaderboardNormal[playerIndex] = new Tuple<string,int,double>(player.Item1,player.Item2,player.Item3);
	            }else{
	            	LeaderboardNormal[playerIndex] = new Tuple<string,int,double>(player.Item1,level,score);
	            }
	        }
	        else
	        {
	            // Player not found, adding the player to the leaderboard
	            LeaderboardNormal.Add(new Tuple<string,int,double>(playerName, level, score)); 
	        }
	    }
		
	    public List<Tuple<string, int, double>> UpdateRanksNormal()
	    {
			
	        var sortedLeaderboard = LeaderboardNormal.OrderByDescending(p => p.Item2)
	        									   .ThenByDescending(p => p.Item3)
                                           		   .ToList();
	        
	        for (int i = 0; i < sortedLeaderboard.Count; i++)
	        {
	            sortedLeaderboard[i] = new Tuple<string,int,double>(sortedLeaderboard[i].Item1, sortedLeaderboard[i].Item2, sortedLeaderboard[i].Item3);
	        }
	        return sortedLeaderboard;
	    }
	    
	    public void HardAddPlayer(string playerName, int level, double score)
	    {
	        var playerIndex = LeaderboardHard.FindIndex(p => p.Item1.Equals(playerName));
	        if (playerIndex != -1)
	        {
	            var player = LeaderboardHard[playerIndex];
	            if (player.Item2 > level) {
	            	LeaderboardHard[playerIndex] = new Tuple<string,int,double>(player.Item1,player.Item2,player.Item3);
	            }else{
	            	LeaderboardHard[playerIndex] = new Tuple<string,int,double>(player.Item1,level,score);
	            }
	        }
	        else
	        {
	            
	            LeaderboardHard.Add(new Tuple<string,int,double>(playerName, level, score)); 
	        }
	    }
		
	    public List<Tuple<string, int, double>> UpdateRanksHard()
	    {
	    
	        var sortedLeaderboard = LeaderboardHard.OrderByDescending(p => p.Item2)
	        									   .ThenByDescending(p => p.Item3)
                                           		   .ToList();
	        
	        for (int i = 0; i < sortedLeaderboard.Count; i++)
	        {
	            sortedLeaderboard[i] = new Tuple<string,int,double>(sortedLeaderboard[i].Item1, sortedLeaderboard[i].Item2, sortedLeaderboard[i].Item3);
	        }
	        return sortedLeaderboard;
	    }
	    
	    public void showRankingEasy(string playerName)
	    {
	    	Methods method = new Methods();
	    	
	    	var playerIndex = LeaderboardEasy.FindIndex(p => p.Item1.Equals(playerName));
	    	try {
	    		for (int i = 0; i < 5; i++) {
	    		method.WriteAt((Ranking[(playerIndex + (playerIndex * 4)) + i]),(5 * Console.WindowWidth)/8 + 15 , 24 + i);
	        	}
	    	} catch (IndexOutOfRangeException) {	    		
	    		for (int i = 0; i < 5; i++) {
	    		method.WriteAt(Ranking1[i],(5 * Console.WindowWidth)/8 + 15 , 24 + i);
	        	}
	    	}
	         	
		}
	    
	    public void showRankingNormal(string playerName)
	    {
	    	Methods method = new Methods();
	    	
	    	var playerIndex = LeaderboardNormal.FindIndex(p => p.Item1.Equals(playerName));
	        try {
	    		for (int i = 0; i < 5; i++) {
	    		method.WriteAt((Ranking[(playerIndex + (playerIndex * 4)) + i]),(5 * Console.WindowWidth)/8 + 15 , 24 + i);
	        	}
	    	} catch (IndexOutOfRangeException) {	    		
	    		for (int i = 0; i < 5; i++) {
	    		method.WriteAt(Ranking1[i],(5 * Console.WindowWidth)/8 + 15 , 24 + i);
	        	}
	    	}
	    	
		}
	    
	    public void showRankingHard(string playerName)
	    {
	    	Methods method = new Methods();
	    	
	    	var playerIndex = LeaderboardHard.FindIndex(p => p.Item1.Equals(playerName));
	        try {
	    		for (int i = 0; i < 5; i++) {
	    		method.WriteAt((Ranking[(playerIndex + (playerIndex * 4)) + i]),(5 * Console.WindowWidth)/8 + 15 , 24 + i);
	        	}
	    	} catch (IndexOutOfRangeException) {	    		
	    		for (int i = 0; i < 5; i++) {
	    		method.WriteAt(Ranking1[i],(5 * Console.WindowWidth)/8 + 15 , 24 + i);
	        	}
	    	}
	    	
		}
	    
	    
	}
}
