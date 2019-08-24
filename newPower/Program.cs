using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newPower
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Numero 1 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Numero 2 : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Numero 3 : ");
            int c = int.Parse(Console.ReadLine());

            int maior = a;
            int menor = a;

            if(a > maior)
            {
                maior = a;
            }
            if(b > maior)
            {
                maior = b;
            }
            if(c > maior)
            {
                maior = c;
            }
            if(a < menor)
            {
                menor = b;
            }
            if(b < menor)
            {
                menor = b;
            }
            if (c < menor)
            {
                menor = c;
            }

            Console.WriteLine(maior);
            Console.WriteLine(menor); 

            Console.Write("Qual é seu idade : ");
            int n = int.Parse(Console.ReadLine());
            if(n < 10)
            {
                Console.WriteLine("Criaça");
            }else if(n < 18)
            {
                Console.WriteLine("Adolescente");
            }else if(n < 60)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("idoso");
            }
            Console.WriteLine("Fim");

            Console.Write("O numero que vai digitar vou te imprime a tabuala : ");

            int num = int.Parse(Console.ReadLine());
            int n = 0;
            while(n <= 10)
            {
                int c = num * n;
                Console.WriteLine(num + " X " + n + " = " + c);
                n++;
            }


            Console.WriteLine("Bem vindo no Senai\n");
            Console.Write("Digite seu Usuário : ");
            string usuario = Console.ReadLine();
            Console.Write("Senha : ");
            string senha = Console.ReadLine();


            while (senha != "aspnetmvc" || usuario != "aspnetmvc")
            {
                Console.WriteLine("Invalido, tente novamente\n");
                Console.Write("Usuário : ");
                usuario = Console.ReadLine();
                Console.Write("Senha :");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Parabens, pode entrar");


            Console.ReadKey();




            /* 
              Console.Write("Boa noite; Poderia me Informar seu nome? : ");
               string nome = Console.ReadLine();
               Console.Write("Qual é o preço que voce paga de passagem no onibus? : ");
               int preco = int.Parse(Console.ReadLine());
               Console.Write("Quantas passagens uma pessoa utiliza por dia? : ");
               int pass = int.Parse(Console.ReadLine());
               Console.Write("voce é de sexo (M) por mascilino e (F) por femino? : ");
               string sexo = Console.ReadLine();
               int d = 24;
               int custa = preco * pass * d;

               if (sexo == "m")
               {
                   Console.WriteLine("Sr " + nome + " o custa do seu passagem por mês custa : " + "R$ " + custa );
               }
               else if(sexo == "f")
               {
                   Console.WriteLine("Sra " + nome + " o custa do seu passagem por mês custa : " + "R$ " + custa);

               }
               else
               {
                   Console.WriteLine("se fodeu; voce não existe cara");
               }

             Console.Write("Qual é seu sexo ? [M] por Mascilino e [F] por feminino : ");
             string sexo = Console.ReadLine();
             Console.Write("Qual é seu idade : ");
             int idade = int.Parse(Console.ReadLine());
             int mn = 65;
             int h = 60;
             int m2 = mn - idade;
             int h2 = h - idade;
             int m3 = idade - mn;
             int h3 = idade - h;

             if (sexo == "m" || sexo == "M")
             {
                 if (idade < mn)
                 {
                     Console.WriteLine("Seu idade é " + idade + " anos " + " e vai aposetar daqui ao " + h2 + " anos");
                 }
                 else if (idade > mn){
                     Console.WriteLine("voce já aposetou, faz " + m3 + " anos");
                 }
             }
             else if (sexo == "f" || sexo == "F")
             {
                 if (idade < h)
                 {
                     Console.WriteLine("Seu idade é " + idade + " e vai aposetar daqui ao " + m2 + " anos");
                 }
                 else if (idade > h)
                         {
                     Console.WriteLine("voce já aposetou, faz " + h3 + " anos");
                 }

             }
             else
             {
                 Console.WriteLine("Cara, voce não sabe de qual sexo voce é? então vai se vira");
             }

              Console.WriteLine("Escolha [T] para calcular o Triânglo e [R] para Retângulo");
              string cal = Console.ReadLine();

              Console.Write("Digite uma  Base? : ");
              int bas = int.Parse(Console.ReadLine());

              Console.Write("E qual é a altura? : ");
              int altura = int.Parse(Console.ReadLine());
              int for1 = (bas * altura) / 2;
              int for2 = bas * altura;

              if(cal == "t")
              {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.WriteLine(for1);
              }
              else if(cal == "r"){
                  Console.ForegroundColor = ConsoleColor.DarkMagenta;
                  Console.WriteLine(for2);
              }
              else
              {
                  Console.ForegroundColor = ConsoleColor.DarkRed;
                  Console.WriteLine("Cara, voce é zeradooooooo; voce escolhou o calculo errado!");
              }

             Console.WriteLine("Digite um numero menor que 100, entendeu menor que 100");
             int num = int.Parse(Console.ReadLine());
             while (true)
             {
                 Console.WriteLine("voce digitou o numero maior do 100 tenta de novo");
                 num = int.Parse(Console.ReadLine());
                 if(num < 100)
                 {
                     break;
                 }
             }
             if (num >= 0)
             {
                 while (num != 100)
                 {
                     ++num;
                     Console.WriteLine(num);
                 }
             }
             else
             {
                 while (num != 0)
                 {
                     ++num;
                     Console.WriteLine(num);
                 }
             }           

             


            while (true)
            {

                Console.Write("O numero que vai digitar vou te imprime a tabuala 10 vezes : ");
                string texto = Console.ReadLine();
                if(texto == "")
                {
                    break;
                }

                int num = int.Parse(texto);
               
                Console.Clear();

                int n = 0;
                while (n <= 10)
                {
                    int c = num * n;
                    Console.WriteLine(num + " X " + n + " = " + c);
                    n++;

                }
                Console.ReadLine();
            }*/



            int som = 0;

            while (true)
            {
                Console.Write("Digite o numero : ");

                int num = int.Parse(Console.ReadLine());
                som = som + num;
                Console.WriteLine(som);

            }

        }
    }
}
