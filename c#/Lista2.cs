/*
1. Crie os códigos no SharpDevelop:
a) Escreva um programa que peça ao usuário para digitar dois números e exiba
a soma deles.
b) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu dobro.
c) Escreva um programa que peça ao usuário para digitar um número e exiba a
sua metade.
d) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu quadrado.
e) Escreva um programa que peça ao usuário para digitar dois números e exiba
o resultado da divisão do primeiro pelo segundo.
f) Escreva um programa que peça ao usuário para digitar um número e exiba a
sua raiz quadrada.
g) Escreva um programa que peça ao usuário para digitar dois números e exiba
o resultado da subtração do segundo pelo primeiro.
h) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu valor absoluto.
i) Escreva um programa que peça ao usuário para digitar dois números e exiba
o resultado da multiplicação entre eles.
j) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu resto da divisão por 2.

*/
using System;

class calculadora
{
    static double[] num = new double[2];//0 e 1
    static void Main()
    {
        bool sair = false;
        do
        {
            switch (menu())
            {
                case '1':
                    soma();
                    break;
                case '2':
                    subi();
                    break;
                case '3':
                    mult();
                    break;
                case '4':
                    pote();
                    break;
                case '9':
                    Console.WriteLine("Programa finalizado...");
                    Console.ReadKey();
                    sair = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Por favor, digite apenas o que foi pedido....");
                    Console.ReadKey();
                    break;
            } 
            
        } while (sair == false);
    }
    static char menu()
    {
        Console.Clear();
        Console.WriteLine("Calculadora\n[DIGITE] p/ :\n(1)-soma\n(2)-subitracao\n(3)-multiplicao\n(4)-potencia\n(9)-finalizar");
        char valor = char.Parse(Console.ReadLine());
        return valor;
    }

    static double valor()
    {
        Console.WriteLine("[DIGITE] o valor :");
        double num = double.Parse(Console.ReadLine());
        return num;
    }

    static void tempo()
    {
       Console.ReadKey();
    }



    static void soma()
    {
        for (int i = 0; i < num.Length; i++) { num[i] = valor(); }
        Console.WriteLine("A soma entre {0} e {1} e igual a {2}", num[0], num[1], num[1] + num[0]);
        tempo();
    }
    static void subi()
    {
        for (int i = 0; i < num.Length; i++) { num[i] = valor(); }
        Console.WriteLine("A sub entre {0} e {1} e igual a {2}", num[0], num[1], num[1] - num[0]);
        tempo();
    }
    static void mult()
    {
        for (int i = 0; i < num.Length; i++) { num[i] = valor(); }
        Console.WriteLine("A mult entre {0} e {1} e igual a {2}", num[0], num[1], num[1] * num[0]);
        tempo();
    }
    static void pote()
    {
        double banco = 1;
        for (int i = 0; i < num.Length; i++) { num[i] = valor(); }
        if (num[1] >= 0)
        {
            for (int i = 0; i < num[1]; i++) { banco *= num[0]; }
        }else
        { 
            double k=-1*num[1];
            for (int i = 0; i < k; i++) { banco *= (1 / num[0]); }
        }
       
        Console.WriteLine("A mult entre {0}^({1}) e igual a {2}", num[0], num[1], banco);
        tempo();
    }
}