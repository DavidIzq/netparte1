/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 07:59 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			//7)Solicite un numero por teclado y muestra la tabla de multiplicar de dicho numero
			Console.WriteLine("Ingrese un numero");
			int num,tabla;
			num=int.Parse(Console.ReadLine());
			for(int i=1;i<11;i++){
				tabla=num*i;
				Console.WriteLine(tabla);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}