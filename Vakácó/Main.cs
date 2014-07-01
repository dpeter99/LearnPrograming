using System;
using System.Collections;

namespace Vakácó
{
	class MainClass
	{	
			
	
			
		public static void Main (string[] args)
		{
			string text;
			int i;
			
			Console.WriteLine ("Hello World!");
			
			Console.Write ("Kérem a szöveget: ");
			text = Console.ReadLine ();
			
			for (i = 0; i < text.Length; i++) {
				
				Console.Write (text [i]);
				System.Threading.Thread.Sleep (500);
					
			}
			
			Console.WriteLine ("");
			
			for (i = text.Length; i > 0; i--) {
				
				Console.Write (text [i - 1]);
				System.Threading.Thread.Sleep (500);
				
			}
			
			Console.WriteLine ("");
		}
	}
}
