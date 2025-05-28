/*
1. Crie os códigos no SharpDevelop:

a) Crie um programa que solicite ao usuário para inserir um número inteiro
positivo e, em seguida, exiba todos os números pares entre 0 e o número
inserido.
b) Desenvolva um programa que solicite ao usuário para inserir um número
inteiro e, em seguida, exiba a tabuada desse número até o número 10.
c) Crie um programa que solicite ao usuário para inserir uma sequência de
números inteiros e, em seguida, exiba a soma desses números.
d) Desenvolva um programa que solicite ao usuário para inserir uma senha e,
em seguida, permita que o usuário tente inserir a senha até três vezes. Caso o
usuário acerte a senha, exiba uma mensagem de sucesso. Caso contrário,
exiba uma mensagem informando que a senha está incorreta.
e) Crie um programa que solicite ao usuário para inserir números inteiros até
que um número negativo seja inserido. Em seguida, exiba a soma dos
números inseridos (excluindo o número negativo).

*/

using System;

class att06
{
    static void Main()
    {
        bool sair = false;
        do
        {
            switch (menu())
            {
                case '1':
                    Par0ateN();//0k
                    break;
                case '2':
                    TabuadaDeN();//0K
                    break;
                case '3':
                     SomaDeN();//0K
                    break;
                case '4':
                    CriarEvalidarSenha();//0K
                    break;
                case '5':
                    SomaNpositivo();//0K
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
        Console.WriteLine("\n[DIGITE] p/ :\n(1)-Par0ateN\n(2)-TabuadaDeN\n(3)-SomaDeN\n(4)-CriarEvalidarSenha\n(5)-SomaNpositivo\n(9)-finalizar");
        char valor = char.Parse(Console.ReadLine());
        return valor;
     }



    static void Par0ateN()
    {
        int i = 0;//indice dowhile

        Console.WriteLine("[DIGITE] um numero inteiro p/ definir todos seus antecesores pares: ");
        int valor = int.Parse(Console.ReadLine());

        do
        {
            if (i % 10 == 0) { Console.Write("\n"); }
            if (i % 2 == 0) { Console.Write(i + " "); }

            i++;
        } while (i <= valor);
        Console.WriteLine("\n");
    }
    static void TabuadaDeN()
    {
        int i = 0;
        Console.WriteLine("[DIGITE] um valor real para determinar sua tabuada :");
        decimal elemento = decimal.Parse(Console.ReadLine());
        Console.Clear();

        do
        {
            Console.WriteLine("({0}) * ({1}) = ({2})", i, elemento, elemento * (decimal)i);
            i++;
        }while(i < 11);
       
        Console.WriteLine("[DIGITE] <enter> p/ finalizar...");
        Console.ReadKey();
        
    }
    static void SomaDeN()
    {
        int i = 0;
        int valor = 0;
        //pedir para o usuario dar um valor de repetição
        Console.WriteLine("[DIGITE] a quantidade de elementos para serem somados");
        int rept = int.Parse(Console.ReadLine());
        Console.Clear();

        do
        {
            Console.WriteLine("[DIGITE] o valor {0}: ", i + 1);
            valor = int.Parse(Console.ReadLine()) + valor;
            i++;
            Console.Clear();
        } while (i < rept);

        Console.WriteLine("O somatorio e {0}", valor);
        Console.WriteLine("Finalizado...");
        Console.ReadKey();
        Console.Clear();
     }
    static void CriarEvalidarSenha()
    {
        string[] senha_user = new string[2];
       
        bool fim = false;

        Console.Clear();
        do
        {
         int i = 0;
            do
            {
                string texto = (i == 0) ? "Incira uma senha" : "Confimar senha";
                Console.WriteLine(texto);
                senha_user[i] = Console.ReadLine();
                i++;
            } while (i < 2);

            if (senha_user[0] == senha_user[1]) { Console.WriteLine("Registrado.."); fim = true; }
            else { Console.WriteLine("As duas senhas estao diferentes...."); }
            Console.ReadKey();
            Console.Clear();
        } while (fim != true);
     }
    static void SomaNpositivo()
    {
        Console.Clear();
        int elemento = 0,valor=0, i=0;

        do
        {

            Console.WriteLine("[DIGITE] o valor {0}: ", i + 1);
            elemento = int.Parse(Console.ReadLine());
            if (elemento >= 0) { valor = elemento + valor; }
            i++;
           
            Console.Clear();

        } while (elemento > 0);
       
        Console.WriteLine("O somatorio e {0}",valor);
    }
}
