using System;


class att04
{


    static void Main()
    {
        /*
          */
        Console.WriteLine("a) Escreva um programa que pergunte ao usuário sua idade e se tem carteira de\nmotorista. Se o usuário tiver mais de 18 anos e possuir carteira de motorista,\no programa deve imprimir &quot;Você pode dirigir&quot;.\n");
        carteiramorirista();
        proximo();

        /*
          */
        Console.WriteLine("b) Escreva um programa que pergunte ao usuário se ele deseja comprar um\ncarro novo e se tem dinheiro suficiente para isso. Se o usuário quiser\ncomprar um carro novo e tiver dinheiro suficiente, o programa deve\nimprimir &quot;Parabéns, você pode comprar um carro novo!&quot;.\n");
        pobre();
        proximo();

        /*
        */
        Console.WriteLine("c) Escreva um programa que pergunte ao usuário se ele possui um diploma de\nensino superior e se tem mais de 21 anos. Se o usuário possuir um diploma \nnde ensino superior e tiver mais de 21 anos, o programa deve imprimir\n&quot;Parabéns, você está qualificado para a vaga!&quot;.\n");
        diploma();
        proximo();

        /*
        
        */
        Console.WriteLine("d) Escreva um programa que pergunte ao usuário se ele é assinante de um\nserviço de streaming e se já assistiu a uma série específica. Se o usuário for\nassinante e já tiver assistido à série, o programa deve imprimir &quot;Ótimo, agora\nvocê pode assistir à nova temporada!&quot;.\n");
        bomdia();
        proximo();

        /*
        e) Escreva um programa que solicite ao usuário o seu nome e idade. O
        \nprograma deve verificar se o nome possui mais de 3 caracteres e se a idade é
       \n maior ou igual a 18 anos. Se ambas as condições forem verdadeiras, o
        \nprograma deve imprimir &quot;Acesso permitido&quot;. Caso contrário, deve imprimir
        \n&quot;Acesso negado&quot;.\n
        */

        // Console.WriteLine("Qual e sua idade");
        // int idade = int.Parse(Console.ReadLine());
        //string nome = Console.ReadLine();
        //string verificador ="zzz";
        //bool oi = (nome>verificador);
        //Console.WriteLine(oi);
        //proximo();

        /*
       */
        Console.WriteLine(" f) Escreva um programa que pergunte ao usuário se ele deseja adicionar açúcar\nou leite ao seu café. Se o usuário responder que deseja adicionar açúcar OU\nleite, o programa deve imprimir a mensagem &quot;Café com adicional\npreparado!&quot;..\n");
        cafe();
        proximo();


        /*
        */
        Console.WriteLine("g) Crie um programa que solicite ao usuário um número inteiro e verifique se\nele é divisível por 3 OU por 5. Se o número for divisível por 3 OU por 5, o\nprograma deve imprimir a mensagem &quot;O número é divisível por 3 ou por\n5!&quot;..\n");
        numer();
        proximo();

        /*
        */
        Console.WriteLine("h) Escreva um programa que pergunte ao usuário se ele deseja comprar um\nproduto. Se o usuário responder &quot;sim&quot; OU &quot;s&quot;, o programa deve imprimir a\nmensagem &quot;Obrigado pela compra!&quot;..\n");
        mai();
        proximo();
        /*
    */
        Console.WriteLine("i) Crie um programa que solicite ao usuário o seu nome e verifique se ele é\nigual a &quot;Wilson&quot; OU &quot;Gloria&quot;. Se o nome for igual a &quot;Wilson&quot; OU &quot;Gloria&quot;,\no programa deve imprimir a mensagem &quot;Olá, bem-vindo(a) de volta!&quot;..\n");
        bemvindo();
        proximo();

        /*
        j) Escreva um programa que solicite ao usuário um número inteiro e verifique\nse ele é maior do que 10 OU menor do que 0. Se o número for maior do que\n10 OU menor do que 0, o programa deve imprimir a mensagem &quot;Número\ninválido!&quot;.\n
        */


        /*
        */

        Console.WriteLine("k) Escreva um programa que pergunte ao usuário se ele não é um robô. Se a\nresposta for negativa, o programa deve imprimir &quot;Por favor, prove que você\nnão é um robô&quot;.\n");
        prova();
        proximo();

        /*
        l) Crie um programa que peça ao usuário para digitar um número e verifique se
       \n ele não é igual a zero. Se a condição for verdadeira, o programa deve
        \nimprimir &quot;O número é diferente de zero&quot;.\n
        */


        /*
        m) Escreva um programa que pergunte ao usuário se ele não é um membro
        \ninativo de um clube. Se a resposta for negativa, o programa deve imprimir
        \n&quot;Por favor, atualize sua inscrição para continuar usufruindo dos benefícios
        \ndo clube&quot;.\n
        */

        /*
        n) Crie um programa que peça ao usuário para digitar uma palavra e verifique
        \nse ela não é vazia. Se a condição for verdadeira, o programa deve imprimir
        \n&quot;A palavra não é vazia&quot;.\n
        */

        /*
        o) Escreva um programa que pergunte ao usuário se ele não deseja cancelar
        \numa operação. Se a resposta for negativa, o programa deve imprimir &quot;Por
        \nfavor, confirme o cancelamento da operação&quot;.

        */
    }


    static void proximo()
    {
        Console.WriteLine("Atividade finalizada");
        Console.ReadKey();
    }




    static void carteiramorirista()
    {
        Console.WriteLine("[DIGITE] sua idade");

        int idade = int.Parse(Console.ReadLine());
        if (idade > 17)
        {
            char carteira = 'i';
            do
            {
                Console.WriteLine("Voce possui carteira ?\n[n/s]");
                carteira = char.Parse(Console.ReadLine());

                switch (carteira)
                {
                    case 'S':
                    case 's':
                        Console.WriteLine("Voce possui {0} anos e possui carteira", idade);
                        break;
                    case 'N':
                    case 'n':
                        break;
                    default:
                        Console.WriteLine("Por favor, [DIGITE APENAS O QUE FOI PEDIDO]\n[DIGITE] <ENTER> para continuar...\n");
                        break;
                }
                Console.ReadKey(true);
            } while (carteira != 'S' && carteira != 's' && carteira != 'N' && carteira != 'n');
        }
    }



    static void pobre()
    {
        char quer = 'a';
        do
        {
            Console.WriteLine("Voce possui interece por um carro");
            quer = char.Parse(Console.ReadLine());

            if (quer != 's' || quer != 'S')
            {
                Console.WriteLine("Qual e seu saldo:");
                double credito = double.Parse(Console.ReadLine());

                if (credito > 10000) { Console.WriteLine("Voce pode comprar"); } else { Console.WriteLine("sai daqui seu pobre!!"); }
            }
        } while (quer != 's' && quer != 'S' && quer != 'n' && quer != 'N');
    }



    static void diploma()
    {
        Console.WriteLine("[DIGITE] sua idade");
        int idade = int.Parse(Console.ReadLine());
        if (idade > 21)
        {
            char carteira = 'i';
            do
            {
                Console.WriteLine("Voce possui diploma ?\n[n/s]");
                carteira = char.Parse(Console.ReadLine());

                switch (carteira)
                {
                    case 'S':
                    case 's':
                        Console.WriteLine("Voce possui {0} anos e possui diploma", idade);
                        break;
                    case 'N':
                    case 'n':
                        break;
                    default:
                        Console.WriteLine("Por favor, [DIGITE APENAS O QUE FOI PEDIDO]\n[DIGITE] <ENTER> para continuar...\n");
                        break;
                }
                Console.ReadKey(true);
            } while (carteira != 'S' && carteira != 's' && carteira != 'N' && carteira != 'n');
        }
    }



    static void bomdia()
    {
        Console.WriteLine("Voce assite algum serviço de streaming?\n[s/n]");
        char saol = char.Parse(Console.ReadLine());
        if (saol == 'S' || saol == 's')
        {
            Console.WriteLine("Qual e a serie que vc assite ");
            string oir = Console.ReadLine();
            Console.WriteLine("Agora confira a nova temporada de {0}", oir);
        }
    }



    static void cafe()
    {
        char entrada = '0';
        string quero = "";

        do
        {
            Console.WriteLine("voce gostaria de colocar leite ou acucar em seu cafe ?\n['s','n']");
            entrada = char.Parse(Console.ReadLine());
        } while (entrada != 'n' || entrada != 'N' || entrada != 'S' || entrada != 's');

        if (entrada == 'S' || entrada == 's')
        {
            do
            {
                Console.WriteLine("[acucar/leite]");
                quero = Console.ReadLine();
            } while (quero != "acucar" || quero != "leite");

            if (quero != "") { Console.WriteLine("Foi add {0} ao seu cafe", quero); }
        }
    }
    static void numer()
    {
        Console.WriteLine("[DIGITE] um numero");
        int num = int.Parse(Console.ReadLine());

        if (num % 3 == 0)
        {
            Console.WriteLine("O {0} e divisivel por 3", num);
        }
        if (num % 5 == 0)
        {
            Console.WriteLine("O {0} e divisivel por 5", num);
        }
    }


    static void mai()
    {
        char ent = 'a';
        do
        {
            Console.WriteLine("Voce quer fazer a compra?");
            ent = char.Parse(Console.ReadLine());
        } while (ent != 'S' || ent != 's' || ent != 'N' || ent != 'n');
        if (ent == 's' || ent == 'S')
        {
            Console.WriteLine("Obrigado pela compra!");

        }
        proximo();
    }

    static void bemvindo()
    {
        string[] NomeCliente = new string[2] { "Wilson", "Gloria", };
        string oi = "";
        Console.WriteLine("[DIGITE] um nome");
        string nome = Console.ReadLine();

        for (int i = 0; i < 2; i++)
        {

            if (nome == NomeCliente[i])
            {
                oi = "Bem vindo de volta";
                nome = NomeCliente[i];
            }
        }
        Console.WriteLine("Bem vindo {0} {1}", oi, nome);
        proximo();
    }

static void prova()
        {
            Console.WriteLine("Voce e um robo");
            char dd = char.Parse(Console.ReadLine());
            Console.WriteLine("Agora prova");
        }

}