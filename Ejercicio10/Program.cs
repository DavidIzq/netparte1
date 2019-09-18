/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:33 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio10
{
	class Program
	{
		public static void Main(string[] args)
		{
			//De 10 números ingresados indicar cuantos son mayores a cero y cuantos son menores a cero
			double num,neg=0,pos=0;
			for(int i=1;i<11;i++){
				Console.WriteLine("Ingrese numero "+i);
				num=double.Parse(Console.ReadLine());
				if(num<0){
					neg=neg+1;
				}else{
					pos=pos+1;
				}
				
				
			}
			Console.WriteLine("El total de numeros positivos es de "+pos);
			Console.WriteLine("El total de numeros negativos es de "+neg);
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}