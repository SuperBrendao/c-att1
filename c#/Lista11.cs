/*
j) Crie um método que receba uma lista de números inteiros como parâmetro e\nretorne o menor número da lista\n
*/

using System;
using System.Collections.Generic;

class att11
{
    static void Main()
    {
        List<string> ListString = new List<string>();
        List<int> ListInt = new List<int>();

        for (int q = 0; q < 10; q++) { ListInt.Add(q); }

        int i = 0, ii = 0;
        string s = "";


        Console.WriteLine("a) Crie um método que receba um número inteiro como parâmetro e retorne seu\nquadrado.\n");
        i = int.Parse(Console.ReadLine());
        Console.WriteLine("\n" + QuadradoDeN(i));//a)
        limp();

        Console.WriteLine("b) Crie um método que receba uma string como parâmetro e retorne o número de\ncaracteres na string.\n");
        s = Console.ReadLine();
        Console.WriteLine("\n" + Ncaracter(s));//b)
        limp();

        Console.WriteLine("c) Crie um método que receba dois números inteiros como parâmetros e retorne a\nsoma deles.\n");
        i = int.Parse(Console.ReadLine());
        ii = int.Parse(Console.ReadLine());
        Console.WriteLine("\n" + SomaDe2Valor(i, ii));//c
        limp();


        Console.WriteLine("d) Crie um método que receba uma lista de números inteiros como parâmetro e\nretorne o maior número da lista.\n");
        Console.WriteLine("\n" + ListMaiorValor(ListInt, true));//d
        limp();

        Console.WriteLine("e) Crie um método que receba uma lista de strings como parâmetro e retorne uma\núnica string que contém todos os elementos da lista concatenados.\n");
        Console.WriteLine("Digite o n de palavras");
        i = int.Parse(Console.ReadLine());
        for (int q = 0; q < i; q++)
        {
            Console.WriteLine("\nEscreva a {0} palavra", q + 1);
            ListString.Add(Console.ReadLine());
        }
        Console.WriteLine("\n" + UnicaListaString(ListString));//E
        limp();


        Console.WriteLine("f) Crie um método que receba um número inteiro como parâmetro e retorne\nverdadeiro se o número for par e falso se o número for ímpar.\n");
        i = int.Parse(Console.ReadLine());
        Console.WriteLine("\n" + ParImpar(i));//F
        limp();


        Console.WriteLine("g) Crie um método que receba uma string como parâmetro e retorne uma nova string\ncontendo apenas os caracteres em posições ímpares.\n");
        s = Console.ReadLine();
        Console.WriteLine("\n" + StringPoImpar(s));//g
        limp();

        Console.WriteLine("h) Crie um método que receba uma lista de números inteiros como parâmetro e\nretorne a média dos números.\n");
        Console.WriteLine("\n" + MediaListaInt(ListInt));//h
        limp();

        Console.WriteLine("i) Crie um método que receba um número inteiro como parâmetro e retorne\nverdadeiro se o número for primo e falso caso contrário.\n");
        i = int.Parse(Console.ReadLine());
        Console.WriteLine("\n" + NuPrimo(i));//h
        limp();

        Console.WriteLine("j) Crie um método que receba uma lista de números inteiros como parâmetro e\nretorne o menor número da lista\n");
        Console.WriteLine("\n" + ListMaiorValor(ListInt, false));//j
        limp();

    }



    static void limp()
    {
        System.Console.WriteLine("\n[DIGITE] enter para continuar...");
        System.Console.ReadKey();
        System.Console.Clear();
    }





    static int QuadradoDeN(int i) { return i * i; }
    static int Ncaracter(string s) { int saida = s.Length; return saida; }
    static int SomaDe2Valor(int i, int ii) { return i + ii; }
    static int ListMaiorValor(List<int> ListInt, bool par)
    {
        int valor = 0;

        switch (par)
        {
            case true://maior
                foreach (int i in ListInt)
                {
                    if (i > valor) { valor = i; }
                }
                break;
            case false://impar
                foreach (int i in ListInt)
                {
                    if (i < valor) { valor = i; }
                }
                break;
        }
        return valor;
    }


    static string UnicaListaString(List<string> ListString)
    {
        string saida = " ";

        foreach (string item in ListString)
        {
            saida = saida + item;
        }
        return saida;
    }

  

    static string StringPoImpar(string s)
    {
        string saida = " ";

        for (int q = 0; q < s.Length; q += 2)
        {
            saida = saida + s[q];
        }
        return saida;
    }

    static double MediaListaInt(List<int> ListInt)
    {
        double media = (double)ListInt[0];

        for (int q = 1; q < 10; q++)
        {
            media /= (double)ListInt[q];
        }

        return media;
    }


    static bool NuPrimo(int valor)
    {

        decimal elemento = (decimal)valor;
        bool saida = false;

        if (elemento == 2 || elemento == 3 || elemento == 5 || elemento == 7)
        {
            saida = true;
        }
        else if (elemento % 2 > 0)
        {
            //O elemento e impar e maior que 10
            decimal metadeElemento = (elemento - 1) / 2;
            decimal banco = 0;
            for (decimal i = 3; i < metadeElemento + 1; i += 2)
            {
                banco = (elemento % i == 0) ? banco + 1 : banco + 0;
                if (banco > 0) { break; } else if (i >= metadeElemento) { saida = true; }
            }
        }

        return saida;
    }


    static string ParImpar(int i)
    {
        string saida = " ";

        saida = (i % 2 == 0) ? "par" : "impar";
        return saida;
     }


 }