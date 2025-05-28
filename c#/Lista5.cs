/*
 a) Verifique se um número é par ou ímpar.
b) Encontre o maior entre dois números.
c) Verifique se uma lista está vazia.
d) Verifique se uma string está vazia.
e) Verifique se uma condição é verdadeira.
f) Calcule o valor absoluto de um número.
g) Verifique se um número é positivo, negativo ou zero.
h) Converta uma string em um número.
i) Verifique se um número é divisível por outro.
j) Verifique se uma variável é nula ou não.
 */
using System;


namespace PAtrilhasAtiv05
{
    class A05
    {
        public static void Main()
        {
            int[] valor=new int[2];//0 e 1
           
            for(int i=0;i<2;i++){
                Console.WriteLine("[DIGITE] o {0}º valor: ",i+1);
                valor[i]=int.Parse(Console.ReadLine());
            }
           
            for(int i=0;i<2;i++){
                parimpar(valor[i]);
                positivonegarivo(valor[i]);
            }
            maioremenor(valor[0],valor[1]);
            somasubidração(valor[0],valor[1]);
            //divisibilidade(valor[0],valor[1]);erro
           
           
            Console.ReadKey();
        }


        static void parimpar(int valor)
        {
            string saida = (valor % 2 == 0) ? "PAR" : "IMPAR";
            Console.WriteLine("o valor {0} e {1}\n",valor,saida);
        }




        static void positivonegarivo(int valor)
        {
            if (valor != 0) {
                string saida = (valor<0) ?"negatino":"possitivo";
                Console.WriteLine("o numero {0} e {1}\n", valor,saida);
            } else { Console.WriteLine("Valor nulo\n"); }
        }


        static void maioremenor(int valor0, int valor1)
        {
            if (valor0 > valor1)
            {
                Console.WriteLine("O valor {0} e maior que {1}\n",valor0,valor1);
            }else{Console.WriteLine("O valor {0} e maior que {1}\n",valor1,valor0);}


        }






        static void somasubidração(int valor0, int valor1)
        {
            Console.WriteLine("Soma e {0}\nsupitracão {1}\n", valor0 + valor1, valor0 - valor1);
        }






        static void divisibilidade(int valor0, int valor1)
        {
            Console.WriteLine(valor0    );
            Console.WriteLine(valor1    );
            double valor00 = (double)valor0;
            double valor11 = (double)valor1;

            Console.WriteLine("OK");
            Console.WriteLine("A divisão entre o {0} / {1} = {3} ",valor00,valor11,valor00/valor11);
        }
    }
}
