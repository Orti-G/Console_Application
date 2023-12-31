/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21/12/2023
 * Time: 12:49 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Threading;
namespace Console_Application
{
	/// <summary>
	/// Description of Methods.
	/// </summary>
	public class Methods
	{
		private static int origRow;
	    private static int origCol;
	    
	    
		public void WriteAt(string s, int x, int y)
	    {
	    try
	        {
	        Console.SetCursorPosition(origCol+x, origRow+y);
	        Console.Write(s);
	        }
	    catch (ArgumentOutOfRangeException e)
	        {
	        Console.Clear();
	        Console.WriteLine(e.Message);
	        }
	    }
	    
	    public void WriteAt(char s, int x, int y)
	    {
	    try
	        {
	        Console.SetCursorPosition(origCol+x, origRow+y);
	        Console.Write(s);
	        }
	    catch (ArgumentOutOfRangeException e)
	        {
	        Console.Clear();
	        Console.WriteLine(e.Message);
	        }
	    }
	    
	    public void WriteAt(int s, int x, int y)
	    {
	    try
	        {
	        Console.SetCursorPosition(origCol+x, origRow+y);
	        Console.Write(s);
	        }
	    catch (ArgumentOutOfRangeException e)
	        {
	        Console.Clear();
	        Console.WriteLine(e.Message);
	        }
	    }
	    
	    public void WriteAt(double s, int x, int y)
	    {
	    try
	        {
	        Console.SetCursorPosition(origCol+x, origRow+y);
	        Console.Write(s);
	        }
	    catch (ArgumentOutOfRangeException e)
	        {
	        Console.Clear();
	        Console.WriteLine(e.Message);
	        }
	    }
	    
	    public void BorderBox()
		{
			origRow = Console.CursorTop;
   			origCol = Console.CursorLeft;
   			int topRight = 0;
   			int bottomLeft = 0;
   			for (int i = 2; i < Console.WindowWidth - 2; i++) {
   				WriteAt(".",i,1);
   				topRight = i;
   			}
   			
   			for (int i = 2; i < Console.WindowHeight - 1; i++) {
   				WriteAt(".",2,i);
   				bottomLeft = i;
   				
   			}
   			
   			for (int i = 2; i < Console.WindowHeight - 1; i++) {
   				WriteAt(".",topRight,i);
   			}
   			
   			for (int i = 2; i < Console.WindowWidth - 2; i++) {
   				WriteAt(".",i,bottomLeft);
   				
   			}
		}
	    
	    public double SimulateOperations(Stopwatch stopwatch)
	    {
	       stopwatch.Stop();
	       return stopwatch.Elapsed.TotalSeconds;

	    }
	}
}
