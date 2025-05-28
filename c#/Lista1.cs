using System;
         /*
        cd c:\DEV\cshap
        PATH %path%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319
        */
class att1  {

static int numero=0;
    static void Main()
    {
        /*
          */
        Console.WriteLine("a) Peça ao usuário para digitar um número inteiro e armazene-o em uma\nvariável int. Em seguida, exiba o valor da variável na tela.\n");
           attA();
         numero=proximo(numero);

        /*
        b) Peça ao usuário para digitar um número real e armazene-o em uma variável\ndouble. Em seguida, exiba o valor da variável na tela.\n
        code:
        */
        Console.WriteLine("b) Peça ao usuário para digitar um número real e armazene-o em uma variável\ndouble. Em seguida, exiba o valor da variável na tela.\n");
       attB();
       numero=proximo(numero);
        /*
        code:
        */
        Console.WriteLine("c) Peça ao usuário para digitar um número de ponto flutuante e armazene-o em\numa variável float. Em seguida, exiba o valor da variável na tela.\n");
        attC();        
        numero=proximo(numero);
        /*
        code:
        */
        Console.WriteLine("d) Peça ao usuário para digitar &quot;sim&quot; ou &quot;não&quot; e armazene-o em uma variável\nbool. Em seguida, exiba o valor da variável na tela.\n");
        attD();
        numero=proximo(numero);
        /* 
        code:
        */
        Console.WriteLine("e) Peça ao usuário para digitar um caractere e armazene-o em uma variável\nchar. Em seguida, exiba o valor da variável na tela.\n");
       attE();
      numero=proximo(numero);
        /*
       code:
        */
        Console.WriteLine(" f) Peça ao usuário para digitar um número decimal e armazene-o em uma\nvariável decimal. Em seguida, exiba o valor da variável na tela.\n");
        attF();
       numero=proximo(numero); 
        /*
        code:
        */
        Console.WriteLine("g) Peça ao usuário para digitar o seu nome e a sua idade, e armazene-os em\nvariáveis string e int, respectivamente. Em seguida, exiba essas informações\nna tela.\n");
        attG();
        numero=proximo(numero); 

        /*
        code:
        */
Console.WriteLine("h) Peça ao usuário para digitar o preço de um produto e o seu desconto em\nporcentagem, e armazene-os em variáveis double. Em seguida, calcule o\npreço final com o desconto e exiba-o na tela.\n");
       // attH();
        //Console.WriteLine(porcentagem);
        //numero =proximo(numero);  
        /*
        i) Peça ao usuário para digitar uma palavra e armazene-a em uma variável
       \n string. Em seguida, exiba o comprimento da palavra na tela.\n
        code:
        */
        
        
        
        
        //numero=proximo(numero);  
        /*
        code:
        */
            //Console.WriteLine("j) Peça ao usuário para digitar o seu endereço completo, incluindo o número da\n casa, rua, bairro, cidade e estado. Armazene cada informação em uma\nvariável string e, em seguida, exiba todas as informações juntas em uma\núnica linha.\n");
            //attJ();

            //finalizar programa
            Console.WriteLine("aperte qualquer tecla p/ FIALIZAR");
            Console.ReadKey(true);
            Console.WriteLine("\n\n\n\n");
    } 
    
    
    
    
    
    static  int proximo(int numero)
    {
        numero++;
        Console.Write("\nAtividade {0} concluida\nAperte qualquer tecla p/ continuar......",numero);
        Console.ReadKey(true);
        Console.WriteLine("\n\n\n\n");
        return numero;
    }



    static void attA()
    {
        Console.WriteLine("Att: mostar um na tela um valor do usuario\n[DIGITE] um nº int:");
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine("O nº digitado foi  [{0}]",valor);
    }



    static void attB()
{
	Console.WriteLine("Att: mostar um na tela um valor do usuario\n[DIGITE] um nº real:");
        double real = double.Parse(Console.ReadLine());
        Console.WriteLine("O nº digitado foi  [{0}]",real);
}


static void attC()
{
	Console.WriteLine("Att: mostar um na tela um valor do usuario\n[DIGITE] um nº decimal:");
    float flo = float.Parse(Console.ReadLine());
    Console.WriteLine("O nº digitado foi  [{0}]",flo);
}


static void attD()
{
	Console.WriteLine("Att: mostar um na tela um valor do usuario\n[DIGITE] sim p/ verdadeiro ou nao p/ falso:");
    string palavra = Console.ReadLine();
    bool boo=(palavra=="sim" | palavra=="SIM")?true:false;
    Console.WriteLine("Saida foi {0}", boo);
}


static void attE()
{
	Console.WriteLine("Att: mostar um na tela um valor do usuario\n[DIGITE] um caracter:");
    char letra =Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Saida foi {0}", letra);
}


static void attF()
{
    Console.WriteLine("[DIGITE] um nº decima");
    decimal deci = decimal.Parse(Console.ReadLine());
    Console.WriteLine("O valor foi {0}",deci);

}





static void attG()
{
    string nome="n/d";
    int idade=0;

        for(int indice=0;indice<2;indice++)
        {
            string chave=(indice==0)?"nome":"idade";
            Console.WriteLine("\nAtt: mostar um na tela um nome e um numero inteiro p/ o usuario\n[DIGITE] um {0}: ",chave);
           
            switch(indice)
            {
                case 0:  
                    nome=Console.ReadLine();
                    break;
                case 1:
                    idade=int.Parse(Console.ReadLine());
                    break;
            }
	    }
    Console.WriteLine("Uma pessoa de nome {0} possui uma idade de {1}",nome,idade);    
}


static void att1H()
{

    Console.Write("[DIGITE] Preço pradrão: ");
    double preco=double.Parse(Console.ReadLine());
    Console.Write("[DIGITE] um valor de desconto em %: ");
    double porcentagem=double.Parse(Console.ReadLine())/100;
        
    Console.WriteLine("\n>> O valor do produto com o desconto e de {0:c}",porcentagem*preco);
}

}