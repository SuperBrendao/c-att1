/*
1. Crie os códigos no SharpDevelop:
*/
using System;
using System.Collections.Generic;
class att09
{
    static void Main()
    {
        Console.WriteLine("a) Crie um vetor de inteiros e imprima na tela o valor de cada elemento de \n vetor.\n");
        vetor();//ok
        limp();
         Console.WriteLine("b) Crie um algoritmo que armazene nome e duas notas de 5 alunos e imprima\numa listagem contendo nome, as duas notas e a média de cada aluno.\n");
        n2a5();//ok
        limp();
         Console.WriteLine("c) Crie um vetor de números decimais e calcule a média dos valores do vetor.\n");
         medvetor();//ok
        limp();
         Console.WriteLine("d) Crie um vetor de inteiros e encontre o maior valor no vetor.\n");
        MaxMinValorVetor();//ok
        limp();
         Console.WriteLine("e) Crie um vetor de inteiros e encontre o menor valor no vetor.\n");
        somaVetor();//ok
        limp();
         Console.WriteLine("f) Crie um algoritmo que armazene números em dois vetores inteiros de cinco\nelementos cada. Gere e imprima o vetor soma.\n");
        ordenacaoCres();//ok
        limp();
         Console.WriteLine("g) Crie um algoritmo que armazene números em dois vetores inteiros de cinco\nelementos cada. Gere e imprima o vetor soma.\n");
        listaNome();//ok
        limp();
    }

    static void limp()
    {
        System.Console.WriteLine("\n[DIGITE] enter para continuar...");
        System.Console.ReadKey();
        System.Console.Clear();
    }
    

    static void vetor()
    {
        int[] vetor = new int[10]; //0 a 9
        for (int i = 0; i < vetor.Length; i++) { vetor[i] = i; }
        foreach (int i in vetor) { Console.Write(vetor[i]); }
    }
    static void n2a5()
    {
        string[,] AlunoNota = new string[5, 3];//0 a 4, 0 a 2
        /*
        AlunoNota[n,0], nome aluno
        AlunoNota[n,j>0], nota do aluno n aluno
        */

        //Gerar um os valores
        for (int Ialuno = 0; Ialuno < 5; Ialuno++)
        {
            Console.WriteLine("\nAluno {0}: ", Ialuno + 1);
            AlunoNota[Ialuno, 0] = Console.ReadLine();

            for (int Naluno = 1; Naluno < 3; Naluno++)
            {
                Console.Write("{0}º do aluno [{1}] : ", Naluno, AlunoNota[Ialuno, 0]);
                AlunoNota[Ialuno, Naluno] = Console.ReadLine();
            }
        }

        Console.WriteLine("----------------------------------------");

        //Mostrar os valores
        for (int Ialuno = 0; Ialuno < 5; Ialuno++)
        {
            Console.WriteLine("O aluno {0} de nome: [{1}]", Ialuno, AlunoNota[Ialuno, 0]);
            for (int Naluno = 1; Naluno < 3; Naluno++)
            {
                Console.Write(AlunoNota[Ialuno, Naluno] + " ");
            }
            Console.WriteLine("\n\n");
        }
    }



    static void medvetor()
    {
        decimal[] vetor = new decimal[5];
        decimal resultado = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("[DIGITE] [{0}]º valor de [5]:", i + 1);

            vetor[i] = decimal.Parse(Console.ReadLine());
            if (i == 0)
            {
                resultado = vetor[i];
            }
            else
            {
                resultado = (resultado + vetor[i]) / 2;
            }
        }
        Console.Write("\nOs elementos sao: ");
        foreach (decimal i in vetor) { Console.Write("{0} ", i); }
        Console.Write("\n = [{0}] \n", resultado);
    }

    static void MaxMinValorVetor()
    {
        int[] vetor = new int[30]; //0 a 9
        for (int i = 0; i < vetor.Length; i++) { vetor[i] = (i % 2 == 0 && i != 0) ? i * 11 : 1 + (i * 7); }
        Console.Write("A = { ");
        for (int i = 0; i < vetor.Length; i++) { Console.Write(vetor[i] + " "); }
        Console.Write("}\n");
        int[] MaxMin = new int[2] { vetor[0], vetor[0] };
        //MaxMin[0]=max
        //MaxMin[1]=man

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > MaxMin[0]) { MaxMin[0] = vetor[i]; }
            if (vetor[i] < MaxMin[1]) { MaxMin[1] = vetor[i]; }
        }
        for (int i = 0; i < 2; i++) { string chave = (i == 0) ? "MAX" : "MIN"; Console.WriteLine("{0} = [{1}]", chave, MaxMin[i]); }
    }


    static void somaVetor()
    {
        int[,] elemento = new int[5, 2];//0 a 4, 0 a 1 

        //A = elemento[n,0]
        //B = elemento[n,1]
        //C = A+B = elemento[n,0]+elemento[n,1]

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                elemento[j, i] = 10 * (i + j) + 5;
            }
        }
        for (int n = 0; n < 5; n++) { Console.WriteLine("indice {3} : [{0}]+[{1}]=[{2}]", elemento[n, 0], elemento[n, 1], elemento[n, 0] + elemento[n, 1], n); }
    }

    static void ordenacaoCres()
    {
        int[] vetor = new int[30]; //0 a 9

        for (int i = 0; i < vetor.Length; i++) { vetor[i] = (i % 2 == 0 && i != 0) ? i * 11 : 1 + (i * 7); }
        Console.Write("Pre: {");
        foreach (int i in vetor) { Console.Write(i + " "); }

        //bolha
        int banco = 0;
        for (int i = 0; i < (vetor.Length) - 2; i++)//-2
        {
            for (int j = 0; j < (vetor.Length) - 1; j++)//-1
            {
                if (vetor[j] > vetor[j + 1])
                {
                    banco = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = banco;
                }
            }
        }
        //bolha

        Console.Write("}\nPos: {");
        foreach (int i in vetor) { Console.Write(i + " "); } 
         Console.Write("}\n");
 }

    static void listaNome()
    {
        string[] list = new string[5] { "a", "b", "c", "d", "e" };
        
        foreach(string n in list){Console.WriteLine(n);}
    }
 }