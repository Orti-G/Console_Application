/*
 * Created by SharpDevelop.
 * User: User
 * Date: 01/01/2024
 * Time: 4:16 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of Instruction.
	/// </summary>
	public class Instruction
	{
		public void ScreenSizeChecker()
		{
			Methods method = new Methods();
			string pLine1 = "For the best experience, kindly note that this game runs optimally";
			string pLine2 = "in full-screen mode. We recommend maximizing your window for";
			string pLine3 = "an immersive and enjoyable gameplay experience...Thank you";
			string pLine4 = "Press F1 key if you're already done adjusting your computer's screensize";
			for (int i = 0; i < pLine1.Length; i++) 
				{			
					method.WriteAt(pLine1[i],Console.WindowWidth/2 - (pLine1.Length/2) + i, Console.WindowHeight/2 - 2);					
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine2.Length; i++) 
				{			
					method.WriteAt(pLine2[i],Console.WindowWidth/2 - (pLine2.Length/2) + i, Console.WindowHeight/2 - 1);
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine3.Length; i++) 
				{			
					method.WriteAt(pLine3[i],Console.WindowWidth/2 - (pLine3.Length/2) + i, Console.WindowHeight/2);
					Thread.Sleep(30);
				}
				
				for (int i = 0; i < pLine4.Length; i++) 
				{			
					method.WriteAt(pLine4[i],Console.WindowWidth/2 - (pLine4.Length/2) + i, Console.WindowHeight/2 + 4);
					Thread.Sleep(30);
				}
				
				ConsoleKey keyPressed;
				
				do{
					ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				keyPressed = keyInfo.Key;
				}while(keyPressed != ConsoleKey.F1);
					
				
				
				
		}
	}
}
