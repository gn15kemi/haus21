using System;

public class haus22

{  
	static public void Main()
	{	int jahr ;
		
		Console.WriteLine(" \t \t \n \n");
		Console.WriteLine(" \t \t 2. Kontrollfluss \n");
		Console.WriteLine(" \t \t ---------------- \n");


//1. Bestimmen Sie in einem Programm für ein einzulesendes Jahr, ob es sich um ein schaltjahr handelt.

		Console.WriteLine(" \t 2.1Das vordefinierte Programm sagt uns, ob das eingetragene Jahr ein schaltjahre ist  \n");
		

		do {



		Console.WriteLine(" \t \t Geben Sie das Jahr ein. \n");
		jahr = Convert.ToInt32(Console.ReadLine());


if ( jahr % 100 == 0 )
		{
			Console.WriteLine(" \t \t Es ist keine Schaltjahre \n");
		}

if ( ( jahr % 4 == 0 ) && ( ( jahr % 100) != 0) )
		
			
				{Console.WriteLine(" \t \t Es ist ein schaltjahre \n");}
		
			
if  (jahr % 4 != 0 ) 
					
				{Console.WriteLine (" Es ist kein Schaltjahre "); }

			}while ( Convert.ToString(jahr) != ("  "));
/* 2.Ergaenzen Sie das Programm um die wiederholte Eingabe des Jahres, bis ein leere Zeichekette eingegeben wird.
   Vervenden Sie dazu eine Do-While Schleife*/ 

				Console.WriteLine(" \n  \n");
					Console.WriteLine(" \t 2.2 Do-While schleife   \n");


Console.ReadKey();

}

}




	







