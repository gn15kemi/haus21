using System ;

public class Datentypen
{ 
	static public void Main()
	{
		double minutenzahl = 0, monatsgebuehr = 0; 



		Console.WriteLine(" \t 1,2- Erstellung von einem Programm für Monatsgebühr in abhängigkeit von MinutenZahl \n");
		Console.WriteLine(" \t Geben Sie bitte die Minutenzahl ein");

		minutenzahl = Convert.ToDouble(Console.ReadLine());

		if ( minutenzahl <= 100 )
		{

			Console.WriteLine(" Ihre Monatsgebühr beträgt : 3,99 Euro "); 

		}else

		{

			monatsgebuehr = (( ( minutenzahl - 100 ) * ( 0.099 ) ) + 3.99);

			Console.WriteLine("\t Ihre Monatsgebühr beträgt  \n \n \n" + monatsgebuehr + " Euro " ); 
		}
			string tarif;
		Console.WriteLine(" \t 3- Wählen Sie Ihre Tarifoptionen aus ");

		Console.WriteLine(" \t \t  - Tarif S \n");
		Console.WriteLine(" \t \t  - Tarif M \n");
		Console.WriteLine(" \t \t  - Tarif L \n");
		Console.WriteLine( "\t \t \t", tarif = Console.ReadLine());


				switch(tarif)
		{ 	case "S" :
				Console.WriteLine ( " Ihre Rechnung beträgt : 6 Euro ") ;
				break; 

			case "M" : 
				Console.WriteLine ( " Ihre Rechnung beträgt : 11 Euro") ;
				break; 

			case "L" : 
				Console.WriteLine ( " Ihre Rechnung beträgt : 20 Euro") ;
				break; 

				default : 
				Console.WriteLine(" Sie haben einen falschen Eingaben eingetragen ");
					break;






		}



		Console.ReadKey();
	}


}