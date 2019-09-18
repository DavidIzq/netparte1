/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:03 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*8)Se registran 10 empleados de una empresa con nombre, 
             *sueldo, sexo (1=femenino y 2=masculino).Mostrar cuantas mujeres 
             *ganan más de $500 pesos y cuantos hombres ganan menos de $400.
             */
            string nombre;
            int sueldo,sexo,contarm=0,contarf=0;
            for(int i=1;i<11;i++){
            	Console.WriteLine("Digite su nombre");
            	nombre=Console.ReadLine();
            	Console.WriteLine("Digite su sueldo");
            	sueldo=int.Parse(Console.ReadLine());
            	Console.WriteLine("Digite su sexo (1.Femenino 2.Masculino)");
            	sexo=int.Parse(Console.ReadLine());
            	switch(sexo){
            		case 1:
            			if(sueldo>500){
            				contarf=contarf+1;
            			}
            			break;
            	    case 2:
            			if(sueldo<400){
            				contarm=contarm+1;
            			}
            			break;
            		default:
            			Console.WriteLine("Opcion incorrecta");
            			break;
            	}
            }
            Console.WriteLine("El total de mujeres que reciben mas de $500 es de "+contarf);
              Console.WriteLine("El total de hombres que reciben menos de $400 es de "+contarm);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}