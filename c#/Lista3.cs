/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 15/05/2025
 * Time: 07:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PAtrilhasAtiv03
{
	class A03
	{
		public static void Main()
		{
			n2();
			
			Console.ReadKey();
		}
		
		
		
		
		
		
		
		
		
		
		
		static void n2()
		{
		Console.WriteLine("[DIGITE] dois valores :");
			
			int[] valor= new int[2];
		
			for(int i=0;i<2;i++){
				valor[i]=pegarnumero(i);
			}
			
			
			if(valor[0]!=valor[1]){
				string maiorvalor=(valor[0]>valor[1]) ? "primeiro":"segundo";
				string menorvalor=(maiorvalor=="primerio")?"segundo":"primeiro";
				
				Console.WriteLine("O {0} e maior",maiorvalor);
				Console.WriteLine("O {0} e menor",menorvalor);
			}else{
				Console.WriteLine("Os valores sao iguais");
			}
			
			for(int i=0;i<2;i++)
			{
				if(valor[i]%2==1)
				{
					Console.WriteLine("O valor {0} e impar",valor[i]);
				}else{
					Console.WriteLine("O valor {0} e par",valor[i]);
				}
				
				if(valor[i]<10)
				{
					Console.WriteLine("O valor {0} e menor que 10",valor[i]);
				}else{
					Console.WriteLine("O valor {0} ou maior ou igural que 10",valor[i]);
				}
			}
		}
		
		
		
		
		
		
		
		
		
		
		
		
		static int pegarnumero(int i)
		{
			string chave = "aa";
			chave = (i==0) ? "Primeiro":"Segundo";
			Console.WriteLine("[DIGITE] {0} valor o inteiro ",chave);
			int valor=int.Parse(Console.ReadLine());
			return valor;
		}
		
	}
}