/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:50 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio14
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*14)Escriba un programa que muestre los números del 1 al 20 concatenados.
 				*Mostrar la concatenación agregando un número por línea.
			*/
			string espacio="";
			for(int i=1;i<21;i++){
				espacio=(espacio+i);
				Console.WriteLine(espacio);
				
			}
		
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}