using System;

namespace challenge
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			
			Console.WriteLine ("1. Feladat");
			
			Console.WriteLine ("K" + "\t" + "2*K" + "\t" + "K*K");
			
			for (int l =0; l < 11; l++) {
				
				Console.WriteLine (l + "\t" + 2 * l + "\t" + l * l);
				
				
			}
			//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
			
			Console.WriteLine ("2. Feladat");
			
			
			
			//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
			
			Console.WriteLine ("6. Feladat");
			int a;
			float q;
			
			do {
				a = int.Parse (Console.ReadLine ());				
			} while (0>a);
			
			q = (a + 1) / 2;
			//Console.WriteLine (q);
			
			do {
			
				q = (a / q + q) / 2;
//				Console.WriteLine (q);
//				Console.WriteLine (Math.Abs ((q * q) - a) < a / (Math.Pow (10, 6)));
//				Console.WriteLine (Math.Abs ((q * q) - a) + " < " + a / (Math.Pow (10, 6)));
				
			} while (Math.Abs((q*q)-a)>a/(Math.Pow(10,6)));
			
			Console.WriteLine (q);
//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
			Console.WriteLine ("9. Feladat");
			
//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

			Console.WriteLine ("9. Feladat");
			
			int r = int.Parse (Console.ReadLine ());
			int m = int.Parse (Console.ReadLine ());
			
			double te;
			double t;
			
			te = ((Math.Pow (r, 2) * Math.PI) * 2) + (((r * 2) * Math.PI) * m);
			
			t = (Math.Pow (r, 2) * Math.PI) * m;
			
			Console.WriteLine ("Terület: " + te);
			Console.WriteLine ("Térfogat: " + t);
			
			
			
			
			
		}
	}
}
