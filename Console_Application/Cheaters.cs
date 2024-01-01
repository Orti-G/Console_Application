/*
 * Created by SharpDevelop.
 * User: User
 * Date: 01/01/2024
 * Time: 3:11 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of Cheaters.
	/// </summary>
	public class Cheaters
	{
		public void DisplayText()
		{
			Console.Clear();
			Methods method = new Methods();
			 string text = @"   ________               __";
			string text1 = @"  / ____/ /_  ___  ____ _/ /____  __________";
			string text2 = @" / /   / __ \/ _ \/ __ `/ __/ _ \/ ___/ ___/";
			string text3 = @"/ /___/ / / /  __/ /_/ / /_/  __/ /  (__  )";
			string text4 = @"\____/_/ /_/\___/\__,_/\__/\___/_/  /____/";
			
			string text5 = @"   _  __                   _      ___ ";
			string text6 = @"  / |/ /__ _  _____ ____  | | /| / (_)__ ";
			string text7 = @" /    / -_) |/ / -_) __/  | |/ |/ / / _ \";
			string text8 = @"/_/|_/\__/|___/\__/_/     |__/|__/_/_//_/";
			
			method.WriteAt(text,  Console.WindowWidth/2 - text1.Length, Console.WindowHeight/2 - 4);
			method.WriteAt(text1, Console.WindowWidth/2 - text1.Length, Console.WindowHeight/2 - 3);
			method.WriteAt(text2, Console.WindowWidth/2 - text1.Length, Console.WindowHeight/2 - 2);
			method.WriteAt(text3, Console.WindowWidth/2 - text1.Length, Console.WindowHeight/2 - 1);
			method.WriteAt(text4, Console.WindowWidth/2 - text1.Length, Console.WindowHeight/2);
			method.WriteAt(text5, Console.WindowWidth/2, Console.WindowHeight/2 + 1);
			method.WriteAt(text6, Console.WindowWidth/2, Console.WindowHeight/2 + 2);
			method.WriteAt(text7, Console.WindowWidth/2, Console.WindowHeight/2 + 3);
			method.WriteAt(text8, Console.WindowWidth/2, Console.WindowHeight/2 + 4);
			Thread.Sleep(3000);
			for (;;) {
			   	Program program = new Program();
			   	Program.Main();
			   		}
		}
	}
}
