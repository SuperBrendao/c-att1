
class att10
{
    static int q = 0;
    static void Main()
    {
        /*
        i) Criar um algoritmo que leia os elementos de uma matriz inteira 10x10. Some\ntodos os valores da matriz.\n
        j) Faça um programa que carregue:
        a. Um vetor de oito posições com os nomes das lojas;
        b. Um outro vetor com quatro posições com os nomes dos produtos;
        c. Uma matriz com os preços de todos os produtos em cada loja.
        O programa deve mostrar todas as relações (nome do produto - nome da loja
        - preço) nas quais o preço não ultrapasse R$ 120,00.
        */


        matriz33();//a)ok
        matriz1010Diagonal();//b)ok
        Matriz42SomaDe1a10(); //c)ok
        Matriz1010LerExPrin();//d)ok
        Matriz22Media();//e)ok
        Matriz33MaiorValorAte100();//f)ok
        Matriz44MosPar();//g)ok
        Matriz1010Ler();//h)ok
        MatrizSoma();//i)ok
        //Programa();//j)

    }

    static decimal matriz(int i, int j)
    {
        System.Console.WriteLine("[DETERMINE] [{0},{1}]", i+1, j+1);
        decimal saida = decimal.Parse(System.Console.ReadLine());
        return saida;
    }

    static void limp()
    {
        System.Console.WriteLine("\n[DIGITE] enter para continuar...");
        System.Console.ReadKey();
        System.Console.Clear();
}
    static void orderm(int elemento)
    {
        if (elemento < 10)
        {
            System.Console.Write("00" + elemento + " ");
        }
        else if (elemento < 100)
        { 
            System.Console.Write("0" + elemento + " ");
        }
        else
        {
            System.Console.Write(elemento + " ");
        }
    }
    
    static void mostrar(int i, int elemento)
    {
        q++;
        if (q < i)
        {
            orderm(elemento);
        }
        else
        {
            System.Console.Write("\n");
            orderm(elemento);
            q = 1;
        }
    }

    static void matriz33()
    {
        System.Console.WriteLine("a) Crie uma matriz de inteiros com 3 linhas e 3 colunas. Inicialize a matriz com\nvalores inteiros de sua escolha e, em seguida, exiba a matriz na tela.\n");
        int[,] elementos = new int[3, 3];//0a2,0a2

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                elementos[i, j] = (int)matriz(i, j);
            }
        }

        foreach (int item in elementos)
        {
            mostrar(4, item);
        }

        limp();
        
    }
    static void matriz1010Diagonal()
    {
        System.Console.WriteLine("b) Criar um algoritmo que leia os elementos de uma matriz inteira 10x10 e\nimprima os elementos da diagonal principal\n");
        int[,] elementos = new int[10, 10];//0a9,0a9

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                elementos[i, j] = 2 * i + j;
            }
        }

        foreach (int item in elementos)
        {
            mostrar(10, item);
        }
        System.Console.WriteLine("\n\n Diagonal principal");
        for (int i = 0; i < 10; i++)
        { System.Console.Write(elementos[i, i] + " "); }
        limp();
    }//b)

    static void Matriz42SomaDe1a10()
    {
        System.Console.WriteLine("c) Crie uma matriz de inteiros com 4 linhas e 2 colunas. Inicialize a matriz com\nvalores inteiros aleatórios entre 1 e 10 e, em seguida, calcule a soma de todos\nos valores da matriz.\n");
        int[,] elementos = new int[4, 2];//0a3,0a1
        int soma = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                elementos[i, j] = (int)matriz(i, j);
                if (elementos[i, j] < 10) { soma += elementos[i, j]; }
            }
        } 
        limp();      
    } //c)
    static void Matriz1010LerExPrin()
    {
        System.Console.WriteLine(" d) Criar um algoritmo que leia os elementos de uma matriz inteira 10x10 os \nelementos, exceto os elementos da diagonal principal.\n");
        int[,] elementos = new int[10, 10];//0a3,0a1

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                elementos[i, j] = 2*i+j;
            }
        }

        foreach (int i in elementos)
        {
            mostrar(11, i);
        }
        System.Console.WriteLine("\n");
        foreach (int i in elementos)
        {
            if (i % 2 == 0) { System.Console.Write(i + " "); }
        }       
        limp();
    }//d)
    static void Matriz22Media()
    {
        System.Console.WriteLine("*e) Crie uma matriz de números decimais com 2 linhas e 2 colunas. Inicialize a\nmatriz com valores decimais de sua escolha e, em seguida, calcule a média\ndos valores da matriz.\n");
        int[,] elementos = new int[2, 2];//0a3,0a1
        int q = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                elementos[i, j] = (int)matriz(i, j);
            }
        }
        double media = (double)elementos[0, 0];

        foreach (int t in elementos)
        {
            if (q == 0) { media = t; }
            else
            {
                media = (media + (double)t) / 2.0;
            }
        }
        System.Console.WriteLine("A media entre os valores e: [{0}]", media);
        limp();
    }//e)

    static void Matriz33MaiorValorAte100()
    {
        System.Console.WriteLine(" f) Crie uma matriz de inteiros com 3 linhas e 3 colunas. Inicialize a matriz com\nvalores inteiros aleatórios entre 1 e 100 e, em seguida, encontre o maior\nvalor da matriz.\n ");
        int[,] elementos = new int[3, 3];//0a3,0a1
        int MAX = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                elementos[i, j] = (int)matriz(i, j);

                MAX = (elementos[i, j] > MAX) ? elementos[i, j] : MAX;
            }
        }
        foreach (int i in elementos)
        {
            mostrar(4, i);
        }
        System.Console.WriteLine("\n\nO maior valor da matriz e " + MAX);
        limp();  
    }//f)
    static void Matriz44MosPar()
    {
        System.Console.WriteLine("G)Mostra apenas os n pares de uma matriz 4 por 4 :");

         int[,] elementos = new int[4, 4];//0a3,0a1

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                elementos[i, j] = (int)matriz(i, j);
            }
        }
            foreach (int w in elementos)
            {
                if (w % 2 == 0 && w!=0) { System.Console.WriteLine(w); }
            } limp();
        
         }//g)
    static void Matriz1010Ler()
    {
        System.Console.WriteLine(" g) Crie uma matriz de inteiros com 4 linhas e 4 colunas. Inicialize a matriz com\nvalores inteiros de sua escolha e, em seguida, exiba apenas os valores pares\nda matriz.\n ");
    int[,] elementos = new int[10, 10];
        
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    elementos[i, j] = (3 * i) + j;
                }
            }

            foreach (int item in elementos)
            {
                mostrar(11, item);
            }
        limp();
    }//h)
    static void MatrizSoma()
    {
        System.Console.WriteLine("h) Criar um algoritmo que leia os elementos de uma matriz inteira 10x10 e\nimprima os elementos da matriz.\n");
        int[,] elementos = new int[10, 10];
        int soma = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                elementos[i, j] = (3 * i) + j;
                soma += elementos[i, j];
            }
        }

        foreach (int item in elementos)
        {
            mostrar(11, item);
        }
        System.Console.WriteLine("\n\nA soma entre os elementos da matriz e [{0}]", soma);
        limp();

    }//i)
        static void Programa(){ }//j)
}