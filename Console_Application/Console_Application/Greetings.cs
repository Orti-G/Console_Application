/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20/12/2023
 * Time: 10:44 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{

	public class Greetings
	{
		
		public void DisplayText()
		{
			Methods method = new Methods();
			method.BorderBox();
			
			string greetings = "Hey Player!";

			string pLine1 = "Welcome to our immersive typing challenge, designed not just to";
			string pLine2 = "enhance your speed typing skills but to make the learning";
			string pLine3 = "experience enjoyable through captivating gamified elements.";
			string pLine4 = "It's not just about typing fast; it's a super fun challenge";
			string pLine5 = "with game vibes. Get ready to level up your typing skills and";
			
				
			
			string pLine6 = "have a blast with us!";
			string pLine7 = "Press any key to continue...";
				for (int i = 0; i < greetings.Length; i++) 
				{			
					method.WriteAt(greetings[i], Console.WindowWidth/2 - (greetings.Length/2) + i, Console.WindowHeight/2 - 7);
					
					Thread.Sleep(20);
				}
				Thread.Sleep(1500);
				
				for (int i = 0; i < pLine1.Length; i++) 
				{			
					method.WriteAt(pLine1[i],Console.WindowWidth/2 - (pLine1.Length/2) + i, Console.WindowHeight/2 - 5);					
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine2.Length; i++) 
				{			
					method.WriteAt(pLine2[i],Console.WindowWidth/2 - (pLine2.Length/2) + i, Console.WindowHeight/2 - 4);
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine3.Length; i++) 
				{			
					method.WriteAt(pLine3[i],Console.WindowWidth/2 - (pLine3.Length/2) + i, Console.WindowHeight/2 - 3);
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine4.Length; i++) 
				{			
					method.WriteAt(pLine4[i],Console.WindowWidth/2 - (pLine4.Length/2) + i, Console.WindowHeight/2 - 2);
					Thread.Sleep(30);
				}
		
				for (int i = 0; i < pLine5.Length; i++) 
				{			
					method.WriteAt(pLine5[i],Console.WindowWidth/2 - (pLine5.Length/2) + i, Console.WindowHeight/2 - 1);
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine6.Length; i++) 
				{			
					method.WriteAt(pLine6[i],Console.WindowWidth/2 - (pLine6.Length/2) + i, Console.WindowHeight/2);
					Thread.Sleep(30);
				}
			Thread.Sleep(1500);
			method.WriteAt(pLine7, Console.WindowWidth/2 - (pLine7.Length/2 - 1), Console.WindowHeight/2 + 5);
			Console.ReadKey(true);
			
			
		}
		
	}
}
