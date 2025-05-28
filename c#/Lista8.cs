/*
Crie os códigos no SharpDevelop:
*/
using System;
class att08
{

   static int globaa = 1;
    static void Main()
    {
        
        Console.WriteLine("a) Crie um programa que exiba todos os números pares entre 0 e 100.\n");
        par();//1
        limp();
         Console.WriteLine("b) Desenvolva um programa que solicite ao usuário para inserir um número\ninteiro positivo e, em seguida, exiba todos os números pares entre 0 e o\nnúmero inserido.\n");
        parN();//2
        limp();
               //palavra();//shhhhhhhhhhhhhhh nao tem nada aqui
        Console.WriteLine("d) Desenvolva um programa que solicite ao usuário para inserir um número\ninteiro positivo e, em seguida, exiba a soma de todos os números entre 1 e o\nnúmero inserido.\n");
        somatorioDeN(na(), '0');//4
        limp();
         Console.WriteLine("e) Crie um programa que solicite ao usuário para inserir um número inteiro e,\nem seguida, exiba se esse número é primo ou não.\n");
        heprimo();//5
        limp();
         Console.WriteLine("f) Desenvolva um programa que solicite ao usuário para inserir uma sequência\nde números inteiros e, em seguida, exiba o maior número inserido.\n");
        maiorn();//6
        limp();
         Console.WriteLine("h) Desenvolva um programa que solicite ao usuário para inserir um número\ninteiro positivo e, em seguida, exiba todos os divisores desse número.\n");
        Console.WriteLine("taboada de 5 ate 10");//7
        div(na());//08
        limp();
         Console.WriteLine("i) Crie um programa que exiba todos os números primos entre 1 e 100.\n");
        div(100);//09
        limp();
         Console.WriteLine("j) Desenvolva um programa que exiba a soma dos números pares entre 1 e 100.\n");
        somatorioDeN(100, 'S');//10
        limp();
    }

static void limp()
    {
        System.Console.WriteLine("\n[DIGITE] enter para continuar...");
        System.Console.ReadKey();
        System.Console.Clear();
    }
    
    static int na()
    {
        Console.WriteLine("Digite um nº positipo");
        int valor = int.Parse(Console.ReadLine());
        return valor;
    }
    static void proximo()
    {
        Console.WriteLine("\nParte {0} comcuida\n", globaa);
        Console.ReadKey();
        globaa++;
    }
  
    














    static void par() { for (int i = 2; i < 100; i += 2) { Console.Write(i); } proximo(); }
    static void parN()
    {
        Console.WriteLine("[DIGITE] um valor:");
        int num = int.Parse(Console.ReadLine());
        for (int i = 2; i < num; i += 2) { Console.WriteLine(i); }
        proximo();
    }
    static void somatorioDeN(int valor, char par)
    {
        int j = (par != 'S') ? 1 : 2;
        Console.WriteLine(j);
        int banco = 0;
        Console.WriteLine("Digite um nº positipo");
        for (int i = valor; i > 0; i -= j) { banco = banco + i; }
        Console.WriteLine(banco);
        proximo();
    }
    //int.Parse(Console.ReadLine())


    static void heprimo()
    {
        Console.WriteLine("Digite um nº positipo");
        decimal elemento = decimal.Parse(Console.ReadLine());
        string chave = "nao";

        if (elemento == 2 || elemento == 3 || elemento == 5 || elemento == 7)
        {
            chave = "e";
        }
        else if (elemento % 2 > 0)
        {
            //O elemento e impar e maior que 10
            decimal metadeElemento = (elemento - 1) / 2;
            decimal banco = 0;
            for (decimal i = 3; i < metadeElemento + 1; i += 2)
            {
                banco = (elemento % i == 0) ? banco + 1 : banco + 0;
                if (banco > 0) { break; } else if (i >= metadeElemento) { chave = "e"; }
            }
        }
        Console.WriteLine("O elemento {0} e {1} primo", elemento, chave);
        proximo();
    }

    static void maiorn()
    {
        int[] list = new int[5];
        int banco = 0;

        for (int ii = 0; ii < 2; ii++)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (ii == 0)
                {
                    Console.WriteLine("numero {0}", i + 1);
                    list[i] = int.Parse(Console.ReadLine());
                    banco = list[0];
                }
                else//ii==1
                {
                    banco = (list[i] > banco) ? list[i] : banco;
                }
            }
        }
        Console.WriteLine("O maior nº desta sequencia e {0}", banco);
        proximo();
    }













    static void div(int valor)
    {
       Console.WriteLine(valor);

        int elemento = valor;
        int banco = 0;
        Console.WriteLine("Divisores");

        for (int i = 1; i < elemento + 1; i += 1)
        {
            banco = (elemento % i == 0) ? banco + 1 : banco + 0;
            if (elemento % i == 0) { Console.Write(i + " "); }
        }


        Console.WriteLine("\nn de Divisores = {0}\n",banco);
    }


    static decimal primo()
    {
        decimal elemento=0;
        do
        {
            if (elemento == 2 || elemento == 3 || elemento == 5 || elemento == 7)
            {
                return elemento;
                //pri++;//mais nº primo
            }
            else if (elemento % 2 > 0)
            {
                //O elemento e impar e maior que 10
                decimal metadeElemento = (elemento - 1) / 2;
                decimal banco = 0;
                for (decimal i = 3; i < metadeElemento + 1; i += 2)
                {
                    banco = (elemento % i == 0) ? banco + 1 : banco + 0;
                    if (banco > 0) { break; } else if (i >= metadeElemento) { /*pri++;//mais nº primo;*/ return elemento; }
                }
            }
            elemento++;
        } while (elemento != 0);
        return 0;
     }



}