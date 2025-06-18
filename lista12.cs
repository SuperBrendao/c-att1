/*
a) Crie um array de inteiros e use o foreach para imprimir cada elemento na tela.
b) Crie uma lista de strings e use o foreach para imprimir cada elemento na tela.
c) Crie uma lista de inteiros e use o foreach para encontrar o maior número na lista.
d) Crie uma lista de strings e use o foreach para encontrar a string mais longa na lista.
e) Crie uma lista de números e use o foreach para calcular a média dos números na
lista.
*/

using System;
using System.Collections.Generic;
class Lsta12
{
    static void Main()
    {
        mostrarListaString();//atividade a,b
        maiorValorLista();//atividade c
        maiorStringLista(); //atividade d
        mediadeumaLista();//atividade e
    }

    static void proximo()
    {
        Console.WriteLine("Proximo....\n");
        Console.ReadLine(true);
        Console.Clear();
    }
    static void mostarListaString()
    {
        List<string> lista = new List<string>("a", "b", "c", "d"); //declarar lista

        foreach (string i in lista)
            Console.Write(i + "\n");
        proximo();
    }


    static void maiorValorLista()
    {//atividade c
        List<int> lista = new List<int>(1, 2, 3, 4, 65, 453, 234, 12334, 4567, 4564, 2345, 98876, 56); //declarar lista
        int max = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if (max < lista[i])
                max = lista[i];
        }
        proximo();
    }


    static void maiorStringLista()
    {
        List<string> lista = new List<string>("adfgdf", "brtrgf", "casa", "dasa"); //declarar lista

        string nome = "0";

        foreach (string a in lista)
        {
            if (a.Length > nome.Length)
                nome = a;
        }

        Console.WriteLine("a maior paravra e [{0}]", nome);
        proximo();
    }

    static void mediadeumaLista()
    {
        List<int> lista = new List<int>(1, 2, 3, 4, 65, 453, 234, 12334, 4567, 4564, 2345, 98876, 56); //declarar lista
        double media = lista[0];
        for (int i = 1; i < lista.Length; i++)
        {
            media /= lista[i];
        }

        Console.WriteLine("A media e [{0}]", media);
        proximo();
    }
}
