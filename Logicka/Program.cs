using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicka
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(7 == 8);
			Console.WriteLine(7 != 8); //isto kao !(7==8)

			Console.WriteLine(7 < 8);
			Console.WriteLine(8 <= 8); //Kao da pitamo da li je manje ili da li je jednako
			Console.WriteLine(7 > 8);
			Console.WriteLine(7 >= 8);

			Console.WriteLine("-----------------");
			Console.WriteLine(7 < 8);			
			
			//Ne -- NOT -- !
			/*
			 *      A          !A
			 *      --------------
			 *      T          F
			 *      F          T
			 * 
			 * */
			
			
			Console.WriteLine(!(7 < 8));

			//I -- AND -- && -- logicko mnozenje
			/*
			 *      A     B        A && B
			 *   ----------------------------
			 *      T     T          T   
			 *      F     T          F   
			 *      T     F          F
			 *      F     F          F
			 * 
			 * */
			Console.WriteLine(true && true);





			Console.WriteLine("Unesite broj izmedju 0 i 10: ");
			int broj = int.Parse(Console.ReadLine());

			if (broj >= 0 && broj <= 10)
			{
					Console.WriteLine("Tacno");
			} else
			{
				Console.WriteLine("Nije tacno :(");
			}


			//OR -- ILI -- || -- logickim sabiranje
			/*
			 *    A      B         A||B
			 *    T      T           T
			 *    F      T           T   50
			 *    T      F           T  -20
			 *    F      F           F    5
			 */



			Console.WriteLine("Unesite broj koji je VAN opsega 0 do 10: ");
			broj = int.Parse(Console.ReadLine());
			if (broj < 0 || broj > 10)
			{
				Console.WriteLine("Tacno");
			}
			else
			{
				Console.WriteLine("Nije tacno :(");
			}


			Console.ReadKey();

		}
	}
}
