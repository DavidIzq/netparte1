/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:40 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio11
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Desarrollar un programa que permita ingresar n números enteros y 
			luego nos imprima cuántos valores fueron pares y cuántos impares.
			*/
			int cant,num,par=0,impar=0;
			Console.WriteLine("Cuantos numeros va a ingresar");
			cant=int.Parse(Console.ReadLine());
			for(int i=1;i<=cant;i++){
				Console.WriteLine("Digite numero ");
				num=int.Parse(Console.ReadLine());
				if(num%2==0){
					par=par+1;
				}else{
					impar=impar+1;
				}
			}
			
			Console.WriteLine("El total de numeros pares es de "+par);
			Console.WriteLine("El total de numeros impares es de "+impar);
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}